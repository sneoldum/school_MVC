using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Dtos
{
    public class StudentDetail:IDto
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentClass { get; set; }   
        public int LessonId { get; set; }
    }
}
