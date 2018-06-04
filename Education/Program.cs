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
			danTheMan.PrimaryLanguage = "CSharp";
			danTheMan.Email = "dantheman@military.gov";
			danTheMan.Phone = "123-456-7890";

			Class dotNet4 = new Class();
			dotNet4.Capacity = 16;
			dotNet4.Code = "DN4";
			dotNet4.Language = "CSharp";
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

			Assignment asg1 =danTheMan.createAssignment("Fudaments Assignment 2", "Fudamentals 13");
			/*
			Assignment asg1 = new Assignment();
			asg1.AssignmentId = "Fudamentals 12";
			asg1.Comments = null;
			asg1.Grade = null;
			asg1.Name = "First Fudamentals Assignment";
			*/
			dotNet4.DistributeAssigment(asg1);

			//foster.Assignments.Add(asg1);
			//johnyboy.Assignments.Add(asg1);
			try {
				int x = 0;
				int y = 1 / x;
			} catch (DivideByZeroException ex) {
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			} catch (Exception ex) {
				throw ex;
			}
		}
	}
}
