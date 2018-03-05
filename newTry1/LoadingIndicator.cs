using System;
using CoreGraphics;
using UIKit;
using Xamarin.iOS.DGActivityIndicatorViewBinding;

namespace Bitaqati.iOS
{
    public class LoadingIndicator
    {
        private DGActivityIndicatorView indicatorView = new DGActivityIndicatorView(DGActivityIndicatorAnimationType.BallPulse, UIColor.White);

        public UIColor backgroundColor = UIColor.Clear;

        public LoadingIndicator()
        {
           // var indicatorView = new DGActivityIndicatorView(DGActivityIndicatorAnimationType.BallPulse, UIColor.White);
        }

    }
}
