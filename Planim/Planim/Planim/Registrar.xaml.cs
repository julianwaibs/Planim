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
            try
            {
                LlenarInstituciones();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debugger.Break();

            }
		}
        private async void Registro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Principal());
        }
        public async void LlenarInstituciones()
        {
            Instituciones instituciones = new Instituciones();
            IList<Instituciones> inst = new List<Instituciones>();
            HttpClient cliente = new HttpClient();
            string url = "http://10.152.2.39:59449/api/instituciones";
           
                //var resultado = await cliente.GetAsync(url);
                var resultado = await cliente.GetAsync(url);
                var json = resultado.Content.ReadAsStringAsync().Result;
                inst = Instituciones.FromJson(json);
            int i = 0;
            List<String> List = new List<string>();
             foreach (Instituciones institu in inst)
              { 
                  List.Add(inst[i].Instituciones1.ToString());
                  i++;
              }
            Pickinstitucion.ItemsSource = List;
        }
    }
}