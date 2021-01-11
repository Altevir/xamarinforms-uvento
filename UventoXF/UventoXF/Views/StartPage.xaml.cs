using UventoXF.ViewModels;
using Xamarin.Forms;

namespace UventoXF.Views
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            BindingContext = new StartPageViewModel(Navigation);
        }
    }
}
