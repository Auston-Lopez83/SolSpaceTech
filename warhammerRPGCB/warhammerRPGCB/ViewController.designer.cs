// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace warhammerRPGCB
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSPopUpButton careerMenu { get; set; }

		[Outlet]
		AppKit.NSPopUpButtonCell raceMenu { get; set; }

		[Outlet]
		AppKit.NSTextField strStat { get; set; }

		[Action ("chooseARace:")]
		partial void chooseARace (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (careerMenu != null) {
				careerMenu.Dispose ();
				careerMenu = null;
			}

			if (raceMenu != null) {
				raceMenu.Dispose ();
				raceMenu = null;
			}

			if (strStat != null) {
				strStat.Dispose ();
				strStat = null;
			}
		}
	}
}
