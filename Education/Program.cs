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


			Student foster = new Student();
			foster.absences = 0;
			foster.ContactInfo = "Call Foster ....";
			foster.FirstJob = null;
			foster.Name = "Foster Stulen";
			foster.course = dotNet4;

			Student johnyboy = new Student();
			johnyboy.absences = 0;
			johnyboy.ContactInfo = "Call Jonathan";
			johnyboy.FirstJob = null;
			johnyboy.Name = "Jonathan";
			johnyboy.course = dotNet4;

			dotNet4.Students.Add( foster);
			dotNet4.Students.Add(johnyboy);
		}
	}
}
