using ScireAcademico.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScireAcademico.Views
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