using RadioPanel.Core;

namespace RadioPanel.Models
{
    public class RadioInformation : ObserveableObject
    {
        private double _com1;
        private double _com1Stby;
        private string _status;

        public double Com1
        {
            get => _com1;
            set
            {
                if (_com1 != value)
                {
                    _com1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Com1Stby
        {
            get => _com1Stby;
            set
            {
                if (_com1Stby != value)
                {
                    _com1Stby = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
