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

    [HttpGet]
    public IActionResult Download()
    {
        try
        {
            string filePath = Path.Combine(_env.WebRootPath ?? "~\\wwwroot\\", "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
            string fileType = "application/pdf";
            return PhysicalFile(filePath, fileType);
        }
        catch (Exception ex)
        {
            return Ok(ex.Message + " Stack trace::: " + ex.StackTrace);
        }
    }
}
