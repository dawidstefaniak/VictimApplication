using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class RegisterView : MvxViewController<RegisterViewModel>
    {
        public RegisterView() : base("RegisterView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCName).To((RegisterViewModel vm) => vm.Firstname).Apply();
            this.CreateBinding(VCPassword).To((RegisterViewModel vm) => vm.Password).Apply();
            this.CreateBinding(VCSurname).To((RegisterViewModel vm) => vm.Surname).Apply();
            this.CreateBinding(VCUsername).To((RegisterViewModel vm) => vm.Login).Apply();
            this.CreateBinding(VCEmail).To((RegisterViewModel vm) => vm.Email).Apply();
            this.CreateBinding(VCRegister).To((RegisterViewModel vm) => vm.RegisterCommand).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

