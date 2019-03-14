using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;

namespace JsonAnimation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand PlayingCommand { get; private set; }
        public ICommand FinishedCommand { get; private set; }
        public ICommand ClickedCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            PlayingCommand = new DelegateCommand(PlayingHandle);

            FinishedCommand = new DelegateCommand(FinishedHandle);

            ClickedCommand = new DelegateCommand(ClickedHandle);
        }

        private void ClickedHandle()
        {
        }

        private void FinishedHandle()
        {
        }

        private void PlayingHandle()
        {
        }
    }
}
