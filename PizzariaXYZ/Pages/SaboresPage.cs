using System;

using Xamarin.Forms;

namespace PizzariaXYZ.Pages
{
    public class SaboresPage : BasePage
    {
        public SaboresPage()
        {
            Title = "Sabores";
            var lista = new ListView();

            lista.ItemsSource = new[]{
                "Calabresa",
                "Portuguesa",
                "Mista",
                "Quatro Queijos"
            };

            lista.ItemTapped += (sender, e) => {
                DisplayAlert("Sabor", (string)((ListView)sender).SelectedItem, "Ok");
                ((ListView)sender).SelectedItem = null;
            };

            Content = lista;
        }
    }
}

