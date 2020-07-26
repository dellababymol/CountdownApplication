using Countdown.Models;

namespace Countdown.ViewModels
{
    internal sealed class ViewModel
    {

        public LettersViewModel LettersViewModel { get; }
        public StopwatchViewModel StopwatchViewModel { get; }
        public SettingsViewModel SettingsViewModel { get; }



        public ViewModel()
        {
            Model model = new Model();
            StopwatchController sc = new StopwatchController();
            LettersViewModel = new LettersViewModel(model, sc);
            StopwatchViewModel = new StopwatchViewModel(sc);
            SettingsViewModel = new SettingsViewModel();
        }
    }
}