using Entity.Concrete;
using Entity.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        public List<Student> GetByLesson(LessonDetail lessonDetail);
        public Student Add(StudentDetail studentDetail);
        public Student Delete(StudentDetail studentDetail);
        public Student Update(StudentDetail studentDetail);
    }
}
