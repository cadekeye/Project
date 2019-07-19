using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Entities;

namespace MyAppFromScratch.Repository
{
    public interface IStudentRepository : IRepository<Student> {
        IEnumerable<Student> GetTotalStudent();
        Student GetById(int id);

    }
}
