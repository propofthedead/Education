using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Program
	{
		static void Main(string[] args)
		{
			Instructor danTheMan = new Instructor();
			danTheMan.name = "Dan";
			danTheMan.ExperienceInYears = 17;
			danTheMan.PrimaryLanguage = "Csharp";
			danTheMan.Email = "dantheman@military.gov";
			danTheMan.Phone = "123-456-7890";

			Class dotNet4 = new Class();
			dotNet4.Capacity = 16;
			dotNet4.Code = "DN4";
			dotNet4.Language = "Csharp";
			dotNet4.Name = "dotNet Boot Camp 4";
			dotNet4.Instructor = danTheMan;

		}
	}
}
