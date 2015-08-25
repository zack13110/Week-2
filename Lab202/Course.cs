using System;

namespace Lab2
{
	public class Course
	{
		string courseid;
		int maxStudents;
		int numStudents;

		public string Name {
			get;
			set;
		}
		public string CourseID {
			get { return courseid; }
			set { 
				int n;
				if (value.Length==6 && int.TryParse (value, out n))
					courseid = value;
				else {
					Console.WriteLine (CourseID + ": error try setting invalid CourseID!");
				}
			}
		}
		public string Lecturer {
			get;
			set;
		}
		public int MaxStudents {
			get { return maxStudents; }
			set { 
				if (value>0 && value<=80 && value>=numStudents) {
					maxStudents = value;
				} else {
					Console.WriteLine (CourseID + ": error try setting invalid Max No. Students!");
				}
			}
		}
		public int NumStudents {
			get { return numStudents; }
			set { 
				if (value>=0 && value<=maxStudents) {
					numStudents = value;
				} else {
					Console.WriteLine (CourseID + ": error try setting invalid No. Students!");
				}
			}
		}

		private void initData() {
			Name = "";
			CourseID = "000000";
			Lecturer = "staff";
			MaxStudents = 30;
			NumStudents = 0;
		}

		public Course ()
		{
			initData ();
		}

		public Course(string n, string id){
			initData ();
			Name = n;
			CourseID = id;
		}

		public Course(string n, string id, string t){
			initData ();
			Name = n;
			CourseID = id;
			Lecturer = t;
		}

		public Course(string n, string id, string t,int m){
			initData ();
			Name = n;
			CourseID = id;
			Lecturer = t;
			MaxStudents = m;
		}

		public override string ToString ()
		{
			return string.Format ("[Course: {0} ({1}), Lecturer={2}, has {4} students, max={3}]", Name, CourseID, Lecturer, MaxStudents, NumStudents);
		}
	}
}

