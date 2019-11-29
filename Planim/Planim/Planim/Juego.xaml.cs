using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planim;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juego : ContentPage
    {
        List<ClaseJuego> JuegoSele = new List<ClaseJuego>();
        int id;
        public Juego()
        {
            InitializeComponent();
            CargarJuegos();

        }

        private void CargarJuegos()
        {
            List<ClaseJuego> ListaJuego = new List<ClaseJuego>();
            APIConexion aPI = new APIConexion();
            ListaJuego = aPI.GetJuegos();
            ListaJuegos.ItemsSource = ListaJuego;
        }

        private async void AddJuego(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AgregarJuego());
        }
        public void JuegoSeleccion(object sender, SelectedItemChangedEventArgs e)
        {
            var clase = e.SelectedItem as ClaseJuego;
            id = Convert.ToInt32(clase.IdJuego);

        }
        public void JuegoTap(object sender, ItemTappedEventArgs e)
        {
            var clase = e.Item as ClaseJuego;
            int id = Convert.ToInt32(clase.IdJuego);
            int edad = Convert.ToInt32(clase.EdadRecomendada);
            int cant = Convert.ToInt32(clase.CantNiñosRecom);
            string expli = clase.Explicacion;
            Navigation.PushAsync(new InfoJuego(id,clase.Nombre, expli, cant, edad));
        }
        private void MiJuego(object sender, EventArgs args)
        {
            List<int> listaid = new List<int>();
            try
            {
                if (Application.Current.Properties["Juegos"] == null)
                {
                    listaid.Add(id);
                    Application.Current.Properties["Juegos"] = listaid;
                    Navigation.PushAsync(new Upload(true));
                }
                else
                {
                    listaid = (List<int>)Application.Current.Properties["Juegos"];
                    listaid.Add(id);
                    Application.Current.Properties["Juegos"] = listaid;
                    Navigation.PushAsync(new Upload(true));
                }
            
            }catch(Exception e)
            {

            }
                         
        }

    }
}
