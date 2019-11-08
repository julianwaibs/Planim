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
	public partial class Principal : ContentPage
	{
        int idAct=0;
        APIConexion api = new APIConexion();
        public Principal ()
		{
            
            InitializeComponent ();
            TraerActividades();
		}
        List<Actividad> aa = new List<Actividad>();
        private void TraerActividades()
        {
            aa = api.GetActividades();
            ListaActividades.ItemsSource = aa;
        }
        public void ActividadTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as Actividad;
            int edad = Convert.ToInt32(clase.EdadRecom);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            int Tiempo = Convert.ToInt32(clase.TiempoTotal);
            List<int> idJuegos = new List<int>();
            idJuegos = clase.idJuegos;
            Navigation.PushAsync(new InfoActividad(clase.Nombre, Tiempo, cant, edad,idJuegos));
        }
        public void ActiSelec(object sender, SelectedItemChangedEventArgs e)
        {
            var clase = e.SelectedItem as Actividad;
            idAct = Convert.ToInt32(clase.IdActividad);
        }

        private void MiActi(object sender, EventArgs args)
        {
            if (idAct == 0) {
                DisplayAlert("Alert", "Seleccione actividad", "Reintentar");                
            }
            else { int IDM = Idmadrij();
            ActividadxMadrij actividadx = new ActividadxMadrij(0,IDM,idAct);
           api.InsertActividadxid(actividadx);               
            Navigation.PushAsync(new Peula());
            }
            
        }
        private int Idmadrij()
        {
            int IDM;
            MadrijJson madrij = new MadrijJson();
            madrij = (MadrijJson)Application.Current.Properties["Madrij"];
            IDM = Convert.ToInt32(madrij.IdMadrij);
            return IDM;
        }
    }
}