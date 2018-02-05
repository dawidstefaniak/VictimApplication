using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using VictimApplication.Core.ViewModels;


namespace VictimApplication.Droid.Views
{
    [Activity(Label = "Messanger")]
    public class MessangerView : MvxActivity<MessangerViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MessangerView);
        }
    }
}
