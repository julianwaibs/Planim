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
            InitializeComponent();
            LlenarInstituciones();
            
		}
        string Nombre;
        string Apellido;
        string Mail;
        string Contraseña;
        string Institut;
        private async void Registro(object sender, EventArgs args)
        {
           bool valido=Validar();
            if (valido) {
                CargarMadrij();
            await Navigation.PushAsync(new Principal());
            }

        }
        public void CargarMadrij()
        {
            Madrijim madrijim = new Madrijim(Nombre, Apellido,Mail,Contraseña,Institut);
        }
        private bool Validar()
        {
            
            if (NombreMadrij.Text==null)
            {
                DisplayAlert("Alert", "Ingrese Nombre", "Reintentar");
                return false;
            }
            else { Nombre = NombreMadrij.Text; }
            
            if (ApellidoMadrij.Text==null)
            {
                DisplayAlert("Alert", "Ingrese Apellido", "Reintentar");
                return false;
            }
            else { Apellido = ApellidoMadrij.Text; }
            
            if (ApellidoMadrij.Text==null)
            {
                DisplayAlert("Alert", "Ingrese Mail", "Reintentar");
                return false;
            }
            else { Mail = MailMadrij.Text; }
            
            if (ContraseñaMadrij.Text == ConfirContraseña.Text)
            {
                Contraseña = ContraseñaMadrij.Text;
            }
            
            else
            {
                DisplayAlert("Alert", "Diferente Contraseña", "Reintentar");
                return false;
            }
            
            if (Pickinstitucion.SelectedItem == null)
            {
                DisplayAlert("Alert", "Seleccione una institucion", "Reintentar");
                return false;
            }
            else { Institut = Pickinstitucion.SelectedItem.ToString(); }

            return true;

        }
        public async void LlenarInstituciones()
        {
            Instituciones instituciones = new Instituciones();
            IList<Instituciones> inst = new List<Instituciones>();
            HttpClient cliente = new HttpClient();
            string url = "http://10.152.2.25:59449/api/instituciones";
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