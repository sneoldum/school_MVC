using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class LessonUpdateController : Controller
    {
        private ILessonService _lessonService;



        public LessonUpdateController(ILessonService lessonService)
        {
            _lessonService = lessonService;
       
        }

        public IActionResult Index()
        {
            var model = new LessonUpdateViewModel();
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(LessonUpdateViewModel lessonDetail)
        {

            LessonDetail lesson = new LessonDetail
            {

                LessonId = lessonDetail.LessonId,
                LessonName = lessonDetail.LessonName,
            };

            _lessonService.Update(lesson);

            return View(lessonDetail);
        }

    }
}

