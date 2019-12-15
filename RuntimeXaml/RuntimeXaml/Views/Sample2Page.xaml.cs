using DomainModel;
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
    public partial class Sample2Page : BasePage
    {
        /// <summary>
        /// API Return Xaml
        /// </summary>
        public Sample2Page()
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
            var navigationButtonXAML = await ApiService.GetXamlItems("GetSample2");

            Button navigationButton = new Button().LoadFromXaml(navigationButtonXAML.FirstOrDefault());
            navigationButton.Clicked += OnNavigationButton_Clicked;

            _stackLayout.Children.Add(navigationButton);

            this.Loading(false);
        }



        async void OnNavigationButton_Clicked(object sender, EventArgs e)
        {
            // LOAD PAGE FROM API
            var pageXAML = await ApiService.GetXamlItems("GetSample2Page");

            ContentPage page = new ContentPage().LoadFromXaml(pageXAML.FirstOrDefault());

            // ADD BUTTON CLICK EVENT
            Button postButton = page.FindByName<Button>("_postButton");
            postButton.Clicked += async (sender2, args) =>
            {
                // SEARCH INPUTVIEW IN PAGE
                StackLayout postLayout = page.FindByName<StackLayout>("_postLayout");

                List<string> values = new List<string>();

                foreach (var element in postLayout.Children)
                {
                    switch (element)
                    {
                        case Entry entry:
                            var text = ((Entry)element).Text;
                            if (!string.IsNullOrWhiteSpace(text))
                            {
                                values.Add(text);
                            }
                            break;

                        case Picker picker:
                            var item = ((Picker)element).SelectedItem;
                            if (item == null) continue;
                            if (!string.IsNullOrWhiteSpace(item.ToString()))
                            {
                                values.Add(item.ToString());
                            }
                            break;

                        case DatePicker datePicker:
                            var date = ((DatePicker)element).Date;
                            values.Add(date.ToString("yyyy/MM/dd"));
                            break;
                    }
                }
                // POST DATA
                var postData = new PostData();
                postData.PostStrings = values;
                var apiResponse = await ApiService.PostItems(postData);

                // SHOW RESPONSE
                await DisplayAlert("Response", apiResponse.FirstOrDefault(), "OK");
            };


            await Navigation.PushAsync(page);
        }
    }
}