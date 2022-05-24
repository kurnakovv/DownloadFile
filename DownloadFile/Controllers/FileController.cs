using Microsoft.AspNetCore.Mvc;

namespace DownloadFile.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FileController : ControllerBase
{
    [HttpGet]
    public VirtualFileResult Download()
    {
        var filepath = Path.Combine("~/Files", "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
        return File(filepath, "text/plain", "MaksimKurnakovBackendDotNetWebDeveloper.pdf");
    }
}
