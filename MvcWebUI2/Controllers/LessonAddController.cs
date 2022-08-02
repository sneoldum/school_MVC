using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class LessonAddController : Controller
    {
        private ILessonService _lessonService;

        public LessonAddController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        public IActionResult Index()
        {
            var model = new LessonAddViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(LessonAddViewModel lessonDetail)
        {
            LessonDetail lesson = new LessonDetail
            {
               
                LessonId = lessonDetail.LessonId,
                LessonName = lessonDetail.LessonName,
            };

            _lessonService.Add(lesson);

            return View(lessonDetail);
        }

    }
}

