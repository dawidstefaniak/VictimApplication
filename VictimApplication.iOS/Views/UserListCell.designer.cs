// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace VictimApplication.iOS.Views
{
    [Register ("UserListCell")]
    partial class UserListCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCId { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCUserType { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCId != null) {
                VCId.Dispose ();
                VCId = null;
            }

            if (VCName != null) {
                VCName.Dispose ();
                VCName = null;
            }

            if (VCUserType != null) {
                VCUserType.Dispose ();
                VCUserType = null;
            }
        }
    }
}