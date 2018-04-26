using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class CasesView : MvxViewController<CasesViewModel>
    {
        public CasesView() : base("CasesView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var source = new MvxSimpleTableViewSource(VCTableView, "CaseCell", CaseCell.Key);
            VCTableView.RowHeight = 142;

            var set = this.CreateBindingSet<CasesView, CasesViewModel>();
            set.Bind(source).To(v => v.casesobservable);
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

