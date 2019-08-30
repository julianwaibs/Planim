using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planim;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Juego : ContentPage
	{
        List<string> JuegoSele = new List<string>();
		public Juego ()
		{
			InitializeComponent ();
            CargarJuegos();
            
		}

        private void CargarJuegos()
        {
            List<ClaseJuego> ListaJuego = new List<ClaseJuego>();
            APIConexion aPI = new APIConexion();
            ListaJuego = aPI.GetJuegos();

            /*Juegos.Add("Juego1");
            Juegos.Add("Juego2");*/
            ListaJuegos.ItemsSource = ListaJuego;
        }

        private async void AddJuego(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AgregarJuego());
        }
        private void MiJuego(object sender, EventArgs args)
        {
            string JuegoSeles = ListaJuegos.SelectedItem.ToString();
            //Upload upload = new Upload();
            // upload.JuegosSeleccionados(JuegoSeles); 
            JuegoSele.Add(JuegoSeles);
            Navigation.PushAsync(new Upload(JuegoSele));
        }

    }
}