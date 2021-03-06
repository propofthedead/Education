﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Class
	{
		public string Name { get; set; }
		private string _Language;
		/// <summary>
		/// Language accepts only CSharp or Java
		/// </summary>
		public string Language {
			get { return _Language; }
			set {
				if (value == "CSharp" || value == "Java") { _Language = value; }
			}
		}
		public string Code { get; set; }
		public int Capacity { get; set; }
		public Instructor Instructor { get; set; }
		public List<Student> Students= new List<Student>();

		public void DistributeAssigment(Assignment angs)
		{
			foreach (Student student in Students) {
				Assignment an = new Assignment();
				an.Name = angs.Name;
				an.AssignmentId = angs.AssignmentId;
				an.Comments = angs.Comments;
				an.Grade = angs.Grade;
				student.Assignments.Add(an);
			}
		}

	}
}
