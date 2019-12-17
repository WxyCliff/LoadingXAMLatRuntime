using System;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RuntimeXaml.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sample3Page : BasePage
    {
        /// <summary>
        /// API Return Xaml Button
        /// </summary>
        public Sample3Page()
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
            var navigationButtonXAML = await ApiService.GetXamlItems("GetSample3");

            Button navigationButton = new Button().LoadFromXaml(navigationButtonXAML.FirstOrDefault());
            navigationButton.Clicked += OnNavigationButton_Clicked;

            _stackLayout.Children.Add(navigationButton);

            this.Loading(false);
        }

        async void OnNavigationButton_Clicked(object sender, EventArgs e)
        {
            var pageXAML = await ApiService.GetXamlItems("GetSample3Page");

            ContentPage page = new ContentPage().LoadFromXaml(pageXAML.FirstOrDefault());

            await Navigation.PushAsync(page);
        }
    }
}