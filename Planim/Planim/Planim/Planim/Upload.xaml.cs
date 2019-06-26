using System;
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
        public Upload()
        {
            InitializeComponent();
        }
        private async void Addjuego(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new PopUpload());
        }



    }
}