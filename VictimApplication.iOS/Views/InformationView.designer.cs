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
    [Register ("InformationView")]
    partial class InformationView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VCInformation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCBack != null) {
                VCBack.Dispose ();
                VCBack = null;
            }

            if (VCInformation != null) {
                VCInformation.Dispose ();
                VCInformation = null;
            }
        }
    }
}