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
    [Register ("MessageView")]
    partial class MessageView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCMessageText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCSenderId { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCMessageText != null) {
                VCMessageText.Dispose ();
                VCMessageText = null;
            }

            if (VCSenderId != null) {
                VCSenderId.Dispose ();
                VCSenderId = null;
            }
        }
    }
}