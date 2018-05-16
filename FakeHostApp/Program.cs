using System;
using System.Configuration;

namespace FakeHostApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Title = ConfigurationManager.AppSettings["AppTitle"];
			Console.SetWindowSize(30, 2);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
