// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PaintCodeDemo
{
	[Register ("PaintCodeDemoViewController")]
	partial class PaintCodeDemoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider slider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MyTimerView timerView { get; set; }

		[Action ("slider_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void slider_ValueChanged (UISlider sender);

		void ReleaseDesignerOutlets ()
		{
			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}
			if (timerView != null) {
				timerView.Dispose ();
				timerView = null;
			}
		}
	}
}
