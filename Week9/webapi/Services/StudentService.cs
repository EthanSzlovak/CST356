using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using webapi.Services;
using webapi.ViewModel;

public class StudentService : IStudentService
{
	private readonly IStudentRepository _StudentRespository;
	private readonly ILogger _logger;

	public StudentService(IStudentRepository StudentRepository)
	{
		_StudentRespository = StudentRepository;
	}

	public List<StudentViewModel> GetAllStudents()
	{
		var StudentViewModels = new List<StudentViewModel>();

		foreach (var Student in _StudentRespository.GetAllStudents())
		{
			StudentViewModels.Add(new StudentViewModel
			{
				student_id = Student.student_id,
				email_address = Student.email_address,
				special = BusinessRules.isBased(Student)
				
			});
		}

		return StudentViewModels;
	}
	public Student GetStudentById(int student_id)
	{
		return _StudentRespository.GetStudentById(student_id);
	}
}
