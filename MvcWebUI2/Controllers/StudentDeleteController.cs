using Business.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;

namespace MvcWebUI2.Controllers
{
    public class StudentDeleteController : Controller
    {
        private IStudentService _studentService;
        public StudentDeleteController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var model = new StudentDeleteViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(StudentDeleteViewModel studentDetail)
        {
            StudentDetail student = new StudentDetail
            {
                Id = studentDetail.Id,                
            };
            _studentService.Delete(student);
            return View(studentDetail);
        }
    }
}
