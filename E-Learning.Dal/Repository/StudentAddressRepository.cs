using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Dal.Repository
{
    public class StudentAddressRepository
    {
        private readonly ApplicationDBContext _context;

        public StudentAddressRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        
    }
}
