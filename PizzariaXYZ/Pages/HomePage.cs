using System;

using Xamarin.Forms;

namespace PizzariaXYZ.Pages
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            var telefone = new Button() { Text = "(00)12345678" };
            telefone.Clicked += (sender, e) =>
            {
                Device.OpenUri(new Uri("tel://1234567"));
            };

            Content = new ContentView()
            {
                Content = new StackLayout()
                {
                    Children = {
                        telefone
                    }
                },

                VerticalOptions = LayoutOptions.CenterAndExpand

            };
        }
    }
}

