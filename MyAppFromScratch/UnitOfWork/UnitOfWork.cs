using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Repository;

namespace MyAppFromScratch.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork() {
            this.StudentRepositories = new StudentRepository();
            this.CourseRepositories = new CourseRepository();
        }
        public ICourseRepository CourseRepositories { get; set; }
        public IStudentRepository StudentRepositories { get; set; }
    }
}
