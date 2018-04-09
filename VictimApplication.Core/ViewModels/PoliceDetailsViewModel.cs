using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class PoliceDetailsViewModel : MvxViewModel
    {
        private string _details = "Your Policeman Details will be here";

        public string Details
        {
            get => _details;
        }
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            Close(this);
        }
    }
}
