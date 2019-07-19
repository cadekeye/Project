using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using MyAppFromScratch.Entities;
using MyAppFromScratch.UnitOfWork;

namespace MyAppAPI.Controllers
{
    public class StudentController : ApiController {
        private readonly IUnitOfWork unitOfWork;
        private HttpSessionState session = HttpContext.Current.Session;

        public StudentController(IUnitOfWork unitOfWork) {
            this.unitOfWork = unitOfWork;
        }

        public StudentController() {
            unitOfWork = new UnitOfWork();
        }

        [HttpGet]
        [Route("api/GetAllStudent")]
        public IHttpActionResult GetAllStudent() {
            List<Student> initialStudents = new List<Student> {
                new Student { Age = 20, FirstName = "John", LastName = "Paul", StudentId = 1 },
                new Student { Age = 22, FirstName = "Luke", LastName = "Stones", StudentId = 2 },
                new Student { Age = 40, FirstName = "Quadri", LastName = "Davis", StudentId = 3 },
                new Student { Age = 28, FirstName = "Rufus", LastName = "Adekola", StudentId = 4 }
            };

            var students = this.unitOfWork.StudentRepositories.Get();

            session[nameof(Student)] = initialStudents;
           return Ok(initialStudents.Union(students));
        }

        [HttpGet]
        [Route("api/GetStudent")]
        public IHttpActionResult GetStudent(int id)
        {
            var student = this.unitOfWork.StudentRepositories.GetById(id);

            return Ok(student);
        }

        [HttpPost]
        [Route("api/Post")]
        public HttpResponseMessage Post(Student student) {
            this.unitOfWork.StudentRepositories.Add(student);

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpDelete]
        [Route("api/Delete")]
        public HttpResponseMessage Delete(Student student)
        {
            this.unitOfWork.StudentRepositories.Remove(student);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
