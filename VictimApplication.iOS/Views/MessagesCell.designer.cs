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
    [Register ("MessagesCell")]
    partial class MessagesCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCMessage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCUserIdentity { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCMessage != null) {
                VCMessage.Dispose ();
                VCMessage = null;
            }

            if (VCUserIdentity != null) {
                VCUserIdentity.Dispose ();
                VCUserIdentity = null;
            }
        }
    }
}