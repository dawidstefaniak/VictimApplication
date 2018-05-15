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
    [Register ("MenuPoliceView")]
    partial class MenuPoliceView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCAddCase { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCCases { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCGivePoliceRights { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCMessanger { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCAddCase != null) {
                VCAddCase.Dispose ();
                VCAddCase = null;
            }

            if (VCCases != null) {
                VCCases.Dispose ();
                VCCases = null;
            }

            if (VCGivePoliceRights != null) {
                VCGivePoliceRights.Dispose ();
                VCGivePoliceRights = null;
            }

            if (VCMessanger != null) {
                VCMessanger.Dispose ();
                VCMessanger = null;
            }
        }
    }
}