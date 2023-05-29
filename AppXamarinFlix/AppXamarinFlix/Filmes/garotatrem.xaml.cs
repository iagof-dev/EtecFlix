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
    public partial class garotatrem : ContentPage
    {
        public garotatrem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);    
            logo.Source = ImageSource.FromResource("AppXamarinFlix.Img.logo.png");
            poster.Source = ImageSource.FromResource("AppXamarinFlix.Posters.garotatrem.jpg");
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<iframe width='400' height='300' frameborder='0' src='https://www.youtube.com/embed/kmQ1WcX425E?controls=0' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>";
            //visualizador.Source = htmlSource;
            sinopse.Text = "Arrasada por seu recente divórcio, Rachel vive fantasiando sobre um casal aparentemente perfeito que mora em uma casa pela qual seu trem passa todos os dias. Certo dia, ela presencia algo estranho e começa sua própria investigação.";
        }
    }
}