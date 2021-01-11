using System.Collections.ObjectModel;
using UventoXF.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UventoXF.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEventTypesView : ContentView
    {
        public ObservableCollection<EventType> ItemsSource { get; set; }

        public static readonly BindableProperty ItemsSourceProperty =
           BindableProperty
           .Create(
               propertyName: "ItemsSource",
               returnType: typeof(ObservableCollection<EventType>),
               declaringType: typeof(ListEventTypesView),
               defaultValue: null,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: ItemsSourcePropertyChanged);

        public ListEventTypesView()
        {
            InitializeComponent();
        }

        private static void ItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (ListEventTypesView)bindable;
            control.listEvents.ItemsSource = newValue as ObservableCollection<EventType>;
        }
    }
}