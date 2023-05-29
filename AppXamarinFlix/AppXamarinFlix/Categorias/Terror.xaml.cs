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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            btnNosferatu.Source = ImageSource.FromResource("AppXamarinFlix.Posters.nosferatu.jpg");
            btnItACoisa.Source = ImageSource.FromResource("AppXamarinFlix.Posters.itacoisa.jpg");
            btnAorfa.Source = ImageSource.FromResource("AppXamarinFlix.Posters.aorfao.jpg");
            btnaEntidade.Source = ImageSource.FromResource("AppXamarinFlix.Posters.aentidade.jpg");

        }

        private void btnNosferatu_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new NosferatuTheVampyre());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnItACoisa_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new itacoisa());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void btnaEntidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new aentidade());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
        private void btnAorfa_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new aorfa());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}