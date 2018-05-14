using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using VictimApplication.Core.ViewModels;
using UIKit;

namespace VictimApplication.iOS.Views
{
    public partial class MenuPoliceView : MvxViewController<MenuPoliceViewModel>
    {
        public MenuPoliceView() : base("MenuPoliceView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCCases).To((MenuPoliceViewModel vm) => vm.ShowCasesCommand).Apply();
			this.CreateBinding(VCAddCase).To((MenuPoliceViewModel vm) => vm.ShowAddCaseCommand).Apply();
			this.CreateBinding(VCGivePoliceRights).To((MenuPoliceViewModel vm) => vm.EditUserCommand).Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

