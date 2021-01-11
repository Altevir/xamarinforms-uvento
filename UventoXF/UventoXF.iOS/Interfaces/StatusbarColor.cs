using UIKit;
using UventoXF.Interfaces;
using UventoXF.iOS.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(StatusbarColor))]
namespace UventoXF.iOS.Interfaces
{
    public class StatusbarColor : IStatusbarColor
    {
        public void ChangeStatusbarColor()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var currentUIViewController = GetCurrentViewController();
                UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);
                currentUIViewController.SetNeedsStatusBarAppearanceUpdate();
            });
        }

        UIViewController GetCurrentViewController()
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var vc = window.RootViewController;
            while (vc.PresentedViewController != null)
                vc = vc.PresentedViewController;
            return vc;
        }
    }
}