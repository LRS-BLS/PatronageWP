using PatronatWP.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronatWP.Entity
{
    public class Location : BaseObservableObject
    {
        public string Id { get; set; }

        private string name;
        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        private double lat;
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                RaisePropertyChanged("Lat");
            }
        }

        private double lon;
        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                RaisePropertyChanged("Lon");
            }
        }

        public override string ToString()
        {
            return Name + ", Lat:" + Lat + ", Lon: " + Lon;
        }
    }
}
