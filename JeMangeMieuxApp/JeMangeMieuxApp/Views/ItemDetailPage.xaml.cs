using JeMangeMieuxApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace JeMangeMieuxApp.Views
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