using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Entities;

namespace MyAppFromScratch.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public IEnumerable<Student> GetTotalStudent() {
            throw new NotImplementedException();
        }

        public Student GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
