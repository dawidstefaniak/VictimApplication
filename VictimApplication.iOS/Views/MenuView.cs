﻿using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using VictimApplication.Core.ViewModels;
using UIKit;

namespace VictimApplication.iOS.Views
{
    public partial class MenuView : MvxViewController<MenuViewModel>
    {
        public MenuView() : base("MenuView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.CreateBinding(VCLogout).To((MenuViewModel vm) => vm.ShowLoginCommand).Apply();
            this.CreateBinding(VCInformation).To((MenuViewModel vm) => vm.ShowInformationCommand).Apply();
            this.CreateBinding(VCCases).To((MenuViewModel vm) => vm.ShowCasesCommand).Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

