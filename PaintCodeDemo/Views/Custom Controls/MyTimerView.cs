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
            _value = 50;
        }

        public override void Draw(CoreGraphics.CGRect rect)
        {
			DemoStyleKit.DrawTimer(rect, Value);
        }

        float _value; 
		[Export("Value"), Browsable(true)]
		public float Value 
		{
			get 
			{
				return _value;
			}
			set
			{
				_value = value;
				SetNeedsDisplay();
			}
		}


    }
}

