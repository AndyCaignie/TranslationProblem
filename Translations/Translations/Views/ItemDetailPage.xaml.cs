using System.ComponentModel;
using Translations.ViewModels;
using Xamarin.Forms;

namespace Translations.Views
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