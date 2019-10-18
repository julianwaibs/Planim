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
		public SignIn ()
		{
			InitializeComponent ();
            LLenarUsuario();
		}
        List<MadrijJson> list = new List<MadrijJson>();
        private void LLenarUsuario()
        {
           /* APIConexion conexion = new APIConexion();
            list = conexion.GetMadrijim();*/
        }

        private async void Iniciar(object sender, EventArgs args)
        {
           

            await Navigation.PushAsync(new TabbedPage1());

        }

    }
}