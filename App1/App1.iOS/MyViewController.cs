using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using App1;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EmojiWheel), typeof(App1.iOS.MyViewController))]
namespace App1.iOS
{
    public class MyViewController : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            var rotatingWheel = new RotatingWheelView(new RectangleF(0, 0, 200, 200), new RotatingWheelSettings()
            {
                BackgroundImage = UIImage.FromBundle("images/bg.png"),
                //CenterButtonImage = UIImage.FromBundle("images/centerButton.png"),
                SegmentImage = UIImage.FromBundle("images/segment.png"),
                Slices = new List<RotatingWheelSettings.WheelSliceValue>()
                        {
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_angry.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_bored.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_content.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_happy.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_okay.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_peacefull.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_sad.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/emoji_worried.png"),
                                    Value = "Circle"
                                },
                        }
            })
            { Center = new PointF(160, 240) };
            this.AddSubview(rotatingWheel);

        }
    }
}