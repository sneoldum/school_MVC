using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class LessonManager : ILessonService
    {
        private ILessonDal _lessonDal;
        private IStudentService _studentService;
        public LessonManager(ILessonDal lessonDal, IStudentService studentService)
        {
            _lessonDal = lessonDal;
            _studentService = studentService;
        }

        public List<Lesson> GetAll()
        {
            return _lessonDal.GetList();
        }
        public Lesson Add(LessonDetail lessonDetail)
        {
            Lesson lesson = new Lesson
            {

                LessonId = lessonDetail.LessonId,

                LessonName = lessonDetail.LessonName,
            };

            _lessonDal.Add(lesson);

            return lesson;
        }

        public Lesson Update(LessonDetail lessonDetail)
        {
            Lesson lesson = new Lesson
            {

                LessonId = lessonDetail.LessonId,

                LessonName = lessonDetail.LessonName,
            };

            _lessonDal.Update(lesson);

            return lesson;
        }

        public void Delete(int lessonId)
        {
            StudentDetail studentDetail = new StudentDetail();
            Lesson lesson = new Lesson
            {

                LessonId = lessonId,
            };

            Student student = new Student
            {
                Id = studentDetail.Id,
                LessonId = studentDetail.LessonId,
            };
            if (studentDetail.LessonId == lessonId)
            {
                _studentService.Delete(studentDetail);
            }
            _lessonDal.Delete(lesson);
        }
    }
}
