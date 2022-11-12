using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class StudentUpdateController : Controller
    {
        private IStudentService _studentService;
        public StudentUpdateController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var model = new StudentUpdateViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(StudentUpdateViewModel studentDetail)
        {
            StudentDetail student = new StudentDetail
            {
                Id = studentDetail.Id,
                LessonId = studentDetail.LessonId,
                StudentClass = studentDetail.StudentClass,
                StudentName = studentDetail.StudentName,
                StudentSurname = studentDetail.StudentSurname
            };
            _studentService.Update(student);
            return View(studentDetail);
        }

    }
}
