using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AgregarJuego : ContentPage
	{
        string NombreJuego;
        string ExpliJuego;
        int iAmbi;
        string sAmbi;
        int CantidadChi;
        int EdadReco;

        public AgregarJuego ()
		{
			InitializeComponent ();
            LLenarSalidas();
		}
        List<string> juegonuevo = new List<string>();
        public void LLenarSalidas()
        {
            List<string> ListaAmbitos = new List<string>();
            ListaAmbitos.Add("Adentro");
            ListaAmbitos.Add("Afuera");
            Ambito.ItemsSource = ListaAmbitos;

        }
   
        private async void Juegonuevo(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (valido)
            {
                CargarJuego();
                await Navigation.PushAsync(new Upload());
            }

        }
        private bool Validar()
        {

            if (Nombrejuego.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Nombre", "Reintentar");
                return false;
            }
            else { NombreJuego = Nombrejuego.Text; }

            if (Explicacion.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Explicacion", "Reintentar");
                return false;
            }
            else { ExpliJuego = Explicacion.Text; }

            if (Cant.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Cantidad", "Reintentar");
                return false;
            }
            else { CantidadChi =Convert.ToInt32(Cant.Text); }

            if (Edad.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Edad", "Reintentar");
                return false;
            }
            else { EdadReco = Convert.ToInt32(Edad.Text); }

            if (Ambito.SelectedItem == null)
            {
                DisplayAlert("Alert", "Seleccione un Ambito", "Reintentar");
                return false;
            }
            else
            {
                sAmbi= Ambito.SelectedItem.ToString();
                if (sAmbi == "Adentro")
                {
                    iAmbi = 2;
                }
                else
                {
                    iAmbi = 1;
                }
                
            }
            return true;
        }
        public void CargarJuego()
        {
            NuevoJuego newJuego = new NuevoJuego(0,NombreJuego,ExpliJuego,iAmbi,0,0,EdadReco,CantidadChi);
            APIConexion aPIConexion = new APIConexion();
            aPIConexion.InsertJuego(newJuego);
        }
    }
}