using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace webapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase {
		private readonly IStudentService _studentService;

		public StudentController(IStudentService studentService) {
			_studentService = studentService;
		}

		[HttpGet]
		public ActionResult<List<Student>> GetAllStudents() {
			return Ok(_studentService.GetAllStudents());
		}
			
		[HttpGet("{student_id}")]
		public ActionResult<Student> GetStudent(int student_id) {
			var Student = _studentService.GetStudentById(student_id);

			if (Student != null) {
				return Student;
			} else {
				return NotFound();
			}
		}
	}
}