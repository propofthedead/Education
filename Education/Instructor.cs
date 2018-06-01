using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
	class Instructor
	{
		public string name { get; set; }
		public int ExperienceInYears { get; set; }
		public string PrimaryLanguage { get; set; } // Csharp or java
		public string Email { get; set; }
		public string Phone { get; set; }

		public Assignment createAssignment(string name, string id)
		{
			Assignment asgn = new Assignment();
			asgn.Comments = null;
			asgn.Grade = null;
			asgn.Name = name;
			asgn.AssignmentId = id;
			return asgn;
		}

	}
}
