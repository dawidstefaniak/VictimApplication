using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class EditCaseView :MvxViewController<EditCaseViewModel>
    {
        public EditCaseView() : base("EditCaseView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCEmail).To((EditCaseViewModel vm) => vm.Email).Apply();
            this.CreateBinding(VCCaseId).To((EditCaseViewModel vm) => vm.CaseId).Apply();
            this.CreateBinding(VCAddress).To((EditCaseViewModel vm) => vm.Address).Apply();
            this.CreateBinding(VCFirstName).To((EditCaseViewModel vm) => vm.FirstName).Apply();
            this.CreateBinding(VCOfficerId).To((EditCaseViewModel vm) => vm.OfficerId).Apply();
            this.CreateBinding(VCRefNumber).To((EditCaseViewModel vm) => vm.RefNumber).Apply();
            this.CreateBinding(VCCaseStatus).To((EditCaseViewModel vm) => vm.CaseStatus).Apply();
            this.CreateBinding(VCReportDate).To((EditCaseViewModel vm) => vm.ReportDate).Apply();
            this.CreateBinding(VCSecondName).To((EditCaseViewModel vm) => vm.SecondName).Apply();
            this.CreateBinding(VCPhoneNumber).To((EditCaseViewModel vm) => vm.PhoneNumber).Apply();
            this.CreateBinding(VCTypeOfCrimeId).To((EditCaseViewModel vm) => vm.TypeOfCrimeId).Apply();
            this.CreateBinding(VCEdit).To((EditCaseViewModel vm) => vm.EditCaseCommand).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

