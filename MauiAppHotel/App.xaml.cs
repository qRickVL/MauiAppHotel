
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Suite> ListaSuites = new List<Suite>
        {

            new Suite()
            {

                NomeSuite = "Suite Super Luxo",
                ValorAdulto = 110.0,
                ValorCrianca = 55.0

            },
            new Suite()
            {

                NomeSuite = "Suite Luxo",
                ValorAdulto = 80.0,
                ValorCrianca = 40.0

            },
            new Suite()
            {

                NomeSuite = "Suite Single",
                ValorAdulto = 50.0,
                ValorCrianca = 25.0

            },
            new Suite()
            {
                
                NomeSuite = "Suite Simples",
                ValorAdulto = 25.0,
                ValorCrianca = 12.5

            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UI.TelaInicial());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }

    }
}
