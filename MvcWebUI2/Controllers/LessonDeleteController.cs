using Business.Abstract;
using Business.Concrete;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;
using System.Collections.Generic;

namespace MvcWebUI2.Controllers
{
    public class LessonDeleteController : Controller
    {
        private ILessonService _lessonService;
        private IStudentService _studentService;
        public LessonDeleteController(ILessonService lessonService, IStudentService studentService)
        {
            _lessonService = lessonService;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var model = new LessonDeleteViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(LessonDeleteViewModel lessonDetail)
        {
            StudentManager studentManager = new StudentManager(lesson);
            StudentListViewModel studentList = new StudentListViewModel();
            StudentDeleteViewModel studentDetail = new StudentDeleteViewModel();
            LessonDetail lesson = new LessonDetail
            {
                LessonId = lessonDetail.LessonId,
            };
            StudentDetail student = new StudentDetail
            {
                Id = studentDetail.Id,
                LessonId = lesson.LessonId
            };
            List<Student> list = studentManager.GetByLesson(lesson);
            //var list = studentList.Students;
            if ( list.Count > 0)
            {
                foreach (var students in list)

                    students.Id = student.Id;
                    _studentService.Delete(student);

                return View(lessonDetail);
            }
            else
            {


                _lessonService.Delete(lesson);

                return View(lessonDetail);
            }

        }
    }
}

