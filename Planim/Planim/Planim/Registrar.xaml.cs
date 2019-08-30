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
        int id;
        string Institut;
        Instituciones instituciones = new Instituciones();
        List<Instituciones> lista = new List<Instituciones>();

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
            Madrijim madrijim = new Madrijim(0, Nombre, Apellido, Mail, Contraseña,instituciones.Instituciones1, id);
            APIConexion aPIConexion = new APIConexion();
            aPIConexion.InsertMadrij(madrijim);
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
            
            if (MailMadrij.Text==null)
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
            else
            {
                
                Institut = Pickinstitucion.SelectedItem.ToString();
                int i = 0;
                System.Collections.IList list = lista;
                for (int i1 = 0; i1 < list.Count; i1++) {
                    Instituciones l = (Instituciones)list[i1];
                    if (lista[i].Instituciones1 == Institut)
                    {
                        id = Convert.ToInt16(lista[i].IdInstituciones);
                    }
                    i++;
                 }
            }
            return true;

        }




        public void LlenarInstituciones()
        {
            APIConexion aPI = new APIConexion();
            lista = aPI.GetInstituciones();
            Pickinstitucion.ItemsSource = lista;
        }
    }
}