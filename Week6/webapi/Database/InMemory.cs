using System.Collections.Generic;
using webapi.Models;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "100",
                EmailAddress = "tom.smith@school.com"
            },
            new Student {
                Id = 2,
                StudentId = "200",
                EmailAddress = "mary.jones@school.com"
            }
        };

		public static List<Instructor> Instructors = new List<Instructor> {
			new Instructor {
				Id = 1,
				FirstName = "Patrick",
				LastName = "Basedman"
			},

			new Instructor {
				Id = 2,
				FirstName = "Jack",
				LastName = "Torrents"
			}
		};
    }
}