using E_Learning.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Bll.Services
{
    public class StudentAddressService
    {
        private readonly StudentAddressRepository _studentAddressRepository;

        public StudentAddressService(StudentAddressRepository studentAddressRepository)
        {
            _studentAddressRepository = studentAddressRepository;
        }
    }
}
