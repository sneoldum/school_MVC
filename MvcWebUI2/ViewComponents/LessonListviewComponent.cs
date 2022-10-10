using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI2.Models;
using System;

namespace MvcWebUI2.ViewComponents
{
    public class LessonListviewComponent : ViewComponent
    {
        private ILessonService _lessonService;
        public LessonListviewComponent(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new LessonListViewModel
            {
                Lessons = _lessonService.GetAll(),
                CurrentLesson = Convert.ToInt32(HttpContext.Request.Query["lesson"])
            };
            return View(model);
        }
    }
}
