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
            _angle = 472;
        }

        public override void Draw(CoreGraphics.CGRect rect)
        {
            DemoStyleKit.DrawTimer(rect, Angle);
        }


        float _angle;

        [Export("Angle"), Browsable(true)]
        public float Angle 
        {
            get 
            { 
                return _angle; 
            }
            set 
            { 
                _angle = value;
                SetNeedsDisplay ();
            }
        }

    }
}

