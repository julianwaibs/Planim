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
	public partial class InfoJuego : ContentPage
	{
        List<ClaseJuego> ListaJuego = new List<ClaseJuego>();

        public InfoJuego (string Nombre,string Explicacion, int Cant,int Edad)
		{
			InitializeComponent ();
            //BusquedaxID(IdJuego);
            nombre.Text = Nombre;
            explicacion.Text = Explicacion;
            edad.Text = "La edad recomendada de este juego: " + Edad;
            cant.Text = "La cantidad de chicxs recomendados: " + Cant;
        }

      /*  private void BusquedaxID(int Idjuego)
        {
            ClaseJuego objetoJuego = new ClaseJuego();
            APIConexion conexion = new APIConexion();
            objetoJuego = conexion.GetJuegosxID(Idjuego);
            ListaJuego.Add(objetoJuego);
        }*/

    }
}