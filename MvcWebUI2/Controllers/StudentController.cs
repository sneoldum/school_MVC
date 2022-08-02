using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index(LessonDetail lesson)
        {
            var model = new StudentListViewModel
            {
                Students = lesson.LessonId>0?_studentService.GetByLesson(lesson):  _studentService.GetAll()
            };
            return View(model);
        }
    }
}
