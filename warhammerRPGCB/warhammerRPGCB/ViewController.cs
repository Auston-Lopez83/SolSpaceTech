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
		public int strength;
		int str;
		string race;
		races human = new races();





		public ViewController(IntPtr handle) : base(handle)
		{
		}

		partial void chooseARace(NSObject sender)
		{
			raceMenu.SelectedItem = race;

			switch(race)



			

			     
			//strStat.IntValue = str ;
		
		}
		/*
		 partial void pressMe(NSObject sender)
		{
			stuffHere.StringValue = string.Format("the Button has be pressed {0} time{1}", ++numberOfTimesPressed, (numberOfTimesPressed<2) ? "": "s");
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
			stuffHere.StringValue = "button has not been clicked";
		}
		*/

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
