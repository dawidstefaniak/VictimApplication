using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace VictimApplication.Core.ViewModels
{
    public class MessangerViewModel : MvxViewModel
    {
        private string _messanger = "Hello there! This is your messanger.";
        public string Messanger 
        {
            get => _messanger;
        }
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        private void ShowMenu()
        {
            ShowViewModel<MenuViewModel>();
        }
    }
}
