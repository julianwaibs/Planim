﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planim
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal ()
		{
			InitializeComponent ();
		}
       
        private async void Subir(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Upload());
        }
        private async void MisActividades(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Peula());
        }
    }
}