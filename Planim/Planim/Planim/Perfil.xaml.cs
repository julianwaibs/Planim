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
		public Perfil ()
		{
			InitializeComponent ();
            LlenarPerfil();
        }

        private void LlenarPerfil()
        {
            MadrijJson madrij = new MadrijJson();
            Usuario.Text = "Bienvenido " + madrij.Nombre;
        }
    }
}