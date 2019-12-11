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
    public partial class Sample1Page : BasePage
    {
        /// <summary>
        /// API Return Xaml Button
        /// </summary>
        public Sample1Page()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadXaml();
        }
        async Task LoadXaml()
        {
            var navigationButtonXAML = await ApiService.GetSample1Button();
            Button navigationButton = new Button().LoadFromXaml(navigationButtonXAML);
            navigationButton.Clicked += OnNavigationButton_Clicked;
            _stackLayout.Children.Add(navigationButton);
        }

        private async void OnNavigationButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Alert Display", "OK");
        }
    }
}