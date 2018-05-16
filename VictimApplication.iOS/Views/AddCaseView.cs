using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
	public partial class AddCaseView : MvxViewController<AddCaseViewModel>
    {
        public AddCaseView() : base("AddCaseView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.

			this.CreateBinding(VCEmail).To((AddCaseViewModel vm) => vm.Email).Apply();
			this.CreateBinding(VCAddress).To((AddCaseViewModel vm) => vm.Address).Apply();
			this.CreateBinding(VCFirstName).To((AddCaseViewModel vm) => vm.FirstName).Apply();
			this.CreateBinding(VCRefNumber).To((AddCaseViewModel vm) => vm.RefNumber).Apply();
			this.CreateBinding(VCCaseStatus).To((AddCaseViewModel vm) => vm.CaseStatus).Apply();
			this.CreateBinding(VCReportDate).To((AddCaseViewModel vm) => vm.ReportDate).Apply();
			this.CreateBinding(VCSecondName).To((AddCaseViewModel vm) => vm.SecondName).Apply();
			this.CreateBinding(VCPhoneNumber).To((AddCaseViewModel vm) => vm.PhoneNumber).Apply();
			this.CreateBinding(VCTypeOfCrime).To((AddCaseViewModel vm) => vm.TypeOfCrime).Apply();
			this.CreateBinding(VCAdd).To((AddCaseViewModel vm) => vm.AddCaseCommand).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

