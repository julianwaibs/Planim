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
		public Peula ()
		{
			InitializeComponent ();
            TraerActividades();
        }
        List<Actividad> actividades = new List<Actividad>();
        private void TraerActividades()
        {
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
    }
}