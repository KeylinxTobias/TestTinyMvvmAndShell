using System.ComponentModel;
using TestTinyMvvMAndShell.ViewModels;
using Xamarin.Forms;

namespace TestTinyMvvMAndShell.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}