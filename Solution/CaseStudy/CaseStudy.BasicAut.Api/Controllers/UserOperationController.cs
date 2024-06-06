using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using System.Text;

namespace CaseStudy.BasicAut.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return Task.FromResult<IActionResult>(Ok("UserOperationGet"));
        }

        [HttpGet("GetLogin")]
        public async Task<IActionResult> GetLogin()
        {
            using var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7001/api/UserProfil/profile");

            string credentials = "Case:2024";
            string credentialBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {credentialBase64}");

            var result = await httpClient.GetAsync("");


            var response = httpClient.GetAsync("").Result;

            if (result.IsSuccessStatusCode)
            {
                return await Task.FromResult<IActionResult>(Ok("Başarılı..."));
            }
            else
            {
                return await Task.FromResult<IActionResult>(Ok($"Başarısız! > Hata Kodu: {result.StatusCode}")); 
            }

           
        }

    }
}
