using System;
using System.Collections.Generic;
using TestTinyMvvMAndShell.ViewModels;
using TestTinyMvvMAndShell.Views;
using Xamarin.Forms;

namespace TestTinyMvvMAndShell
{
    public partial class AppShell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
