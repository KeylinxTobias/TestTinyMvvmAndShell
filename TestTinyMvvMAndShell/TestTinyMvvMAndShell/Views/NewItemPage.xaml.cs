using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestTinyMvvMAndShell.Models;
using TestTinyMvvMAndShell.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestTinyMvvMAndShell.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}