using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Entities;

namespace MyAppFromScratch.Repository
{
   public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public IEnumerable<Course> GetTotalCourseCount() {
            throw new NotImplementedException();
        }

        public Course GetById(int id) {
            throw new NotImplementedException();
        }
    }
}
