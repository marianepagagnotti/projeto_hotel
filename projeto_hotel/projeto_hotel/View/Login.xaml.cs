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
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


            

            sim.Source = ImageSource.FromResource("projeto_hotel.imagens.hotel1.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}