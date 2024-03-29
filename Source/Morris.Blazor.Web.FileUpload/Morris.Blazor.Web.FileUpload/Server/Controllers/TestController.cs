﻿using Microsoft.AspNetCore.Mvc;

namespace Morris.Blazor.Web.FileUpload.Server.Controllers;

public class TestController : ControllerBase
{
    [HttpPost]
    [Route("/api/test/upload")]
    [RequestFormLimits(MultipartBodyLengthLimit = long.MaxValue)]
    [RequestSizeLimit(bytes: long.MaxValue)]
    public IActionResult Upload()
    {
        Console.WriteLine(Request.Form.Files.Count);
        foreach (IFormFile file in Request.Form.Files)
        {
            Console.WriteLine($"{file.FileName} {file.Length}");
        }
        return Ok();
    }
}
