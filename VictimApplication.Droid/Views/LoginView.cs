using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using VictimApplication.Core.ViewModels;


namespace VictimApplication.Droid.Views
{
    [Activity(Label = "Login Page")]
    public class LoginView : MvxActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}
