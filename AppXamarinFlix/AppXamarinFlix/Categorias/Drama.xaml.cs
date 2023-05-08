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
    }
}