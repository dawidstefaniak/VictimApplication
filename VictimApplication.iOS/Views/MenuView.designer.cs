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
    [Register ("MenuView")]
    partial class MenuView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCCases { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCInformation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCLogout { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCCases != null) {
                VCCases.Dispose ();
                VCCases = null;
            }

            if (VCInformation != null) {
                VCInformation.Dispose ();
                VCInformation = null;
            }

            if (VCLogout != null) {
                VCLogout.Dispose ();
                VCLogout = null;
            }
        }
    }
}