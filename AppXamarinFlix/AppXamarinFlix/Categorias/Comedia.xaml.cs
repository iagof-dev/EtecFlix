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
    public partial class Comedia : ContentPage
    {
        public Comedia()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            btnDeadpool.Source = ImageSource.FromResource("AppXamarinFlix.Posters.deadpool.jpg");
            btnBranquelas.Source = ImageSource.FromResource("AppXamarinFlix.Posters.asbranquelas.jpeg");
            btnSonic2.Source = ImageSource.FromResource("AppXamarinFlix.Posters.sonic2.jpg");
            btnHomemAranha.Source = ImageSource.FromResource("AppXamarinFlix.Posters.homemaranha.jpg");

        }

        private void btnDeadpool_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new DeadPool());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnBranquelas_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new asbranquelas());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnSonic2_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new sonic2());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnHomemAranha_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new homemaranha());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}