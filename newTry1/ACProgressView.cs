using Foundation;
using System;
using UIKit;
using Xamarin.iOS.DGActivityIndicatorViewBinding;
using CoreGraphics;
using System.Threading.Tasks;

            
namespace Bitaqati.iOS
{
    public partial class ACProgressView : UIView
    {
        private DGActivityIndicatorView activitySpinner;
        public UIImageView cloud; 

        public ACProgressView (CGRect frame) : base(frame)
        {
            // configurable bits
            BackgroundColor = UIColor.Clear;
            Alpha = 0.75f;
            AutoresizingMask = UIViewAutoresizing.All;

            nfloat labelHeight = 22;
            nfloat labelWidth = Frame.Width - 20;

            // derive the center x and y
            nfloat centerX = Frame.Width / 2;
            nfloat centerY = Frame.Height / 2;
            //Console.WriteLine("\nFrame center Width = {0} and Frame center Hight = {1}\n",centerX, centerY);



             cloud = new UIImageView(UIImage.FromBundle("cloud"));   
            cloud.Frame = new CGRect(centerX - (cloud.Image.CGImage.Width / 2), centerY - (cloud.Image.CGImage.Height / 2) - 20, cloud.Image.CGImage.Width, cloud.Image.CGImage.Height);
            cloud.TintColor = UIColor.White;
            //     # imageLiteral(resourceName: "cloud")
            //   # imageLiteral(resourceNaUIImage.FromBundle("cloud_off")me: "cloud_done")
            //UIImage.FromBundle("cloud_off")
            //activitySpinner.AutoresizingMask = UIViewAutoresizing.All;   
            double size = cloud.Image.CGImage.Width * 1.9;
            nfloat s = (nfloat)size;
            activitySpinner = new DGActivityIndicatorView(DGActivityIndicatorAnimationType.BallClipRotate, UIColor.White, cloud.Image.CGImage.Width * 2);
            activitySpinner.Frame = new CGRect(centerX - (activitySpinner.Frame.Width / 2), centerY - activitySpinner.Frame.Height - 20, activitySpinner.Frame.Width, activitySpinner.Frame.Height);
            //activitySpinner.Bounds = frame;

            AddSubview(activitySpinner);
            AddSubview(cloud);
            activitySpinner.StartAnimating();

            // create and configure the "Loading Data" label
            textLabel = new UILabel(new CGRect(
                centerX - (labelWidth / 2),
                centerY + 50,
                labelWidth,
                labelHeight
                ));
            textLabel.BackgroundColor = UIColor.Clear;
            textLabel.TextColor = UIColor.White;
            textLabel.Text = "Service unavailable on this address";
            textLabel.TextAlignment = UITextAlignment.Center;
            textLabel.AutoresizingMask = UIViewAutoresizing.All;
            textLabel.Font = textLabel.Font.WithSize(14);
            AddSubview(textLabel);



            //activitySpinner.StopAnimating();
          //  delay(cloud);
        }

        async void delay(UIImageView view)
        {
            
            //int x = 5;
            await Task.Delay(TimeSpan.FromSeconds(1));
            //activitySpinner.Hidden = true;//StopAnimating();
            activitySpinner.StopAnimating();
            cloud.Image = UIImage.FromBundle("cloud_off");
            //add2(view);
            AddSubview(view);
        }

        public void add2(UIView view)
        {
            AddSubview(view);
        }

        /// <summary>
        /// Fades out the control and then removes it from the super view
        /// </summary>
        public void Hide()
        {
            UIView.Animate(
                0.1, // duration
                () => { Alpha = 0; },
                () => { RemoveFromSuperview(); }
            );
        }


    }
}