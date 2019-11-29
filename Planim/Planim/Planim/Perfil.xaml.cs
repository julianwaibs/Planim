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
            int id = Convert.ToInt32(madrij.IdInstitucion);
            string institucion= ObtenerInstitucion(id);
            Institucion.Text = "Institucion "+institucion; //ObtenerInstitucion();
            
        }
        private string ObtenerInstitucion(int id)
        {
            APIConexion aPI = new APIConexion();
           Instituciones   = aPI.ObtenerInstitucionxid(id);
            string Instit = Instituciones.Instituciones1;
            return Instit;
        }   
    }
}