using System;

namespace Lab201
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Student class */
			Student[] stds = new Student[7];
			stds[0] = new Student ();
			stds[1] = new Student ("s1","57001");
			stds[2] = new Student ("s2","57002",1994);
			stds[3] = new Student ("s3","57003",1996);
			stds[4] = new Student ("s4","57004");
			stds[5] = new Student ("s5","57005",1993);
			stds[6] = new Student ("s6","57006");

			Console.WriteLine ("\n--- Initial Students' state ---");
			foreach (Student s in stds)
				Console.WriteLine (s);

			Console.WriteLine ("\n--- Playing with s4, s5, s6 objects ---");
			stds [4].Name = "Mario";
			stds [5].YearOfBirth = 1900;
			stds [6].isActive = false;
			for (int i = 4; i < stds.Length; i++)
				Console.WriteLine (stds [i]);

		}
	}
}
