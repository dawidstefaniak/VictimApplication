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
    [Register ("AddCaseView")]
    partial class AddCaseView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton VCAdd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCCaseStatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCFirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCPhoneNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCRefNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker VCReportDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCSecondName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField VCTypeOfCrime { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VCAdd != null) {
                VCAdd.Dispose ();
                VCAdd = null;
            }

            if (VCAddress != null) {
                VCAddress.Dispose ();
                VCAddress = null;
            }

            if (VCCaseStatus != null) {
                VCCaseStatus.Dispose ();
                VCCaseStatus = null;
            }

            if (VCEmail != null) {
                VCEmail.Dispose ();
                VCEmail = null;
            }

            if (VCFirstName != null) {
                VCFirstName.Dispose ();
                VCFirstName = null;
            }

            if (VCPhoneNumber != null) {
                VCPhoneNumber.Dispose ();
                VCPhoneNumber = null;
            }

            if (VCRefNumber != null) {
                VCRefNumber.Dispose ();
                VCRefNumber = null;
            }

            if (VCReportDate != null) {
                VCReportDate.Dispose ();
                VCReportDate = null;
            }

            if (VCSecondName != null) {
                VCSecondName.Dispose ();
                VCSecondName = null;
            }

            if (VCTypeOfCrime != null) {
                VCTypeOfCrime.Dispose ();
                VCTypeOfCrime = null;
            }
        }
    }
}