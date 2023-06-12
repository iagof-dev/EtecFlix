using AppXamarinFlix.Filmes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
                NavigationPage.SetHasNavigationBar(this, false);
                logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
                btnGatoDeBotas.Source = ImageSource.FromResource("AppXamarinFlix.Posters.gatodebotas.jpg");
                btnMario.Source = ImageSource.FromResource("AppXamarinFlix.Posters.supermariobros.jpg");
                btnShazam.Source = ImageSource.FromResource("AppXamarinFlix.Posters.shazam.jpg");
            btnFrozen.Source = ImageSource.FromResource("AppXamarinFlix.Posters.frozen.jpg");
        }

        private void btnGatoDeBotas_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new GatoDeBotas2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnMario_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new supermariobros());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnShazam_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new shazam());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnFrozen_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new frozen());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}