using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PatronatWP.Common
{
    public abstract class BaseObservableObject :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
