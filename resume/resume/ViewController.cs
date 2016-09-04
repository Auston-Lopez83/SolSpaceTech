//
// ViewController.cs
//
// Created on 9/4/2016
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

namespace resume
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.
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
