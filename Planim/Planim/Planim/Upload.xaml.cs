﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;

namespace Planim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Upload : ContentPage
    {
        List<ClaseJuego> eljue=new List<ClaseJuego>();
        string NombreJuego;
        int CantidadChi;
        public Upload()
        {
            InitializeComponent();
            Application.Current.Properties["Juegos"] = null;
        }
            public Upload(bool a)
        { 
            InitializeComponent();
            BusquedaxID();
            JuegosSeleccionados();
        }

        private void BusquedaxID()
        {
            List<int> listaid = new List<int>();
            listaid=(List<int>) Application.Current.Properties["Juegos"];
            ClaseJuego objetoJuego = new ClaseJuego();
            APIConexion conexion = new APIConexion(); 
            eljue = conexion.GetJuegosxID(listaid);
            
        }

        private async void Addjuego(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Juego());
        }
        private async void AddActividad(object sender, EventArgs e)
        {
            bool valido = Validar();
            if (valido)
            {
                CargarActividad();
                await Navigation.PushAsync(new Principal());
            }
        }

        private void CargarActividad()
        {
            NuevaActividad nuevaActividad = new NuevaActividad(0, 0,/*agregar parametros*/);
        }

        private bool Validar()
        {
            if (Nombreact.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Nombre", "Reintentar");
                return false;
            }
            else { NombreJuego = Nombreact.Text; }
            if (cantchicos.Text == null)
            {
                DisplayAlert("Alert", "Ingrese Cantidad", "Reintentar");
                return false;
            }
            else { CantidadChi = Convert.ToInt32(cantchicos.Text); }
            return true;
        }

        List<string> misjuegos = new List<string>();
        public void JuegosSeleccionados()
        {
         
          ListaJuegos.ItemsSource = eljue;
            
        }
        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushPopupAsync (new PopUpload(clase.Nombre, expli, cant, edad));
        }
    }
}