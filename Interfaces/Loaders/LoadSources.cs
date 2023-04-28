using Pastel;
using System.Diagnostics;
using static System.Console;

namespace CupCakeslauncher.Interfaces.Loaders
{
	internal class LoadSources
    {

        public static void Loadsource()
        {

            string? SourceTitle = "								=== Source's ===";

            Clear();
            WriteLine("Loading Source's Plz wait....");
            Thread.Sleep(500);
            Clear();
            WriteLine(SourceTitle);


            WriteLine();
            WriteLine();

            WriteLine("						==============================================".Pastel("#125874"));
            WriteLine("							  |(G)it Hub|            |(Y)ouTube|	                         \n\n    ");


            WriteLine("							  |(D)iscord|            |ComingSoon|	                          \n\n   ");

            WriteLine("								       |(E)xit|												");
            WriteLine("						==============================================".Pastel("#125874"));




            //string request = "https://www.google.com";
            //ProcessStartInfo ps = new ProcessStartInfo
            //{
            //	FileName = request,
            //	UseShellExecute = true
            //};
            //Process.Start(ps);





            switch (ReadLine().ToUpper())
            {
                //GitHUb
                case "G":
                    string request = "https://github.com/kgbcupcake?tab=repositories";
                    ProcessStartInfo ps = new ProcessStartInfo
                    {
                        FileName = request,
                        UseShellExecute = true
                    };
                    Process.Start(ps);
                    WriteLine("Loading Program's Plz wait....");
                    Thread.Sleep(1500);
                    Clear();
                    break;
                //Youtube
                case "Y":

                    string requestY = "https://www.youtube.com/channel/UCaJ9YHkVsRRg3-oI604VTxQ";
                    ProcessStartInfo psY = new ProcessStartInfo
                    {
                        FileName = requestY,
                        UseShellExecute = true
                    };
                    Process.Start(psY);
                    WriteLine("Loading Program's Plz wait....");
                    Thread.Sleep(1500);
                    Clear();
                    break;

                //Discord
                case "D":

                    string requestD = "https://discord.gg/y66zx9d7";
                    ProcessStartInfo psD = new ProcessStartInfo
                    {
                        FileName = requestD,
                        UseShellExecute = true
                    };
                    Process.Start(psD);

                    Thread.Sleep(1500);
                    WriteLine("Loading Program's Plz wait....");
                    Clear();
                    break;

                default:
                    Clear();
                    WriteLine("Plz Enter The Right Letter ");
                    Loadsource();
                    break;
            }






        }
































    }
}
