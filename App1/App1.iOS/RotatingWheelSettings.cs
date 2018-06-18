using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace App1.iOS
{
    public class RotatingWheelSettings
    {
        public UIImage SegmentImage { get; set; }
        public UIImage BackgroundImage { get; set; }
        public UIImage CenterButtonImage { get; set; }
        public List<WheelSliceValue> Slices { get; set; }

        public RotatingWheelSettings()
        {
            Slices = new List<WheelSliceValue>();
        }

        public class WheelSliceValue
        {
            public UIImage Image { get; set; }
            public string Value { get; set; }
        }
    }
}