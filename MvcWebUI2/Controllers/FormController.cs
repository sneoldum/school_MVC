using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MvcWebUI2.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Student()
        {
            return View();
        }
        public IActionResult Lesson()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
    }
}
