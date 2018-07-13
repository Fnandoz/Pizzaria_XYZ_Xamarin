using System;

using Xamarin.Forms;

namespace PizzariaXYZ.Pages
{
    public class MenuPage : TabbedPage
    {
        public MenuPage()
        {
            Title = "Menu";

            Children.Add(new HomePage()
            {
                Title = "Início"
            });

            Children.Add(new SaboresPage()
            {
                Title = "Cardápio"
            });

            Children.Add(new MapaPage()
            {
                Title = "Mapa"
            });
        }
    }
}

