using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;
using Database;

namespace webapi.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase {
		private readonly SchoolContext _dbContext;

		public StudentController(SchoolContext dbContext) {
			_dbContext = dbContext;
		}

		[HttpGet]
		public ActionResult<List<Student>> GetAllStudents() {
			var result = _dbContext.Student.ToList();
			return Ok(result);
		}
			
		[HttpGet("{student_id}")]
		public ActionResult<Student> GetStudent(int student_id) {
			var Student = _dbContext.Student
				.SingleOrDefault(p => p.student_id == student_id);

			if (Student != null) {
				return Student;
			} else {
				return NotFound();
			}
		}
	}
}