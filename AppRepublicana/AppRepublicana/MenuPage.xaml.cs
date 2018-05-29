using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRepublicana
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void BtnUno_Clicked(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new CiudadPage());
        }

        private void BtnDos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientePage());
        }

        private void BtnTres_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductosPage());
        }

        private void BtnCuatro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PedidosPage());
        }
    }
}