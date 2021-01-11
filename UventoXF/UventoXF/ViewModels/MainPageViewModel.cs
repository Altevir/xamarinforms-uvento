using System;
using System.Collections.ObjectModel;
using System.Linq;
using UventoXF.Helpers;
using UventoXF.Models;
using UventoXF.ViewModel;
using Xamarin.Forms;

namespace UventoXF.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            EventTypes = new ObservableCollection<EventType>();
            EventItems = new ObservableCollection<EventItem>();
            Dates = new ObservableCollection<DateItem>();
            SelectDateCommand = new Command<DateItem>((model) => ExecuteSelectDateCommand(model));
            SelectEventTypeCommand = new Command<EventType>((model) => ExecuteSelectEventTypeCommand(model));
            loadEventTypes();
            loadEventItems();
            loadDates();
        }

        public Command SelectDateCommand { get; }
        public Command SelectEventTypeCommand { get; }
        public ObservableCollection<EventType> EventTypes { get; }
        public ObservableCollection<EventItem> EventItems { get; }
        public ObservableCollection<DateItem> Dates { get; }

        private DateItem _selectedDate;
        public DateItem SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        private EventType _selectedEventType;
        public EventType SelectedEventType
        {
            get => _selectedEventType;
            set => SetProperty(ref _selectedEventType, value);
        }

        private void loadEventTypes()
        {
            EventTypes.Add(new EventType()
            {
                name = "Concert",
                image = "mic.png",
                selected = true,
                backgroundColor = "#FCCD00",
                textColor = "#000000"
            });

            EventTypes.Add(new EventType()
            {
                name = "Sports",
                image = "ping_pong.png",
                backgroundColor = "#29404E",
                textColor = "#FFFFFF"
            });

            EventTypes.Add(new EventType()
            {
                name = "Education",
                image = "graduation.png",
                backgroundColor = "#29404E",
                textColor = "#FFFFFF"
            });
        }

        private void loadEventItems()
        {
            EventItems.Add(new EventItem()
            {
                title = "Sports Meet in Galaxy Field",
                date = "Jan 12, 2021",
                location = "Greenfields, Sector 42, Faridabad",
                image = "event1.png"
            });

            EventItems.Add(new EventItem()
            {
                title = "Art & Meet in Street Plaza",
                date = "Jan 12, 2021",
                location = "Galaxyfields, Sector 22, Faridabad",
                image = "event2.png"
            });

            EventItems.Add(new EventItem()
            {
                title = "Youth Music in Galleria",
                date = "Jan 12, 2021",
                location = "Greenfields, Sector 42, Faridabad",
                image = "event3.png"
            });
        }

        private void loadDates()
        {
            var dateInit = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var dateEnd = new DateTime(dateInit.Year, dateInit.Month, DateTime.DaysInMonth(dateInit.Year, dateInit.Month));

            for (int i = 1; i <= dateEnd.Day; i++)
            {
                Dates.Add(new DateItem()
                {
                    day = string.Format("{0:00}", i),
                    month = dateInit.ToString("MMM").FirstLetterUpperCase(),
                    dayWeek = new DateTime(dateInit.Year, dateInit.Month, i).DayOfWeek.ToString().Substring(0, 3),
                    selected = i == DateTime.Today.Day,
                    backgroundColor = i == DateTime.Today.Day ? "#FCCD00" : "Transparent",
                    textColor = i == DateTime.Today.Day ? "#000000" : "#FFFFFF",
                });
            }
        }

        private void ExecuteSelectDateCommand(DateItem model)
        {
            Dates.ToList().ForEach((item) =>
            {
                item.selected = false;
                item.backgroundColor = "Transparent";
                item.textColor = "#FFFFFF";
            });

            var index = Dates.ToList().FindIndex(p => p.day == model.day && p.dayWeek == model.dayWeek);
            if (index > -1)
            {
                Dates[index].backgroundColor = "#FCCD00";
                Dates[index].textColor = "#000000";
                Dates[index].selected = true;
            }
        }

        private void ExecuteSelectEventTypeCommand(EventType model)
        {
            EventTypes.ToList().ForEach((item) =>
            {
                item.selected = false;
                item.backgroundColor = "#29404E";
                item.textColor = "#FFFFFF";
            });

            var index = EventTypes.ToList().FindIndex(p => p.name == model.name);
            if (index > -1)
            {
                EventTypes[index].backgroundColor = "#FCCD00";
                EventTypes[index].textColor = "#000000";
                EventTypes[index].selected = true;
            }
        }
    }
}
