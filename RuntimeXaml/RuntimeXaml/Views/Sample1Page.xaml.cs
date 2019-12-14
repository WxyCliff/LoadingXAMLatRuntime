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
            LoadXaml();
        }


        async Task LoadXaml()
        {
             this.Loading(true);

            // API REUTRN XAML BUTTON
            // ADD BUTTON CLICK ALERT EVENT
            // ADD BUTTON TO LAYOUT
            var navigationButtonXAML = await ApiService.GetSample1Button();
            Button navigationButton = new Button().LoadFromXaml(navigationButtonXAML);
            navigationButton.Clicked += OnNavigationButton_Clicked;

            _stackLayout.Children.Add(navigationButton);

           this.Loading(false);
        }

        async void OnNavigationButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Alert Display", "OK");
        }
    }
}