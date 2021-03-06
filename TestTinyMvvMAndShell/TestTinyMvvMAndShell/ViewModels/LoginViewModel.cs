﻿using System;
using System.Collections.Generic;
using System.Text;
using TestTinyMvvMAndShell.Views;
using TinyMvvm;
using Xamarin.Forms;

namespace TestTinyMvvMAndShell.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
