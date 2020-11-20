using System;
using System.ComponentModel;
using Foundation;

namespace Chart_GettingStarted
{
    public class ChartDataModel : INotifyPropertyChanged
    {
        string xValue;
        public string XValue
        {
            get
            {
                return xValue;
            }
            set
            {
                xValue = value;
                OnPropertyChanged("XValue");
            }
        }

        DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        double yValue;
        public double YValue
        {
            get
            {
                return yValue;
            }
            set
            {
                yValue = value;
                OnPropertyChanged("YValue");
            }

        }

        public ChartDataModel()
        {
        }

        //public ChartDataModel(double xValue, double yValue)
        //{
        //    XValue = xValue;
        //    YValue = yValue;
        //}

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
