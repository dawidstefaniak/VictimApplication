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

        void ReleaseDesignerOutlets ()
        {
            if (VCCaseName != null) {
                VCCaseName.Dispose ();
                VCCaseName = null;
            }
        }
    }
}