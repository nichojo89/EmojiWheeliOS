using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace App1.iOS
{
    public class EmojiWheel : IEmojiWheel
    {
        public string GetUniqueIdentifier()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}