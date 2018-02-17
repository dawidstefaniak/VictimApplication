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

namespace VictimApplication.iOS.Views
{
    [Register ("LoginView")]
    partial class LoginView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCLoginLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCLoginToMenu { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCPasswordLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCLogin != null) {
                VCLogin.Dispose ();
                VCLogin = null;
            }

            if (VCLoginLabel != null) {
                VCLoginLabel.Dispose ();
                VCLoginLabel = null;
            }

            if (VCLoginToMenu != null) {
                VCLoginToMenu.Dispose ();
                VCLoginToMenu = null;
            }

            if (VCPassword != null) {
                VCPassword.Dispose ();
                VCPassword = null;
            }

            if (VCPasswordLabel != null) {
                VCPasswordLabel.Dispose ();
                VCPasswordLabel = null;
            }
        }
    }
}