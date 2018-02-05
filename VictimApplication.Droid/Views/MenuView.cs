using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using VictimApplication.Core.ViewModels;


namespace VictimApplication.Droid.Views
{
    [Activity(Label = "Menu")]
    public class MenuView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MenuView);
        }
    }
}
