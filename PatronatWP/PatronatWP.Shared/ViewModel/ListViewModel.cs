using PatronatWP.Common;
using PatronatWP.Entity;
using PatronatWP.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronatWP.ViewModel
{
    public class ListViewModel : BaseObservableObject
    {
        private NavigationService NavigationService = new NavigationService();
        private LocationService LocationService = new LocationService();

        public ListViewModel()
        {
            LoadData();
        }

        private async void LoadData()
        {
            Locations = await LocationService.GetLocations();
        }

        private List<Location> locations = new List<Location>();
        public List<Location> Locations
        {
            get
            {
                return locations;
            }
            set
            {
                locations = value;
                RaisePropertyChanged("Locations");
            }
        }

        private RelayCommand addCommand = null;
        public RelayCommand AddCommand
        {
            get
            {
                if (addCommand == null)
                {
                    addCommand = new RelayCommand(() => Add());
                }
                return addCommand;
            }
        }

        private void Add()
        {
            NavigationService.Navigate(typeof(AddPage));
        }
    }
}
