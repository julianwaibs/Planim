using Rg.Plugins.Popup.Pages;
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
	public partial class PopUpload : PopupPage
	{
		public PopUpload (string Nombre,string Explicacion,int Cant, int Edad)
		{
			InitializeComponent ();
            nombre.Text = Nombre;
            explicacion.Text = Explicacion;
            edad.Text = "La edad recomendada de este juego: " + Edad;
            cant.Text = "La cantidad de chicxs recomendados: " + Cant;
        }
	}
}