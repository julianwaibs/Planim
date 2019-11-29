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
    public partial class Peula : ContentPage
    {

        public Peula()
        {
            InitializeComponent();
            TraerActividades();

        }
        List<Actividad> actividades = new List<Actividad>();

        public void Refrescar(object sender, EventArgs e)
        {
            TraerActividades();
            ListaActividades.IsRefreshing = false;
        }
        private void TraerActividades()
        {
            actividades.Clear();
            APIConexion api = new APIConexion();
            int id = Idmadrij();
            actividades = api.GetActividadesxIdMadrij(id);
            ListaActividades.ItemsSource = actividades;
        }
        
        private int Idmadrij()
        {
            int IDM;
            MadrijJson madrij = new MadrijJson();
            madrij = (MadrijJson)Application.Current.Properties["Madrij"];
            IDM = Convert.ToInt32(madrij.IdMadrij);
            return IDM;
        }
        public void ActividadTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as Actividad;
            int idact = Convert.ToInt32(clase.IdActividad);
            int edad = Convert.ToInt32(clase.EdadRecom);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            int Tiempo = Convert.ToInt32(clase.TiempoTotal);
            List<int> idJuegos = new List<int>();
            idJuegos = clase.idJuegos;
            Navigation.PushAsync(new InfoActividad(idact,clase.Nombre, Tiempo, cant, edad, idJuegos));
        }
    }
}