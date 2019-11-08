using Rg.Plugins.Popup.Extensions;
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
	public partial class InfoActividad : ContentPage
	{
		public InfoActividad (string Nombre,int tiempo,int Cant,int Edad,List<int>idj)
		{
            InitializeComponent();
            CargarJuegos(idj);
            nombre.Text = Nombre;
            explicacion.Text = "El tiempo es"+tiempo;
            edad.Text = "La edad recomendada de este juego: " + Edad;
            cant.Text = "La cantidad de chicxs recomendados: " + Cant; 
		}

        private void CargarJuegos(List<int>idj)
        {
            List<ClaseJuego> ListaJuego = new List<ClaseJuego>();
            APIConexion aPI = new APIConexion();
            ListaJuego = aPI.GetJuegosxID(idj);
            ListaJuegos.ItemsSource = ListaJuego;
        }
        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushPopupAsync(new PopUpload(clase.Nombre, expli, cant, edad));
        }
    }
}