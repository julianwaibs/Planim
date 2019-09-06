using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;

namespace Planim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Upload : ContentPage
    {
        List<ClaseJuego> eljue=new List<ClaseJuego>();

            public Upload(){ InitializeComponent(); }

            public Upload(int Idjuego)
        { 
            InitializeComponent();
            BusquedaxID(Idjuego);
            JuegosSeleccionados();
        }

        private void BusquedaxID(int Idjuego)
        {
            ClaseJuego objetoJuego = new ClaseJuego();
            APIConexion conexion = new APIConexion(); 
            objetoJuego = conexion.GetJuegosxID(Idjuego);
            eljue.Add(objetoJuego);
        }

        private async void Addjuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juego());
        }
        List<string> misjuegos = new List<string>();
        public void JuegosSeleccionados()
        {
            ListaJuegos.ItemsSource = eljue;
        }
    }
}