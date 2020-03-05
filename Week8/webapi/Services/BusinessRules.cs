using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Services
{
	public class BusinessRules
	{
		public static bool isBased(Student toCheck)
		{
			if (toCheck.email_address.Contains("based"))
			{
				return true;
			}return false;
		}
	}
}
