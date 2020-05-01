using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFCarCard.ViewModels;

namespace XFCarCard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();

            BindingContext = new BaseViewModel();
        }
    }
}