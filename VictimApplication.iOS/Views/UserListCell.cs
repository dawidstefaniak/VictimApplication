using System;
using MvvmCross.Binding.BindingContext;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using VictimApplication.Core.Models;

namespace VictimApplication.iOS.Views
{
    public partial class UserListCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("CaseCell");
        public static readonly UINib Nib;

		static UserListCell()
        {
			Nib = UINib.FromName("UserListCell", NSBundle.MainBundle);
        }

		protected UserListCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            this.DelayBind(() =>
            {
				var set = this.CreateBindingSet<UserListCell, UserListToReturnDto>();
				set.Bind(VCName).To(m => m.NameToReturn).Apply();
				set.Bind(VCUserType).To(m => m.UserTypeToReturn).Apply();
            });
        }
    }
}