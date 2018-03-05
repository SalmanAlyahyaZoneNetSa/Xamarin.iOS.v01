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
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView clientLogoImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView fingerPrintImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fingerPrintLabelInstruction { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fingerPrintLabelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView fingerPrintView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView InputContainerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField passwordTF { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton signINButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField userNameTF { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (clientLogoImage != null) {
                clientLogoImage.Dispose ();
                clientLogoImage = null;
            }

            if (fingerPrintImage != null) {
                fingerPrintImage.Dispose ();
                fingerPrintImage = null;
            }

            if (fingerPrintLabelInstruction != null) {
                fingerPrintLabelInstruction.Dispose ();
                fingerPrintLabelInstruction = null;
            }

            if (fingerPrintLabelTitle != null) {
                fingerPrintLabelTitle.Dispose ();
                fingerPrintLabelTitle = null;
            }

            if (fingerPrintView != null) {
                fingerPrintView.Dispose ();
                fingerPrintView = null;
            }

            if (InputContainerView != null) {
                InputContainerView.Dispose ();
                InputContainerView = null;
            }

            if (passwordTF != null) {
                passwordTF.Dispose ();
                passwordTF = null;
            }

            if (signINButton != null) {
                signINButton.Dispose ();
                signINButton = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }

            if (userNameTF != null) {
                userNameTF.Dispose ();
                userNameTF = null;
            }
        }
    }
}