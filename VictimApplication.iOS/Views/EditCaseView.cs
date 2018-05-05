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
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

