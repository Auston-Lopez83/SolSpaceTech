//
// ViewController.cs
//
// Created on 8/27/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System;

using AppKit;
using Foundation;

namespace warhammerRPGCB
{
	public partial class ViewController : NSViewController
	{
		string raceChoice;
		public void SomeJob()
		{
			//races human = new races();

			raceChoice = races.human.raceName;
		}




		public ViewController(IntPtr handle) : base(handle)
		{
			

		}

		 


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}
	}
}
