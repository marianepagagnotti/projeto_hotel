using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto_hotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            PropriedadesApp = (App)Application.Current;


            sim.Source = ImageSource.FromResource("projeto_hotel.imagens.hotel1.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {       
            string email = txt_email.Text;
            string senha = txt_senha.Text;

            string email_certo = "mariane@fernanda";
            string senha_certa = "08022006";

            if (email == email_certo && senha == senha_certa)
            {
                App.Current.Properties.Add("usuario_logado", email);
                App.Current.MainPage = new NavigationPage(new CadastroHospedagem());

                //Navigation.PushAsync(new ContratacaoHospedagem());
            }
            else
                DisplayAlert("Negado", "Usuário ou senha incorretos.", "OK");
                

        }
    }
}