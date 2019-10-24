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
	public partial class SignIn : ContentPage
	{
        String Nombre;
        String Contra;
		public SignIn ()
		{
			InitializeComponent ();
           
		}
       
        private void LLenarUsuario()
        {                   
                APIConexion conexion = new APIConexion();
                Madrijim madrij = new Madrijim(0,Nombre,null,null,Contra,null,0);
                MadrijJson madrij1 = new MadrijJson();
                madrij1 = conexion.GetMadrij(madrij);
            if (madrij1 == null)
            {
                DisplayAlert("Alert", "Ingrese los datos correctamente", "Reintentar");
            }
        }
            private bool Validar()
            {

                if (Usuario.Text == null)
                {
                    DisplayAlert("Alert", "Ingrese Usuario", "Reintentar");
                    return false;
                }
                else { Nombre = Usuario.Text; }
                if (Contraseña.Text == null)
                {
                    DisplayAlert("Alert", "Ingrese Contraseña", "Reintentar");
                    return false;
                }
                else { Contra = Contraseña.Text; }
            return true;
            }
            private async void Iniciar(object sender, EventArgs args)
            {
            bool valido = Validar();
            if (valido)
            {               //Hacer que no entre
                LLenarUsuario();
                await Navigation.PushAsync(new TabbedPage1());
            }          
            }
        }

    }
