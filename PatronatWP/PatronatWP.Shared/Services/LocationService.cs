using Microsoft.WindowsAzure.MobileServices;
using PatronatWP.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PatronatWP
{
    class LocationService
    {
        public static MobileServiceClient MobileService = new MobileServiceClient(
            "https://patronatwp.azure-mobile.net/",
            "uUmwvehkLigKjTZAaXPgMeDQpMknrf85"
        );
        private static List<Location> locations = new List<Location>();

        public async Task Add(Entity.Location Location)
        {
             await MobileService.GetTable<Location>().InsertAsync(Location);
        }

        public async Task<List<Location>> GetLocations()
        {
            return await MobileService.GetTable<Location>().ToCollectionAsync().ContinueWith(t=> t.Result.ToList());
        }
    }
}
