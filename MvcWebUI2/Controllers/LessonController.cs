using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class LessonController : Controller
    {
        private ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        

        public IActionResult Index()
        {
            var model = new LessonListViewModel
            {
                Lessons = _lessonService.GetAll()
            };
            return View(model);
        }
    }
}
