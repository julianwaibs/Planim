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
	public partial class Perfil : ContentPage
	{
        Instituciones Instituciones = new Instituciones();
		public Perfil ()
		{
			InitializeComponent ();
            LlenarPerfil();
        }

        private void LlenarPerfil()
        {
            MadrijJson madrij = new MadrijJson();            
            madrij =(MadrijJson) Application.Current.Properties["Madrij"];
            Usuario.Text = "Bienvenido " + madrij.Nombre;
          //  ObtenerInstitucion();
            Institucion.Text = "Su institucion es "; //ObtenerInstitucion();

        }
         private void ObtenerInstitucion()
        {
            
        }   
    }
}