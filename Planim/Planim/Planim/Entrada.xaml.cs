using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Planim
{
    public partial class Entrada  : ContentPage
    {
        public Entrada()
        {
            InitializeComponent();
        }
       private async void IniciarSesion(object sender,EventArgs args)
        {
             await Navigation.PushAsync(new SignIn());
        }
        async void Registrarse(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Registrar());
        }

    }
}
