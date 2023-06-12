using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class alenda42 : ContentPage
    {
        public alenda42()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("AppXamarinFlix.Posters.lenda42.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/yZo3vTngJUU?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "Jackie Robinson é um jogador de baseball que disputa a liga nacional dos negros até ser recrutado por Branch Rickey, o executivo de um time que disputa a maior competição do esporte nos Estados Unidos. Rickey quer que Robinson seja o primeiro negro a disputar a Major League na era moderna, o que faz com que ambos tenham que enfrentar o racismo existente não apenas da torcida e da diretoria, mas também dentro dos campos.";
        }
    }
}