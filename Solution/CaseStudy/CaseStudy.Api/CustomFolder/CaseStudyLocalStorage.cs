namespace CaseStudy.Api.CustomFolder
{
    public class CaseStudyLocalStorage : ICaseStudyStorage
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CaseStudyLocalStorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public void DeleteAsync(string path, string fileName) => File.Delete($"{path}\\{fileName}");
        public bool HasFile(string path, string fileName) => File.Exists($"{path}\\{fileName}");
        public List<string> GetFiles(string path)
        {
            DirectoryInfo directory = new(path);
            return directory.GetFiles().Select(f => f.Name).ToList();
        }
        async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);

                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string path, IFormFileCollection files)
        {
            string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            List<(string fileName, string path)> datas = new();
            foreach (IFormFile file in files)
            {
                FileInfo fileInfo = new FileInfo(file.FileName); 
                // todo burayı bi hs den kontrol et
                string fileName = Path.GetFileNameWithoutExtension(fileInfo.Name) + "-" + Guid.NewGuid() + fileInfo.Extension; 
                await CopyFileAsync($"{uploadPath}\\{fileName}", file);
                datas.Add((fileName, $"{path}\\{fileName}"));
            }
            return datas;
        }
    }
}