using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTinyMvvMAndShell.Models;
using TestTinyMvvMAndShell.ViewModels;
using TestTinyMvvMAndShell.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestTinyMvvMAndShell.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}