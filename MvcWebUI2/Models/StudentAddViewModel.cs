using System.ComponentModel;

namespace MvcWebUI2.Models
{
    public class StudentAddViewModel
    {
        [DisplayName("Öğrenci Adı")]
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentClass { get; set; }
        public int LessonId { get; set; }
    }
}
