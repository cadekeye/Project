using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppFromScratch.Repository;

namespace MyAppFromScratch.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICourseRepository CourseRepositories { get; set; }
        IStudentRepository StudentRepositories { get; set; }
    }
}
