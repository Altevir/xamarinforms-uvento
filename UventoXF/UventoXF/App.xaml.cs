using UventoXF.Interfaces;
using UventoXF.Views;
using Xamarin.Forms;

namespace UventoXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());

            if (Device.RuntimePlatform == Device.iOS)
                DependencyService.Get<IStatusbarColor>().ChangeStatusbarColor();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
