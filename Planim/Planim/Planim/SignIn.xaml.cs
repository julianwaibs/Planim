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
         MadrijJson madrij1 = new MadrijJson();
        private bool LLenarUsuario()
        {                   
                APIConexion conexion = new APIConexion();
                Madrijim madrij = new Madrijim(0,Nombre,null,null,Contra,null,0);
              
                madrij1 = conexion.GetMadrij(madrij);

            if (madrij1 == null)
            {
                DisplayAlert("Alert", "Ingrese los datos correctamente", "Reintentar");
                return false;
            }
            else
            {
                Application.Current.Properties["Madrij"] = madrij1;
            }
            return true;
        }
            private bool Validar()
            {
            bool inicio=false;
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
                inicio=LLenarUsuario();

            return inicio;
            }
            private async void Iniciar(object sender, EventArgs args)
            {
                bool valido = Validar();
                if (valido)
                {                       
                    await Navigation.PushAsync(new TabbedPage1());
                }          
            }
        }

    }
