using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace App1.iOS
{
    public class WheelSlice
    {
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float MidValue { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}