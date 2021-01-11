using System.Collections.ObjectModel;
using UventoXF.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UventoXF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEventsView : ContentView
    {
        public ObservableCollection<EventItem> ItemsSource { get; set; }

        public static readonly BindableProperty ItemsSourceProperty =
           BindableProperty
           .Create(
               propertyName: "ItemsSource",
               returnType: typeof(ObservableCollection<EventItem>),
               declaringType: typeof(ListEventsView),
               defaultValue: null,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: ItemsSourcePropertyChanged);

        public ListEventsView()
        {
            InitializeComponent();
        }

        private static void ItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ListEventsView)bindable;
            control.listEvents.ItemsSource = newValue as ObservableCollection<EventItem>;
        }
    }
}