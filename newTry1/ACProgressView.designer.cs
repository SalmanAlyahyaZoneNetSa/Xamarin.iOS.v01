// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bitaqati.iOS
{
    [Register ("ACProgressView")]
    partial class ACProgressView
    {
        //[Outlet]
        //[GeneratedCode ("iOS Designer", "1.0")]
        //Xamarin.iOS.DGActivityIndicatorViewBinding.DGActivityIndicatorView activityView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Xamarin.iOS.DGActivityIndicatorViewBinding.DGActivityIndicatorView ActivityView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIVisualEffectView blurView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView hudView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel textLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            //if (activityView != null) {
            //    activityView.Dispose ();
            //    activityView = null;
            //}

            if (ActivityView != null) {
                ActivityView.Dispose ();
                ActivityView = null;
            }

            if (blurView != null) {
                blurView.Dispose ();
                blurView = null;
            }

            if (hudView != null) {
                hudView.Dispose ();
                hudView = null;
            }

            if (textLabel != null) {
                textLabel.Dispose ();
                textLabel = null;
            }
        }
    }
}