using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Opcion1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje","Hola","OK");
        }
    }
}
