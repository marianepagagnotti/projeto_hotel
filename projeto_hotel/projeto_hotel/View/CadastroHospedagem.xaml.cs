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
    public partial class CadastroHospedagem : ContentPage
    {
        public CadastroHospedagem()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtpck_checkout.MinimumDate = elemento.Date.AddDays(1);
            dtpck_checkout.MaximumDate = elemento.Date.AddMonths(6).AddDays(1);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}