using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Model
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public Student Student { get; set; }
    }
}
