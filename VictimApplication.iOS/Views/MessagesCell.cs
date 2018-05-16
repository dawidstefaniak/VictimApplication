using System;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using VictimApplication.Core.Models;

namespace VictimApplication.iOS.Views
{
    public partial class MessagesCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("MessagesCell");
        public static readonly UINib Nib;

        static MessagesCell()
        {
            Nib = UINib.FromName("MessagesCell", NSBundle.MainBundle);
        }

        protected MessagesCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<MessagesCell, MessageDto>();
                set.Bind(VCMessage).To(m => m.MessageText).Apply();
				set.Bind(VCUserIdentity).To(m => m.GetUserType).Apply();
            });
            
        }
    }
}
