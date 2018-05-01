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
    [Register ("MessangerView")]
    partial class MessangerView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView VCMessages { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCSend { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCMessages != null) {
                VCMessages.Dispose ();
                VCMessages = null;
            }

            if (VCSend != null) {
                VCSend.Dispose ();
                VCSend = null;
            }

            if (VCText != null) {
                VCText.Dispose ();
                VCText = null;
            }
        }
    }
}