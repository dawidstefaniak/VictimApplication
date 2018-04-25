using System;
using MvvmCross.Binding.BindingContext;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using VictimApplication.Core.Models;

namespace VictimApplication.iOS.Views
{
    public partial class CaseCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CaseCell");
        public static readonly UINib Nib;

        static CaseCell()
        {
            Nib = UINib.FromName("CaseCell", NSBundle.MainBundle);
        }

        protected CaseCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<CaseCell, CaseDto>();
                set.Bind(VCCaseName).To(m => m.RefNumber).Apply();
            });
        }
    }
}
