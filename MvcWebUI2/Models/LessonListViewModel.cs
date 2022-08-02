using Entity.Concrete;
using System.Collections.Generic;

namespace MvcWebUI2.Models
{
    public class LessonListViewModel
    {
        public LessonListViewModel()
        {
            Lessons = new List<Lesson>();
        }

        public List<Lesson> Lessons { get; set; }
        public int CurrentLesson { get; set; }
    }
}

