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
	public partial class Registrar : ContentPage
	{
		public Registrar ()
		{
			InitializeComponent ();

		}
        private async void Registro(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Principal());
           
        }
	}
}