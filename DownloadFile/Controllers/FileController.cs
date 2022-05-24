using Microsoft.AspNetCore.Mvc;

namespace DownloadFile.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileController : ControllerBase
{
    private readonly IWebHostEnvironment _env;

    public FileController(
        IWebHostEnvironment env)
    {
        _env = env;
    }

    //[HttpGet]
    //public IActionResult Download()
    //{
    //    string filePath = Path.Combine(_env.WebRootPath, "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
    //    string fileType = "application/pdf";
    //    return PhysicalFile(filePath, fileType);
    //}

    [HttpGet]
    public VirtualFileResult GetVirtualFile()
    {
        var filepath = Path.Combine("~/Files", "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
        return File(filepath, "text/plain", "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
    }
}
