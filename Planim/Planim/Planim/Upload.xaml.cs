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
        List<int> listaid = new List<int>();
        List<ClaseJuego> eljue=new List<ClaseJuego>();
        string NombreJuego;
        int CantidadChi;
        int Promedioedad;
        public Upload()
        {
            InitializeComponent();
            Application.Current.Properties["Juegos"] = null;
        }

        public Upload(bool A)
        { 
            InitializeComponent();
            BusquedaxID();
            JuegosSeleccionados();
        }
        
        private void BusquedaxID()
        {
            listaid = (List<int>)Application.Current.Properties["Juegos"];
            APIConexion conexion = new APIConexion();         
            eljue = conexion.GetJuegosxID(listaid);            
        }

        private async void Addjuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juego());
        }

        private async void AddActividad(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (valido)
            {
                CargarActividad(); 
                await Navigation.PushAsync(new Upload());
            }
        }

        private void CargarActividad()
        {
            int idMadrij;
            idMadrij = Idmadrij();
            NuevaActividad nuevaActividad = new NuevaActividad(0, 0,0,NombreJuego,listaid, CantidadChi,Promedioedad, idMadrij);          
            APIConexion aPIConexion = new APIConexion();
            aPIConexion.InsertActividad(nuevaActividad);
        }

        private int Idmadrij()
        {   int IDM;
            MadrijJson madrij = new MadrijJson();
            madrij = (MadrijJson)Application.Current.Properties["Madrij"];
            IDM=Convert.ToInt32(madrij.IdMadrij);
            return IDM; 
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
            promedio();
           return true;
        }
         
        private void promedio()
        {
            int Prom = 0;
            for (int i = 0; i < eljue.Count; i++)
            {
                Prom = Prom + Convert.ToInt32(eljue[i].EdadRecomendada);

            }
            Promedioedad = Prom / eljue.Count;
        }

        List<string> misjuegos = new List<string>();
        public void JuegosSeleccionados()
        {
         
          ListaJuegos.ItemsSource = eljue;
            
        }

        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushPopupAsync (new PopUpload(clase.Nombre, expli, cant, edad));
        }
    }
}