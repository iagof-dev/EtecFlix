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
    public partial class FomeDePoder : ContentPage
    {
        public FomeDePoder()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("AppXamarinFlix.Posters.fomedepoder.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/8LvMLEZZGZs?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "O vendedor Ray Kroc descobre o restaurante de fast-food operado pelos irmãos McDonald no sul da Califórnia, no final dos anos 50. Impressionado com a velocidade da cozinha e com o potencial do empreendimento, o ambicioso comerciante faz de tudo para assumir o controle do negócio, criando um icônico e bilionário império.";
        }
    }
}