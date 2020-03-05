using FakeItEasy;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using webapi.Services;

namespace webapi.tests
{
	class StudentServiceTests {
		private StudentService _studentService;
		private IStudentRepository _studentRepository;

		[SetUp]
		public void Setup()
		{
			_studentRepository = A.Fake<IStudentRepository>();
			_studentService = new StudentService(_studentRepository);
		}

		[Test]
		public void getSpecialStudentCheck(){
			var expectedEmailAddress = "patrick.basedman@gmail.com";
			A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
			new List<Student> {
				new Student {
					email_address = expectedEmailAddress,
					student_id = 1
				},
				new Student {
					email_address = "jenny.wong@gmail.com",
					student_id = 2
				}
			}
		);
			var studentViewModels = _studentService.GetAllStudents();

			studentViewModels.Count(pdto => pdto.special).Should().Be(1);
			studentViewModels.Single(pdto => pdto.special).email_address.Should().Be(expectedEmailAddress);
		}

		[Test]
		public void getNoSpecialStudentCheck()
		{
			var expectedEmailAddress = "patrick.cringeman@gmail.com";
			A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
			new List<Student> {
				new Student {
					email_address = expectedEmailAddress,
					student_id = 1
				},
				new Student {
					email_address = "jenny.wong@gmail.com",
					student_id = 2
				}
			}
		);
			var studentViewModels = _studentService.GetAllStudents();

			studentViewModels.Count(pdto => pdto.special).Should().Be(0);
		}
	}
}
