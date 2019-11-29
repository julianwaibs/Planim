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
	public partial class ModificarAct : ContentPage
	{
        APIConexion API = new APIConexion();
        Actividad Actividad = new Actividad();
        string NombreJuego;
        int CantidadChi;
        int Promedioedad=5;
        List<int> idJuegos = new List<int>();
        List<ClaseJuego> eljue = new List<ClaseJuego>();
        

        public ModificarAct (int id)
		{
			InitializeComponent ();
            Application.Current.Properties["Juegos"] = null;
            buscaractividad(id);
            MostrarData();
            IDA = id;
		}
        public void buscaractividad(int id)
        {
            Actividad = API.GetActividadxid(id);
        }
        int IDA;

        private void AddActividad(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (valido)
            {
                CargarActividad();
                Navigation.PushAsync(new InfoActividad(IDA,NombreJuego, CantidadChi,0, Promedioedad,idJuegos));
            }
        }

        private void CargarActividad()
        {
            int idMadrij;
            idMadrij = Idmadrij();
            NuevaActividad nuevaActividad = new NuevaActividad(IDA, 0, 0, NombreJuego, idJuegos, CantidadChi, Promedioedad, idMadrij);
            APIConexion aPIConexion = new APIConexion();
            aPIConexion.ModificarActividad(nuevaActividad);
        }

        private int Idmadrij()
        {
            int IDM;
            MadrijJson madrij = new MadrijJson();
            madrij = (MadrijJson)Application.Current.Properties["Madrij"];
            IDM = Convert.ToInt32(madrij.IdMadrij);
            return IDM;
        }


        public void Refrescar(object sender, EventArgs e)
        {
            int idb = (int)Application.Current.Properties["Juegos"];
            for (int i = 0; i < idJuegos.Count; i++)
            {
                if (idb == idJuegos[i])
                {
                    idJuegos.RemoveAt(i);
                }
            }
            ListaJuegos.IsRefreshing = false;
        }

        private bool Validar()
        {
            if (Nombreact.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Nombre", "Reintentar");
                return false;
            }
            else { NombreJuego = Nombreact.Text; }
            if (cantchicos.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Cantidad", "Reintentar");
                return false;
            }
            else { CantidadChi = Convert.ToInt32(cantchicos.Text); }
            
            return true;
        }
 

        private async void Addjuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juego());
        }

        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int id = Convert.ToInt32(clase.IdJuego);
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushAsync(new InfoJuego(id,clase.Nombre, expli, cant, edad));
        }

        private void MostrarData()
        {           
            Nombreact.Text = Actividad.Nombre;
            cantchicos.Text = Actividad.CantNiñosRecom.ToString();
            idJuegos = Actividad.idJuegos;
            eljue = API.GetJuegosxID(idJuegos);
            ListaJuegos.ItemsSource = eljue;
        }
	}
}