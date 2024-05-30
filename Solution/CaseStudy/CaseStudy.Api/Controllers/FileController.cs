using CaseStudy.Api.CustomFolder;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        readonly ICaseStudyStorage _storage;
        public FileController(ICaseStudyStorage caseStudyStorage)
        {
            _storage = caseStudyStorage;
        }

        [HttpGet("FileDelete")]
        public string FileDelete(string patch , string file)
        {
            _storage.DeleteAsync(patch, file);
            return ""; 
        }

        [HttpGet("FileGetFiles")]
        public List<string> FileGetFiles(string patch)
        {
            List<string> deger = _storage.GetFiles(patch);
            return deger;
        }

        [HttpGet("FileHasFile")]
        public bool FileHasFile(string patch, string file)
        {
            bool hash = _storage.HasFile(patch, file);
            return hash;
        }



        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
            var x = await _storage.UploadAsync("Storage\\Product\\" + DateTime.UtcNow.Year + "\\" + DateTime.Now.Month + "\\" + DateTime.Now.Day, Request.Form.Files);
            foreach (var item in x)
            {
                string x1 = item.fileName;
                string x2 = item.pathOrContainerName;
            }
            return Ok();
        }

    }
}
