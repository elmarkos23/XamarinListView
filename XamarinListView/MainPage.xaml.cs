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

            List<Persona> lst = new List<Persona>();
            lst.Add(new Persona { nombre = "Marco" });
            lst.Add(new Persona { nombre = "Miguel" });
            lst.Add(new Persona { nombre = "Antonio" });
            lst.Add(new Persona { nombre = "Belen" });
            lvDatos.ItemsSource = lst;
        }

        private async void Opcion1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje","Hola 1","OK");
            lvDatos.SelectionMode = ListViewSelectionMode.None;
        }

        async void Opcion2_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Hola 2", "OK");
        }
    }
}
