using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;
using Pastel;
using CupCakeslauncher.Main;

namespace CupCakeslauncher.Interfaces.NewFolder
{
	public class ProgramLoader
	{

		public static void Loadprograms()
		{

			string? GameTitle = "								=== Program Menu ===";

			Clear();
			WriteLine("Loading Program's Plz wait....");
			Thread.Sleep(500);
			Clear();
			WriteLine(GameTitle);
			WriteLine();
			WriteLine();

			WriteLine("						==============================================".Pastel("#125874"));
			WriteLine("							  |(1)Name Of Program||                                          ");
			WriteLine("							  |(2)Name Of Program||												");

			WriteLine("							  |(3)Name Of Program|                                          ");
			WriteLine("							  |(4)Name Of Program|												");

			WriteLine("							  |(5)Name Of Program|                                          ");
			WriteLine("							  |(6)Name Of Program|												");

			WriteLine("							  |(E)xit|												");
			WriteLine("						==============================================".Pastel("#125874"));

			switch (ReadLine().ToUpper())
			{
				case "1":
					Clear();
					WriteLine("Loading Program's Plz wait....");
					Thread.Sleep(1500);
					Clear();

					ProcessStartInfo startInfo1 = new ProcessStartInfo();
					startInfo1.FileName = @"Add The Directory path here"; // Here is where you add the game you want to load up....
					Process.Start(startInfo1);
					Loadprograms();
					break;
				case "2":
					ProcessStartInfo startInfo2 = new ProcessStartInfo();
					startInfo2.FileName = @"Add The Directory path here"; // Here is where you add the game you want to load up....
					Process.Start(startInfo2);
					Loadprograms();
					break;

				case "3":
					ProcessStartInfo startInfo3 = new ProcessStartInfo();
					startInfo3.FileName = @"Add The Directory path here"; // Here is where you add the game you want to load up....
					Process.Start(startInfo3);
					Loadprograms();
					break;


				case "4":
					ProcessStartInfo startInfo4 = new ProcessStartInfo();
					startInfo4.FileName = @"Add The Directory path here"; // Here is where you add the game you want to load up....
					Process.Start(startInfo4);
					Loadprograms();
					break;

				case "5":
					ProcessStartInfo startInfo5 = new ProcessStartInfo();
					startInfo5.FileName = @"Add The Directory path here"; // Here is where you add the game you want to load up....
					Process.Start(startInfo5);
					Loadprograms();
					break;

				case "E":
					Clear();
					Thread.Sleep(200);
					Clear();
					MainMenu.Mainmenu();
					break;

				default:
					Clear();
					WriteLine("Plz Enter The Right Letter ");
					Loadprograms();
					break;
			}
		}
	}
}
