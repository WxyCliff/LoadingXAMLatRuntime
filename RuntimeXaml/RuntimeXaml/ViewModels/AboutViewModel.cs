using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RuntimeXaml.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://docs.microsoft.com/zh-tw/xamarin/xamarin-forms/xaml/runtime-load"));
        }

        public ICommand OpenWebCommand { get; }
    }
}