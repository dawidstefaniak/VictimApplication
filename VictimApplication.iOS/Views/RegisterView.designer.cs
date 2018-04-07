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
    [Register ("RegisterView")]
    partial class RegisterView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCRegister { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCSurname { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCUsername { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCEmail != null) {
                VCEmail.Dispose ();
                VCEmail = null;
            }

            if (VCName != null) {
                VCName.Dispose ();
                VCName = null;
            }

            if (VCPassword != null) {
                VCPassword.Dispose ();
                VCPassword = null;
            }

            if (VCRegister != null) {
                VCRegister.Dispose ();
                VCRegister = null;
            }

            if (VCSurname != null) {
                VCSurname.Dispose ();
                VCSurname = null;
            }

            if (VCUsername != null) {
                VCUsername.Dispose ();
                VCUsername = null;
            }
        }
    }
}