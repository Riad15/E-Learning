using E_Learning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Dal.Repository
{
    public class StudentRepository
    {
        private readonly ApplicationDBContext _context;

        public StudentRepository (ApplicationDBContext context)
        {
            _context = context;
        }

       public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}
