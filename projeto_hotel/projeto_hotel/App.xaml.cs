using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using projeto_hotel.Model;
using System.Collections.Generic;

namespace projeto_hotel
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
               Nome = "Luxo",
               DiariaDoAdulto = 150.0,
               DiariaDaCrianca = 75.0
            },
            new Suite()
            {
               Nome = "Executiva",
               DiariaDoAdulto = 100.0,
               DiariaDaCrianca = 50.0
            },
            new Suite()
            {
               Nome = "Normal",
               DiariaDoAdulto = 60.0,
               DiariaDaCrianca = 30.0
            }
        };

        
        public App()
        {
            InitializeComponent();

           //MainPage = new NavigationPage(new View.Login());

            if (Properties.ContainsKey("usuario_logado"))
            MainPage = new NavigationPage(new View.CadastroHospedagem());
            else
               MainPage = new NavigationPage(new View.Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
