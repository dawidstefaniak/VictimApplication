using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using VictimApplication.Core.Models;
using VictimApplication.Core.Services;

namespace VictimApplication.Core.ViewModels
{
    public class MessangerViewModel : MvxViewModel<CaseDto>
    {
        private string _messanger;
        private readonly IApi _api;

        private int caseid;
        public string Messanger 
        {
            get => _messanger;
            set { SetProperty(ref _messanger, value); }
        }

        public MessangerViewModel(IApi api)
        {
            _api = api;
        }

        public IMvxCommand ShowMenuCommand => new MvxCommand(ShowMenu);

        public void Init(CaseDto parameter)
        {
            Messanger = parameter.CaseId.ToString();
        }

		private void ShowMenu()
        {
            Close(this);
        }

        public override void Prepare(CaseDto parameter)
        {
            
        }
    }
}
