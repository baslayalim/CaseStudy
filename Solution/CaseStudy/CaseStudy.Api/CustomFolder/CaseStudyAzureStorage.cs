
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Files.Shares;
using System.IO;

namespace CaseStudy.Api.CustomFolder
{
    public class CaseStudyAzureStorage : ICaseStudyStorage
    {
        readonly BlobServiceClient _blobServiceClient;
        BlobContainerClient? _blobContainerClient;
        public CaseStudyAzureStorage()
        {
            _blobServiceClient = new("");
        }
        public void DeleteAsync(string containerName, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = _blobContainerClient.GetBlobClient(fileName);
            blobClient.DeleteAsync();
        }

        public List<string> GetFiles(string containerName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            return _blobContainerClient.GetBlobs().Select(b => b.Name).ToList();
        }

        public bool HasFile(string containerName, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            return _blobContainerClient.GetBlobs().Any(b => b.Name == fileName);
        }

        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string containerName, IFormFileCollection files)
        {
            await FileUploadAsync(files);

            //_blobContainerClient = _blobServiceClient.GetBlobContainerClient("product-image");
            //await _blobContainerClient.CreateIfNotExistsAsync();
            //await _blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            List<(string fileName, string pathOrContainerName)> datas = new();
            //foreach (IFormFile file in files)
            //{
            //    FileInfo fileInfo = new FileInfo(file.FileName);
            //    string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name) + "-" + Guid.NewGuid() + fileInfo.Extension;

            //    BlobClient blobClient = _blobContainerClient.GetBlobClient(fileName);
            //    await blobClient.UploadAsync(file.OpenReadStream());
            //    datas.Add((fileName, $"{containerName}/{fileName}"));
            //}
            return datas;
        }

        public async Task FileUploadAsync(IFormFileCollection files)
        {
            // Get the configurations and create share object
            ShareClient share = new ShareClient("", "product-image");


            // Create the share if it doesn't already exist
            await share.CreateIfNotExistsAsync();

            // Check the file share is present or not
            if (await share.ExistsAsync())
            {
                // Get a reference to the sample directory
                ShareDirectoryClient directory = share.GetDirectoryClient("FileShareDemoFiles");

                // Create the directory if it doesn't already exist
                await directory.CreateIfNotExistsAsync();

                // Ensure that the directory exists
                if (await directory.ExistsAsync())
                {
                    // Get a reference to a file and upload it
                    ShareFileClient file = directory.GetFileClient(files[0].FileName);

                    string s = "";
                    foreach (var filess in files)
                    {
                        if (filess.Length > 0)
                        {
                            using (var ms = new MemoryStream())
                            {
                                filess.CopyTo(ms);
                                var fileBytes = ms.ToArray();
                                s = Convert.ToBase64String(fileBytes); 
                            }
                        }
                    }

                    using var stream = File.OpenWrite(files[0].FileName);

                    //using (FileStream stream = File.OpenRead(files[0]))
                    //{
                    //    file.Create(stream.Length);
                    //    file.UploadRange(
                    //        new HttpRange(0, stream.Length),
                    //        stream);
                    //}
                }
            }
            else
            {
                Console.WriteLine($"File is not upload successfully");
            }
        }

        //public async Task FileDownloadAsync(string fileShareName)
        //{
        //    ShareClient share = new ShareClient(_config.GetConnectionString("default"), _config.GetValue<string>("FileShareDetails:FileShareName"));
        //    ShareDirectoryClient directory = share.GetDirectoryClient("FileShareDemoFiles");
        //    ShareFileClient file = directory.GetFileClient(fileShareName);

        //    // Check path
        //    var filesPath = Directory.GetCurrentDirectory() + "/files";
        //    if (!System.IO.Directory.Exists(filesPath))
        //    {
        //        Directory.CreateDirectory(filesPath);
        //    }

        //    var fileName = Path.GetFileName(fileShareName);
        //    var filePath = Path.Combine(filesPath, fileName);

        //    // Download the file
        //    ShareFileDownloadInfo download = file.Download();
        //    using (FileStream stream = File.OpenWrite(filePath))
        //    {
        //        await download.Content.CopyToAsync(stream);
        //    }
        //}


    }
}