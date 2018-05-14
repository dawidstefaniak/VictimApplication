using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
	public partial class UserListView : MvxViewController<UserListViewModel>
    {
		public UserListView() : base("UserListView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var source = new MvxSimpleTableViewSource(VCTable, "UserListCell", MessagesCell.Key);
			VCTable.RowHeight = 44;

			var set = this.CreateBindingSet<UserListView, UserListViewModel>();
			set.Bind(source).To(v => v.UsersObservable);
			set.Bind(source).For(s => s.SelectionChangedCommand).To(s => s.EditUserCommand);
            set.Apply();

			VCTable.Source = source;
			VCTable.ReloadData();

            //this.CreateBinding(VCSend).To((MessangerViewModel vm) => vm.SendMessageCommand).Apply();
            //this.CreateBinding(VCText).To((MessangerViewModel vm) => vm.Message).Apply();

            //View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
            //    this.VCText.ResignFirstResponder();
            //}));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

