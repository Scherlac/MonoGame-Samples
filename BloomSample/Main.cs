#if !WINDOWS

using System;
using System.Collections.Generic;
using System.Linq;

using MonoMac.AppKit;
using MonoMac.Foundation;
#endif

namespace BloomPostprocess
{
#if !WINDOWS
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main (string[] args)
		{
			NSApplication.Init ();
			
			using (var p = new NSAutoreleasePool ()) {
				NSApplication.SharedApplication.Delegate = new AppDelegate ();
				NSApplication.Main (args);
			}


		}
	}

	class AppDelegate : NSApplicationDelegate
	{
		BloomPostprocessGame game;

		public override void FinishedLaunching (MonoMac.Foundation.NSObject notification)
		{
			game = new BloomPostprocessGame ();
			game.Run ();
		}
		
		public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return true;
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
			using (var game = new BloomPostprocessGame())
			{
				game.Run();
			}
		}
	}
#endif
}


