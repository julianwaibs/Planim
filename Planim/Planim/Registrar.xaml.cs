using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Planim;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registrar : ContentPage
	{
		public Registrar ()
		{
			InitializeComponent ();
            LlenarInstituciones();
		}
        private async void Registro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Principal());
        }
        private async void LlenarInstituciones()
        {
            Instituciones instituciones = new Instituciones();
            IList<Instituciones> inst;
            HttpClient cliente = new HttpClient();
            string url = "http://10.152.2.25:59449/api/instituciones";
            var resultado = await cliente.GetAsync(url);
            var json = resultado.Content.ReadAsStringAsync().Result;
            inst = Instituciones.FromJson(json);
            listaInstitucion.ItemsSource = instituciones.Instituciones1;
        }
	}
}