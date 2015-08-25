using System;

namespace Lab2
{
	public class Student
	{
		int yob;

		public string Name {
			get;
			set;
		}

		public String StudentID {
			get;
			set;
		}

		public int YearOfBirth {
			get { return yob; }
			set {
				if (value < 1950 || value>2000) {
					Console.WriteLine (StudentID + ": error try setting invalid year-of-birth value!");
				} else {
					yob = value;
				}
			}
		}

		public bool isActive {
			get;
			set;
		}

		private void initData() {
			Name = "John Doe";
			StudentID = "Unknown";
			YearOfBirth = 1995;
			isActive = true;	           
		}

		public Student ()
		{
			initData ();
			isActive = false;
		}

		public Student (string n,string id)
		{
			initData ();
			Name = n;
			StudentID = id;
		}

		public Student (string n,string id,int y)
		{
			initData ();
			Name = n;
			StudentID = id;
			YearOfBirth = y;
		}

		public Student (string n,string id,int y,bool active)
		{
			initData ();
			Name = n;
			StudentID = id;
			YearOfBirth = y;
			isActive = active;
		}

		public int getAge() { 
			DateTime today = DateTime.Today;
			int year = today.Year;
			return year-YearOfBirth;
		}

		public override string ToString ()
		{
			String s = string.Format ("[Student: {0} ({1}), age={2}, ", Name, StudentID, getAge());
			s += isActive ? "is active student]" : "is NOT active student]";
			return s;
		}
	}
}

