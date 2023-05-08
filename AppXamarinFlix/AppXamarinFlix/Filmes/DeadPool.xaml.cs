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
    public partial class DeadPool : ContentPage
    {
        public DeadPool()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);    
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("AppXamarinFlix.Posters.deadpool.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/Q9X-bAE8KTc?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "Wade Wilson é um ex-agente especial que passou a trabalhar como mercenário. Seu mundo é destruído quando um cientista maligno o tortura e o desfigura completamente. O experimento brutal transforma Wade em Deadpool, que ganha poderes especiais de cura e uma força aprimorada. Com a ajuda de aliados poderosos e um senso de humor mais desbocado e cínico do que nunca, o irreverente anti-herói usa habilidades e métodos violentos para se vingar do homem que quase acabou com a sua vida.";
        }
    }
}