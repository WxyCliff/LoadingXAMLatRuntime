using RuntimeXaml.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RuntimeXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasePage : ContentPage
    {
        public IApiService ApiService => DependencyService.Get<IApiService>();
        public BasePage()
        {
            InitializeComponent();
        }


        public void Loading(bool isRunning)
        {
            ActivityIndicator activityIndicator = basePage.FindByName<ActivityIndicator>("defaultActivityIndicator");

            if (isRunning)
            {
                activityIndicator.IsRunning = true;
            }
            else
            {
                activityIndicator.IsRunning = false;
                activityIndicator.VerticalOptions = LayoutOptions.Start;
                activityIndicator.HeightRequest = 0;
            }
        }
    }
}