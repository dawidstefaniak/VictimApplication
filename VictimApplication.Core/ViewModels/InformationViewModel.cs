using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class InformationViewModel : MvxViewModel
    {
        private string _information = "This is instruction how to contact us";

        public string Information
        {
            get =>_information;
        }
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
