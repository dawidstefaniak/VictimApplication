using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class InformationView : MvxViewController<InformationViewModel>
    {
        public InformationView() : base("InformationView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.CreateBinding(VCInformation).To((InformationViewModel vm) => vm.Information).Apply();
            this.CreateBinding(VCBack).To((InformationViewModel vm) => vm.ShowMenuCommand).Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

