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
    public partial class NosferatuTheVampyre : ContentPage
    {
        public NosferatuTheVampyre()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("AppXamarinFlix.Posters.nosferatu.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/ZxlJxDr26mM?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "O corretor de imóveis Hutter precisa vender um castelo cujo proprietário é o excêntrico conde Graf Orlock. O conde, na verdade, é um vampiro milenar que espalha o terror na região de Bremen, na Alemanha e se interessa por Ellen, a mulher de Hutter.";
        }
    }
}