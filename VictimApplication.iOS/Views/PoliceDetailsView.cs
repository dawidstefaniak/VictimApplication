using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class PoliceDetailsView : MvxViewController<PoliceDetailsViewModel>
    {
        public PoliceDetailsView() : base("PoliceDetailsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.CreateBinding(VCBack).To((PoliceDetailsViewModel vm) => vm.ShowMenuCommand).Apply();
            this.CreateBinding(VCDetails).To((PoliceDetailsViewModel vm) => vm.Details).Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

