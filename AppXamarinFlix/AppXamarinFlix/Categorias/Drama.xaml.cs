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
    public partial class Drama : ContentPage
    {
        public Drama()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            btnFomeDePoder.Source = ImageSource.FromResource("AppXamarinFlix.Posters.fomedepoder.jpg");
            btnGarotatrem.Source = ImageSource.FromResource("AppXamarinFlix.Posters.garotatrem.jpg");
            btnCreed3.Source = ImageSource.FromResource("AppXamarinFlix.Posters.creed3.jpg");
            btnLenda43.Source = ImageSource.FromResource("AppXamarinFlix.Posters.lenda42.jpg");
        }

        private void btnFomeDePoder_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new FomeDePoder());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnGarotatrem_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new garotatrem());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnCreed3_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new creed3());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnLenda43_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new alenda42());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}