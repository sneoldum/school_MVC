using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcWebUI2.Controllers
{
    public class LessonDeleteController : Controller
    {
        private ILessonService _lessonService;
        private IStudentService _studentService;
        private IStudentDal _studentDal;
        public LessonDeleteController(ILessonService lessonService, IStudentDal studentDal, IStudentService studentService)
        {
            _lessonService = lessonService;
            _studentDal = studentDal;
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
            var getStudents = _studentDal.GetList();
            if (getStudents.Count > 0)
            {
                var getStudentsByLessonId = getStudents.Where(x => x.LessonId == lessonDetail.LessonId);
            }
            StudentManager studentManager = new(_studentDal);
            StudentDetail studentDetail = new();
            List<Student> list = studentManager.GetByLesson(lessonDetail.LessonId);
            if (list.Count > 0)
            {
                foreach (var students in list)
                {
                    studentDetail.Id = students.Id;
                    _studentService.Delete(studentDetail);
                }
                _lessonService.Delete(lessonDetail.LessonId);
                return View(lessonDetail);
            }
            else
            {
                _lessonService.Delete(lessonDetail.LessonId);

                return View(lessonDetail);
            }
        }
    }
}

