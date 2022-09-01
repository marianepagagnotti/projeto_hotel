using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using projeto_hotel.Model;


namespace projeto_hotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroHospedagem : ContentPage
    {
        App PropriedadesApp;
        public CadastroHospedagem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
            PropriedadesApp = (App)Application.Current;

            

            pck_suite.ItemsSource = PropriedadesApp.lista_suites;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(4);

            dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(4).AddDays(1);

        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtpck_checkout.MinimumDate = elemento.Date.AddDays(1);
            dtpck_checkout.MaximumDate = elemento.Date.AddMonths(4).AddDays(1);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CalculoHospedagem()
                {
                    BindingContext = new Hospedagem()
                    {
                        QntAdultos = Convert.ToInt32(lbl_qnt_adultos.Text),
                        QntCriancas = Convert.ToInt32(lbl_qnt_criancas.Text),
                        QuartoEscolhido = (Suite)pck_suite.SelectedItem,
                        DataCheckIn = dtpck_checkin.Date,
                        DataCheckOut = dtpck_checkout.Date
                    }
                });
            }
            catch (Exception ex)
            {
                DisplayAlert("Vixi", ex.Message, "OK");
            }
        }

        

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            bool confime = await DisplayAlert("Certeza?","Desconectar conta ?","Sim", "Não");
            if (confime)
            {
                App.Current.Properties.Remove("usuario_logado");
                App.Current.MainPage = new Login();
            }
        }
    }
}