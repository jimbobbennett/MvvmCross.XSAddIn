using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace ${ProjectName}.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string yourNickname = string.Empty;

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

        public ICommand ShowAboutPageCommand
        {
            get { return new MvxCommand(() => ShowViewModel<AboutViewModel>()); }
        }
    }
}
