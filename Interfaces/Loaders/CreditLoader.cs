using CupCakeslauncher.Main;
using System.Diagnostics;
using Newtonsoft.Json;
using Pastel;
using static System.Console;
using CupCakes_launcher.Utilities.GameUtilities;

namespace CupCakes_launcher.Interfaces.Loaders
{
    class CreditLoader
    {

        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }







        public static void loadCredits()
        {
            //string? Tab = "\t";

            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Credits";
            var Loadcredit = new CreditData();
            if (File.Exists($"{basePath}\\Credits.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var LoadcreditJsonFile = directory.GetFiles("Credits.json");

                using StreamReader fi = File.OpenText(LoadcreditJsonFile[0].FullName);
                Loadcredit = JsonConvert.DeserializeObject<CreditData>(fi.ReadToEnd());
            }
            string? Title = "Title:".Pastel("#29188D");
            string? Link = "Link:".Pastel("#8D0E2E");







            string? SourceTitle = "								=== Source's ===";

            Clear();
            WriteLine("Loading Source's Plz wait....");
            Thread.Sleep(500);
            Clear();
            WriteLine(SourceTitle);


            WriteLine();
            WriteLine();

            WriteLine("						==============================================".Pastel("#125874"));
            WriteLine("						      |(G)it Hub|            |(Y)ouTube|	                         \n\n    ");


            WriteLine("						      |(D)iscord|            |ComingSoon|	                          \n\n   ");


            WriteLine("							             (E)xit                                       ");
            WriteLine("						==============================================".Pastel("#125874"));






            switch (ReadLine().ToUpper())
            {
                //GitHUb
                case "G":

                    string? request = Loadcredit.LinkG;
                    ProcessStartInfo ps = new ProcessStartInfo
                    {
                        FileName = request,
                        UseShellExecute = true
                    };
                    Process.Start(ps);
                    WriteLine("Loading Program's Plz wait....");
                    Thread.Sleep(1500);
                    Clear();
                    loadCredits();
                    break;

                //Youtube
                case "Y":
                    string? requestY = Loadcredit.LinkY;
                    ProcessStartInfo psY = new ProcessStartInfo
                    {
                        FileName = requestY,
                        UseShellExecute = true
                    };
                    Process.Start(psY);
                    WriteLine("Loading Program's Plz wait....");
                    Thread.Sleep(1500);
                    Clear();
                    loadCredits();
                    break;

                //Discord
                case "D":
                    string? requestD = Loadcredit.LinkD;
                    ProcessStartInfo psD = new ProcessStartInfo
                    {
                        FileName = requestD,
                        UseShellExecute = true
                    };
                    Process.Start(psD);
                    Thread.Sleep(1500);
                    WriteLine("Loading Program's Plz wait....");
                    Clear();
                    loadCredits();
                    break;
                //Exit
                case "E":
                    Clear();
                    WriteLine("Returning to the main menu");
                    Thread.Sleep(2000);
                    Clear();
                    MainMenu.Mainmenu();
                    break;
                default:
                    Clear();
                    WriteLine("Plz Enter The Right Letter ");
                    loadCredits();
                    break;
            }
        }
    }
}
