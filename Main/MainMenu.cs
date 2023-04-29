using CupCakes_launcher.Interfaces.Loaders;
using CupCakeslauncher.Interfaces.NewFolder;
using Pastel;
using static System.Console;
namespace CupCakeslauncher.Main
{
    internal class MainMenu
	{

		public static void Mainmenu()
		{

			Menu();

			static void Menu()
			{
				WriteLine("						==============================================".Pastel("#125874"));

				WriteLine("							  |(G)ame Menu|            |(P)rogram's|	                             ");
				WriteLine("							               |(S)ources|												");

				WriteLine("							               |(E)xit|												");
				WriteLine("						==============================================".Pastel("#125874"));

				switch (ReadLine().ToUpper())
				{

					case "G":
						//LoadGames.LoadGameMenu();
						break;
					case "P":
						ProgramLoader.Loadprograms();
						break;
					case "S":
						Clear();
						CreditLoader.loadCredits();
						//LoadSources.Loadsource();
						break;
					case "E":
						Environment.Exit(0);
						break;
					default:
						Clear();
						WriteLine("Plz Enter The Right Letter ");
						Mainmenu();
						break;
				}
			}
		}
	}
}
