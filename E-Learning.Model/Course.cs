using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
