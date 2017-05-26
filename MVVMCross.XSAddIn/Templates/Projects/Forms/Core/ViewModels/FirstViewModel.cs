using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace ${ProjectName}.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        string yourNickname = string.Empty;

        public string YourNickname
        { 
            get { return yourNickname; }
            set 
            { 
                if (SetProperty(ref yourNickname, value))
                    RaisePropertyChanged(() => Hello); 
            }
        }

        public string Hello => $"Hello {YourNickname}";

        public ICommand ShowAboutPageCommand => new MvxAsyncCommand(() => navigationService.Navigate<AboutViewModel>());
    }
}
