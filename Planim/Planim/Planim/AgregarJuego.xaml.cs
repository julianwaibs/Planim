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
	public partial class AgregarJuego : ContentPage
	{
		public AgregarJuego ()
		{
			InitializeComponent ();
		}
        List<string> juegonuevo = new List<string>();
        private void CrearJuego()
        {
            string Nombredeljuego;
            Nombredeljuego = Nombrejuego.Text.ToString();
            juegonuevo.Add(Nombredeljuego);
        }

        private void Juegonuevo(object sender, EventArgs e)
        {
            CrearJuego();
             Navigation.PushAsync(new Upload());
        }
    }
}