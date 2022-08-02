using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class LessonDetail:IDto
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
    }
}
