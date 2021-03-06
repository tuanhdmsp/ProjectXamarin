﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafetyFirst
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CreateAccountPage());
        }

        private void SignInButton_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
