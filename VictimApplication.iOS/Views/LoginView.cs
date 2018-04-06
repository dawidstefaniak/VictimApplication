using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using VictimApplication.Core.ViewModels;
using UIKit;

namespace VictimApplication.iOS.Views
{
    public partial class LoginView : MvxViewController<LoginViewModel>
    {
        public LoginView() : base("LoginView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            this.CreateBinding(VCLogin).To((LoginViewModel vm) => vm.Login).Apply();
            this.CreateBinding(VCPassword).To((LoginViewModel vm) => vm.Password).Apply();
            this.CreateBinding(VCLoginToMenu).To((LoginViewModel vm) => vm.ShowMenuCommand2).Apply();

            View.AddGestureRecognizer(new UITapGestureRecognizer(() => {
                this.VCLogin.ResignFirstResponder();
                this.VCPassword.ResignFirstResponder();
            }));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

