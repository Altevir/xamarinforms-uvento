using UventoXF.ViewModel;

namespace UventoXF.Models
{
    public class DateItem : BaseViewModel
    {
        public string month { get; set; }
        public string day { get; set; }
        public string dayWeek { get; set; }
        public bool selected { get; set; }

        private string _backgroundColor;
        public string backgroundColor
        {
            get => _backgroundColor;
            set => SetProperty(ref _backgroundColor, value);
        }

        private string _textColor;
        public string textColor
        {
            get => _textColor;
            set => SetProperty(ref _textColor, value);
        }
    }
}
