using AppXamarinFlix.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXamarinFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
        }

        private void cat_aventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void cat_drama_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void cat_terror_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Terror());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void cat_ficcientifica_Clicked(object sender, EventArgs e)
        {
            
        }

     

        private void cat_suspense_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_romance_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_nacional_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_guerra_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_documentario_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_animacao_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_infantil_Clicked(object sender, EventArgs e)
        {

        }

        private void cat_drama_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void cat_comedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Ok");
            }
        }
    }
}
