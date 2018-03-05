// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Bitaqati.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIImageView logoIV { get; set; }


        [Outlet]
        UIKit.UIImageView Right_Bottom { get; set; }


        [Outlet]
        UIKit.UIView SuperView { get; set; }


        [Outlet]
        UIKit.UIImageView Top_Center { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton connectButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView inputContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView lineView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton qrButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView setting_icon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField url_TextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView urlView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView zone_logo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView zone_logo_View { get; set; }

        [Action ("ConnectButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ConnectButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("QrButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void QrButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (connectButton != null) {
                connectButton.Dispose ();
                connectButton = null;
            }

            if (inputContainer != null) {
                inputContainer.Dispose ();
                inputContainer = null;
            }

            if (lineView != null) {
                lineView.Dispose ();
                lineView = null;
            }

            if (logoIV != null) {
                logoIV.Dispose ();
                logoIV = null;
            }

            if (qrButton != null) {
                qrButton.Dispose ();
                qrButton = null;
            }

            if (Right_Bottom != null) {
                Right_Bottom.Dispose ();
                Right_Bottom = null;
            }

            if (setting_icon != null) {
                setting_icon.Dispose ();
                setting_icon = null;
            }

            if (SuperView != null) {
                SuperView.Dispose ();
                SuperView = null;
            }

            if (Top_Center != null) {
                Top_Center.Dispose ();
                Top_Center = null;
            }

            if (url_TextField != null) {
                url_TextField.Dispose ();
                url_TextField = null;
            }

            if (urlView != null) {
                urlView.Dispose ();
                urlView = null;
            }

            if (zone_logo != null) {
                zone_logo.Dispose ();
                zone_logo = null;
            }

            if (zone_logo_View != null) {
                zone_logo_View.Dispose ();
                zone_logo_View = null;
            }
        }
    }
}