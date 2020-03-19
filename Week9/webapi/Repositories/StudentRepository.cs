using Database;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly SchoolContext _dbContext;
		private readonly ILogger _logger;

		public StudentRepository(SchoolContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<Student> GetAllStudents()
		{
			try
			{
				return _dbContext.Student.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError("Failed to getstudents.", ex);

				return new List<Student>();
			}
		}

		public Student GetStudentById(long student_id)
		{
			return _dbContext.Student.SingleOrDefault(p => p.student_id == student_id);
		}
	}
}
