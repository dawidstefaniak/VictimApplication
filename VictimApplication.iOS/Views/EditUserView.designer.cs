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
    [Register ("EditUserView")]
    partial class EditUserView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCFirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCPostEdit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCSecondName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCUserName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCUserType { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCEmail != null) {
                VCEmail.Dispose ();
                VCEmail = null;
            }

            if (VCFirstName != null) {
                VCFirstName.Dispose ();
                VCFirstName = null;
            }

            if (VCPostEdit != null) {
                VCPostEdit.Dispose ();
                VCPostEdit = null;
            }

            if (VCSecondName != null) {
                VCSecondName.Dispose ();
                VCSecondName = null;
            }

            if (VCUserName != null) {
                VCUserName.Dispose ();
                VCUserName = null;
            }

            if (VCUserType != null) {
                VCUserType.Dispose ();
                VCUserType = null;
            }
        }
    }
}