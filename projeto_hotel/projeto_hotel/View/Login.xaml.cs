﻿using System;
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


            frm_login.BackgroundColor = Color.FromRgba(1, 1, 1, 0.15);

            txt_email.PlaceholderColor = Color.FromRgba(1, 1, 1, 0.3);
            txt_senha.PlaceholderColor = Color.FromRgba(1, 1, 1, 0.3);

            sim.Source = ImageSource.FromResource("projeto_hotel.imagens.sim.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}