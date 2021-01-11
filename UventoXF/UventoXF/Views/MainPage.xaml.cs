using UventoXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UventoXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(Navigation);
            SetLayoutFrame();
            
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (sender is Frame frmHome && frmHome.StyleId.Equals("frameHome"))
                {
                    gridFrames.ColumnDefinitions[0].Width = GridLength.Star;
                    gridFrames.ColumnDefinitions[1].Width = GridLength.Auto;
                    gridFrames.ColumnDefinitions[2].Width = GridLength.Auto;
                    frmHome.Padding = new Thickness(22, 5);
                    frmHome.BackgroundColor = Color.FromHex("#102733");
                    lbHome.IsVisible = true;
                    lbHome.TextColor = Color.FromHex("#FFA700");
                    lbIconHome.TextColor = Color.FromHex("#FFA700");
                    frameSearch.Padding = new Thickness(0);
                    frameSearch.BackgroundColor = Color.Transparent;
                    lbSearch.IsVisible = false;
                    lbSearch.TextColor = Color.White;
                    lbIconSearch.TextColor = Color.White;
                    frameFavorite.Padding = new Thickness(0);
                    frameFavorite.BackgroundColor = Color.Transparent;
                    lbFavorite.IsVisible = false;
                    lbFavorite.TextColor = Color.White;
                    lbIconFavorite.TextColor = Color.White;
                }
                else if (sender is Frame frmSearch && frmSearch.StyleId.Equals("frameSearch"))
                {
                    gridFrames.ColumnDefinitions[0].Width = GridLength.Auto;
                    gridFrames.ColumnDefinitions[1].Width = GridLength.Star;
                    gridFrames.ColumnDefinitions[2].Width = GridLength.Auto;
                    frameHome.Padding = new Thickness(0);
                    frameHome.BackgroundColor = Color.Transparent;
                    lbHome.IsVisible = false;
                    lbHome.TextColor = Color.White;
                    lbIconHome.TextColor = Color.White;
                    frmSearch.Padding = new Thickness(22, 5);
                    frmSearch.BackgroundColor = Color.FromHex("#102733");
                    lbSearch.IsVisible = true;
                    lbSearch.TextColor = Color.FromHex("#FFA700");
                    lbIconSearch.TextColor = Color.FromHex("#FFA700");
                    frameFavorite.Padding = new Thickness(0);
                    frameFavorite.BackgroundColor = Color.Transparent;
                    lbFavorite.IsVisible = false;
                    lbFavorite.TextColor = Color.White;
                    lbIconFavorite.TextColor = Color.White;
                }
                else if (sender is Frame frmFavorite && frmFavorite.StyleId.Equals("frameFavorite"))
                {
                    gridFrames.ColumnDefinitions[0].Width = GridLength.Auto;
                    gridFrames.ColumnDefinitions[1].Width = GridLength.Auto;
                    gridFrames.ColumnDefinitions[2].Width = GridLength.Star;
                    frameHome.Padding = new Thickness(0);
                    frameHome.BackgroundColor = Color.Transparent;
                    lbHome.IsVisible = false;
                    lbHome.TextColor = Color.White;
                    lbIconHome.TextColor = Color.White;
                    frameSearch.Padding = new Thickness(0);
                    frameSearch.BackgroundColor = Color.Transparent;
                    lbSearch.IsVisible = false;
                    lbSearch.TextColor = Color.White;
                    lbIconSearch.TextColor = Color.White;
                    frmFavorite.Padding = new Thickness(22, 5);
                    frmFavorite.BackgroundColor = Color.FromHex("#102733");
                    lbFavorite.IsVisible = true;
                    lbFavorite.TextColor = Color.FromHex("#FFA700");
                    lbIconFavorite.TextColor = Color.FromHex("#FFA700");
                }
            });
        }

        private void SetLayoutFrame()
        {
            gridFrames.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Star });
            gridFrames.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            gridFrames.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            frameHome.Padding = new Thickness(22, 5);
            frameHome.BackgroundColor = Color.FromHex("#102733");
            lbHome.IsVisible = true;
            frameSearch.Padding = new Thickness(0);
            frameSearch.BackgroundColor = Color.Transparent;
            lbSearch.IsVisible = false;
            lbSearch.TextColor = Color.White;
            lbIconSearch.TextColor = Color.White;
            frameFavorite.Padding = new Thickness(0);
            frameFavorite.BackgroundColor = Color.Transparent;
            lbFavorite.IsVisible = false;
            lbFavorite.TextColor = Color.White;
            lbIconFavorite.TextColor = Color.White;
        }
    }
}