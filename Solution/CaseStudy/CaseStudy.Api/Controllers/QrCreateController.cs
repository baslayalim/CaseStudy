using CaseStudy.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Text.Json;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCreateController : ControllerBase
    {
        [HttpGet]
        public byte[] GenerateQRCode(string text)
        {
            // <img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAwIAAAMCAQMAAADgcuP7AAAAB==" />
            var plainObject = new Product
            {
             Name = text,
             Product_Description = "Civcivli Suluk",
            };
            string plainText = JsonSerializer.Serialize(plainObject);

            QRCodeGenerator generator = new();
            QRCodeData data = generator.CreateQrCode(plainText, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new(data);
            byte[] byteGraphic = qrCode.GetGraphic(10, new byte[] { 84, 99, 71 }, new byte[] { 240, 240, 240 });
            return byteGraphic;
        }
    }
}
