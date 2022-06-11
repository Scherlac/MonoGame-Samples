#if !WINDOWS
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Microsoft.Xna;
using Microsoft.Xna.Samples;
using Microsoft.Xna.Samples.BatteryStatus;
using Microsoft.Xna.Framework;
#endif

namespace Microsoft.Xna.Samples.BatteryStatus
{
#if !WINDOWS
	[Register ("AppDelegate")]
	class Program : UIApplicationDelegate 
	{
		private Game1 game;

		public override void FinishedLaunching (UIApplication app)
		{
			// Fun begins..
			game = new Game1();
			game.Run();
		}

		static void Main (string [] args)
		{
			UIApplication.Main (args,null,"AppDelegate");
		}
	}

#else
	/// <summary>
	/// The main entry point for the application.
	/// </summary>
	static class Program
	{
		static void Main()
		{
			using (Game1 game = new Game1())
			{
				game.Run();
			}
		}
	}

#endif

}
