using CupCakesHub.Interfaces.Loaders;
using Pastel;
using static System.Console;
namespace CupCakesHub.Main
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
						//LoadPrograms.Loadprograms();
						break;
					case "S":
						LoadSources.Loadsource();
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

			//WaitForAnyKeyPress();
		}
	}
}
