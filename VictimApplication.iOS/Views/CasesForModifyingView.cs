using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class CasesForModifyingView : MvxViewController<CasesForModifyingViewModel>
    {
        public CasesForModifyingView() : base("CasesView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var source = new MvxSimpleTableViewSource(VCTableView, "CaseCell", CaseCell.Key);
            VCTableView.RowHeight = 142;

            var set = this.CreateBindingSet<CasesForModifyingView, CasesForModifyingViewModel>();
            set.Bind(source).To(v => v.CasesObservable);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(s => s.EditCaseCommand);
            set.Apply();

            VCTableView.Source = source;
            VCTableView.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

