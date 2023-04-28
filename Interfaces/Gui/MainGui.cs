using Terminal.Gui;
namespace CupCakesHub.Interfaces.Gui
{
	class MainGui
	{

		public static void Gui()
		{



			Application.Init();
			var menu = new MenuBar(new MenuBarItem[] {
			new MenuBarItem ("_File", new MenuItem [] {
				new MenuItem ("_Quit", "", () => {
					Application.RequestStop ();
				})
			}),
		});

			var win = new Window("Hello")
			{
				X = 0,
				Y = 1,
				Width = Dim.Fill(),
				Height = Dim.Fill() - 1
			};

			// Add both menu and win in a single call
			Application.Top.Add(menu, win);
			Application.Run();
			Application.Shutdown();




			



		}


		void SetupMyView(View myView)
		{
			var label = new Label("Username: ")
			{
				X = 1,
				Y = 1,
				Width = 20,
				Height = 1
			};
			myView.Add(label);

			var username = new TextField("")
			{
				X = 1,
				Y = 2,
				Width = 30,
				Height = 1
			};
			myView.Add(username);
		}






	}
	



}
