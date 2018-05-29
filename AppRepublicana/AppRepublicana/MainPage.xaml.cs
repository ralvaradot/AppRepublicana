using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppRepublicana
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task BtnAutenticar_Clicked(object sender, EventArgs e)
        {
            //await this.Navigation.PushAsync(menu, true);

            //  await App.Navigator.PushAsync(new MenuPage());

            Navigation.PushAsync(new MenuPage());
        }
    }
}
