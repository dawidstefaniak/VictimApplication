using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using UIKit;
using VictimApplication.Core.ViewModels;

namespace VictimApplication.iOS.Views
{
    public partial class MessageView : MvxViewController<MessageViewModel>
    {
        public MessageView() : base("MessageView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.CreateBinding(VCSenderId).To((MessageViewModel vm) => vm.CurrentMessage.SenderUserId).Apply();
            this.CreateBinding(VCMessageText).To((MessageViewModel vm) => vm.CurrentMessage.MessageText).Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

