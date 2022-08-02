using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            this._studentDal = studentDal;
        }

        public Student Add(StudentDetail studentDetail)
        {
            Student student = new Student
            {
                
                LessonId = studentDetail.LessonId,
                StudentClass = studentDetail.StudentClass,
                StudentName = studentDetail.StudentName,
                StudentSurname = studentDetail.StudentSurname
            };

            _studentDal.Add(student);

            return student;
        }

        public Student Delete(StudentDetail studentDetail)
        {
            Student student = new Student
            {
                Id = studentDetail.Id,
            };

            _studentDal.Delete(student);

            return student;
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetList();
        }



        public List<Student> GetByLesson(LessonDetail lessonDetail)
        {

            return _studentDal.GetList(p => p.LessonId == lessonDetail.LessonId);
        }

        public Student Update(StudentDetail studentDetail)
        {
            Student student = new Student
            {
               
                LessonId = studentDetail.LessonId,
                StudentClass = studentDetail.StudentClass,
                StudentName = studentDetail.StudentName,
                StudentSurname = studentDetail.StudentSurname
            };

            _studentDal.Update(student);

            return student;
        }
    }
}
