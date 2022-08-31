using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto_hotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           //MainPage = new NavigationPage(new View.Login());

           // if (Properties.ContainsKey("usuario_logado"))
            MainPage = new NavigationPage(new View.CadastroHospedagem());
            //else
               //MainPage = new NavigationPage(new View.Login());
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
