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
    [Register ("CasesForModifyingView")]
    partial class CasesForModifyingView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView VCTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCTableView != null) {
                VCTableView.Dispose ();
                VCTableView = null;
            }
        }
    }
}