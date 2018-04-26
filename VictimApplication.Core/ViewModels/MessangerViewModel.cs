using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;

namespace VictimApplication.Core.ViewModels
{
    public class MessangerViewModel : MvxViewModel<CaseDto>
    {
        private string _messanger = "hi";
        private int caseid;
        public string Messanger 
        {
            get => _messanger;
            set { SetProperty(ref _messanger, value); }
        }
        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        public override void Prepare(CaseDto parameter)
        {
            caseid = parameter.CaseId;
        }

		public override async Task Initialize()
		{
            Messanger = caseid.ToString();
		}

		private void ShowMenu()
        {
            Close(this);
        }
    }
}
