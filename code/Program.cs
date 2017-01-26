using System;
using System.IO;

namespace UniversalOcarina
{
	class MainClass
	{
		public static byte[] ROM;
		public static string path;
		public static string name;

		public static void Main (string[] args)
		{
			if (args.Length > 0) {
				path = args [0];
				if (File.Exists (path)) {
					ROM = File.ReadAllBytes(path);
					name = Path.GetFileNameWithoutExtension (path);
				}
			} else {
				Console.WriteLine ("Invalid file, or none entered");
				Console.Read ();
				Environment.Exit (0);
			}


			//if file reads correctly
			Console.WriteLine ("file recieved.");
			Console.WriteLine ("path: "+ path);
			Console.WriteLine ("file name: " + name);
			Console.Read ();
		}
	}
}
