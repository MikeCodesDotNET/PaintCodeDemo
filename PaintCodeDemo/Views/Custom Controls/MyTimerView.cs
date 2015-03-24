using System;
using UIKit;
using Foundation;
using System.ComponentModel;

namespace PaintCodeDemo
{
    [Register("MyTimerView"), DesignTimeVisible(true)]
	public class MyTimerView : UIView
    {
        public MyTimerView(IntPtr p) : base(p)
        {
            Initialize ();
        }

        public MyTimerView ()
        {
            Initialize ();
        }

        void Initialize ()
        {
            _percentage = 50;
        }

        public override void Draw(CoreGraphics.CGRect rect)
        {
			DemoStyleKit.DrawTimer(rect, Percentage);
        }

		float _percentage; 
		[Export("Percentage"), Browsable(true)]
		public float Percentage 
		{
			get 
			{
				return _percentage;
			}
			set
			{
				_percentage = value;
				SetNeedsDisplay();
			}
		}


    }
}

