using System.Collections.Generic;
using webapi.Models;

namespace Database
{
    public static class InMemory
    {
        

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