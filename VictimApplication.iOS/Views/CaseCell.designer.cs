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
    [Register ("CaseCell")]
    partial class CaseCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCCaseName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCStatus { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCCaseName != null) {
                VCCaseName.Dispose ();
                VCCaseName = null;
            }

            if (VCDate != null) {
                VCDate.Dispose ();
                VCDate = null;
            }

            if (VCStatus != null) {
                VCStatus.Dispose ();
                VCStatus = null;
            }
        }
    }
}