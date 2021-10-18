using System;
using System.Collections.Generic;
using System.ComponentModel;
using Translations.Models;
using Translations.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Translations.Views
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