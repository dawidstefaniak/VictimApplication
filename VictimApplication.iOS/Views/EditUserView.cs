using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
	public partial class EditUserView : MvxViewController<EditUserViewModel>
    {
        public EditUserView() : base("EditUserView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.CreateBinding(VCUserName).To((EditUserViewModel vm) => vm.UserName).Apply();
			this.CreateBinding(VCFirstName).To((EditUserViewModel vm) => vm.FirstName).Apply();
			this.CreateBinding(VCSecondName).To((EditUserViewModel vm) => vm.SecondName).Apply();
			this.CreateBinding(VCEmail).To((EditUserViewModel vm) => vm.Email).Apply();
			this.CreateBinding(VCUserType).To((EditUserViewModel vm) => vm.UserType).Apply();
			this.CreateBinding(VCPostEdit).To((EditUserViewModel vm) => vm.EditUserCommand).Apply();
		}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

