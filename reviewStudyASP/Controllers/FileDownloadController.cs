using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reviewStudyASP.Controllers
{
    public class FileDownloadController : Controller
    {
        // GET: FileDownload
        public FileResult fileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\esteb\Documents\reviewStudyASP\reviewStudyASP\example.pdf");
            string fileName = "ExampleDownloadName.pdf";

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}