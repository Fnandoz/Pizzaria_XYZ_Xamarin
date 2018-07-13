using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PizzariaXYZ.Pages
{
    public class MapaPage : BasePage
    {
        public MapaPage()
        {
            var posicao = new Position(-1.373305, -48.443019);
            var mapa = new Map(MapSpan.FromCenterAndRadius(posicao, Distance.FromKilometers(0.3f))){
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            mapa.Pins.Add(new Pin(){
                Type = PinType.Place, 
                Position = posicao,
                Label = "Pizzaria XYZ",
                Address = "Rua XyZ"
            });

            Content = new StackLayout
            {
                Children = {
                    mapa
                }
            };
        }
    }
}

