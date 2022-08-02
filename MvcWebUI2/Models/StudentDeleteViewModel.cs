using System.ComponentModel;

namespace MvcWebUI2.Models
{
    public class StudentDeleteViewModel
    {
        public int Id { get; set; }

        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentClass { get; set; }
        public int LessonId { get; set; }
    }
}
