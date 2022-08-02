using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILessonService
    {
        List<Lesson> GetAll();
        public Lesson Add(LessonDetail lessonDetail);
        public Lesson Update(LessonDetail lessonDetail);
        public void Delete(LessonDetail lessonDetail);
    }
}
