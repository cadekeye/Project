using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Entities;

namespace MyAppFromScratch.Repository
{
    public interface ICourseRepository : IRepository<Course> {
        IEnumerable<Course> GetTotalCourseCount();
        Course GetById(int id);

    }
}
