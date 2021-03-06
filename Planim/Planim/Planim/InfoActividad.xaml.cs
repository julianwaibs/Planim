﻿using Rg.Plugins.Popup.Extensions;
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
	public partial class InfoActividad : ContentPage
	{
        int Id;
        List<int> Listuli = new List<int>();
		public InfoActividad (int id,string Nombre,int tiempo,int Cant,int Edad,List<int>idj)
		{
            InitializeComponent();
            Listuli = idj;
            CargarJuegos(Listuli);
            Id = id;
            nombre.Text = Nombre;
            explicacion.Text = "El tiempo es"+tiempo;
            edad.Text = "La edad recomendada de este juego: " + Edad;
            cant.Text = "La cantidad de chicxs recomendados: " + Cant; 
		}

        private void CargarJuegos(List<int>idj)
        {
            List<ClaseJuego> ListaJuego = new List<ClaseJuego>();
            APIConexion aPI = new APIConexion();
            ListaJuego = aPI.GetJuegosxID(idj);
            ListaJuegos.ItemsSource = ListaJuego;
        }

        APIConexion aPI = new APIConexion();

        public void Borrar(object sender, EventArgs e)
        {
            aPI.BorrarActividad(Id);
            Navigation.PushAsync(new Principal());
        }

        public void Modificar(object sender, EventArgs e)
        {           
            Navigation.PushAsync(new ModificarAct(Id));
        }

        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int id = Convert.ToInt32(clase.IdJuego);
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushPopupAsync(new PopUpload(clase.Nombre, expli, cant, edad));
        }

        public void Refrescar(object sender, EventArgs e)
        {
            int idb =(int) Application.Current.Properties["idJuegos"];
            for (int i = 0; i < Listuli.Count; i++)
            {
                if (idb == Listuli[i])
                {
                    Listuli.RemoveAt(i);
                }
            }
            ListaJuegos.IsRefreshing = false;
        }

        public void Principal(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Principal());
        }
    }
}