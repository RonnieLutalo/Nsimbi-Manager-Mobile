using NsimbiManagerMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace NsimbiManagerMobile.Views
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