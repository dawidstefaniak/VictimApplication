using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class MessangerView : MvxViewController<MessangerViewModel>
    {
        public MessangerView() : base("MessangerView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var source = new MvxSimpleTableViewSource(VCMessages, "MessagesCell", MessagesCell.Key);
            VCMessages.RowHeight = 65;

            var set = this.CreateBindingSet<MessangerView, MessangerViewModel>();
            set.Bind(source).To(v => v.MessagesObservable);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(s => s.DisplayMessageCommand);
            set.Apply();

            VCMessages.Source = source;
            VCMessages.ReloadData();

            this.CreateBinding(VCSend).To((MessangerViewModel vm) => vm.SendMessageCommand).Apply();
			this.CreateBinding(VCText).To((MessangerViewModel vm) => vm.Message).Apply();
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

