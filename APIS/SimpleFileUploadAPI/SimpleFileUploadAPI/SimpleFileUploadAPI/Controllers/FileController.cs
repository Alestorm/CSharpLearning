using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace SimpleFileUploadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public FileController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("uploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded");
            }
            var extension = Path.GetExtension(file.FileName);
            var newFileName = $"{Guid.NewGuid()}{extension}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", newFileName);

            var stream = new FileStream(filePath, FileMode.Create);

            try
            {
                await file.CopyToAsync(stream);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                stream.Dispose();
            }
            return Ok(file.FileName);
        }
        [HttpGet("downloadFile/{filename}")]
        public async Task<IActionResult> DownloadFile([FromRoute] string filename)
        {
            var folderName = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            var fullPath = Path.Combine(folderName, filename);

            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound("File not found");
            }

            var fileBytes = await System.IO.File.ReadAllBytesAsync(fullPath);
            var fileContentResult = new FileContentResult(fileBytes, "application/octet-stream")
            {
                FileDownloadName = filename
            };

            return fileContentResult;
        }

    }
}
