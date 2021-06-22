using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Tarea2.Modelos;

namespace Tarea2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BTN_Enviar_Clicked(object sender, EventArgs e)
        {

            if (nomb.Text == null)
            {
                DisplayAlert("Aviso", "Debes Ingresar un Nombre!", "Ok");
            }
            else if (apel.Text == null)
            {
                DisplayAlert("Aviso", "Debes Ingresar un Apellido!", "Ok");
            }
            else if (edad.Text == null)
            {
                DisplayAlert("Aviso", "Debes Ingresar una Edad", "Ok");
            }
            else if (dire.Text == null)
            {
                DisplayAlert("Aviso", "Debes Ingresar una Direccion", "Ok");
            }
            else
            {
                var datos = new Datos
                {
                    d1 = nomb.Text,
                    d2 = apel.Text,
                    d3 = Convert.ToInt32(edad.Text),
                    d4 = dire.Text
                };

                var inf = new Informacion(); inf.BindingContext = datos; await Navigation.PushAsync(inf);
            }

        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            nomb.Text = null;
            apel.Text = null;
            edad.Text = null;
            dire.Text = null;
        }
    }
}
