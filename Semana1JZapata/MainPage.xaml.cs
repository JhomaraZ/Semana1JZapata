using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana1JZapata
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private  void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string texto = txtMensaje.Text;
            string mensaje = "Hola" + texto;
            DisplayAlert("Este es un mensaje", mensaje, "ok");
        }

    }
}
