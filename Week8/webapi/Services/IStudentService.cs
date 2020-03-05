using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.ViewModel;

namespace webapi.Services
{
	public interface IStudentService
	{
		List<StudentViewModel> GetAllStudents();
		Student GetStudentById(int student_id);
	}
}
