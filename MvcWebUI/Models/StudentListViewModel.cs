using Entity.Concrete;
using System.Collections.Generic;

namespace MvcWebUI.Models
{
    public class StudentListViewModel
    {
        public StudentListViewModel()
        {
            Students = new List<Student>();
        }

        public List<Student> Students { get; set; }
    }
}
