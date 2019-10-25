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
		public Principal ()
		{
            
            InitializeComponent ();
            TraerActividades();
		}
        List<Actividad> aa = new List<Actividad>();
        private void TraerActividades()
        {
            APIConexion api = new APIConexion();
            aa = api.GetActividades();
            ListaActividades.ItemsSource = aa;
        }

        /*private async void Subir(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Upload());          
        }

        private async void MisActividades(object sender, EventArgs args)
        {
            
            await Navigation.PushAsync(new Peula());
            
            
        }*/
    }
}