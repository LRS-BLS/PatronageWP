using PatronatWP.Common;
using PatronatWP.Entity;
using PatronatWP.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronatWP.ViewModel
{
    public class AddViewModel : BaseObservableObject
    {
        private NavigationService NavigationService = new NavigationService();
        private LocationService LocationService = new LocationService();

        private Location location = new Location();
        public Location Location
        {
            get 
            {
                return location;
            }
            set 
            {
                location = value;
                RaisePropertyChanged("Location");
            }
        }

        private RelayCommand addCommand = null;
        public RelayCommand AddCommand
        {
            get { 
                if(addCommand == null)
                {
                    addCommand = new RelayCommand(() => Add());
                }
                return addCommand;
            }
        }

        private async void Add()
        {
            await LocationService.Add(Location);
            Location = new Location();
            NavigationService.Navigate(typeof(ListPage));
        }
    }
}
