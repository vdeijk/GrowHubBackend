using System.Collections.Generic;
using Models.ViewModels;

namespace Models
{
    public static class LocationMockData
    {
        private static List<LocationItem> _locations = new List<LocationItem>
        {
            new LocationItem { Id = 1, Name = "North Field", Latitude = 52.0705, Longitude = 4.3007 },
            new LocationItem { Id = 2, Name = "South Orchard", Latitude = 52.3676, Longitude = 4.9041 },
            new LocationItem { Id = 3, Name = "East Greenhouse", Latitude = 51.9244, Longitude = 4.4777 }
        };

        public static IEnumerable<LocationItem> GetLocations()
        {
            return _locations;
        }

        public static LocationItem GetLocationById(int id)
        {
            return _locations.Find(location => location.Id == id);
        }

        public static void AddLocation(LocationItem location)
        {
            location.Id = _locations.Count > 0 ? _locations[^1].Id + 1 : 1;
            _locations.Add(location);
        }

        public static void UpdateLocation(int id, LocationItem updatedLocation)
        {
            var location = _locations.Find(l => l.Id == id);
            if (location != null)
            {
                location.Name = updatedLocation.Name;
                location.Latitude = updatedLocation.Latitude;
                location.Longitude = updatedLocation.Longitude;
            }
        }

        public static void DeleteLocation(int id)
        {
            _locations.RemoveAll(location => location.Id == id);
        }
    }
}