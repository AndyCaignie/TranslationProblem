using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Helpers;

namespace Translations.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand AddToCounterCommand { get; }
        static int Counter = 0;
        public LocalizedString CounterText { get; } = new(() => string.Format(Translations.ButtonCounter, Counter));
        string sUntranslatedText = "";

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            AddToCounterCommand = new Command(ExecuteAddToCounterCommand);
            UntranslatedText = string.Format(Translations.ButtonCounter, Counter);
        }

        public string UntranslatedText
        {
            get { return sUntranslatedText; }
            set { SetProperty(ref sUntranslatedText, value); }            
        }

        public ICommand OpenWebCommand { get; }

        void ExecuteAddToCounterCommand()
        {
            Counter = Counter + 1;
            UntranslatedText = string.Format(Translations.ButtonCounter, Counter);
        }
    }
}