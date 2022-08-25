using CityInfo.API.Models;
using System.Xml.Linq;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>() {
            new CityDto()
        {
            Id = 1,
                Name = "Nairobi",
                Description = "City in the sun"

        },
            new CityDto()
        {
            Id = 2,
                Name = "Mombasa",
                Description = "Ocean tides"

        },
            new CityDto()
        {
            Id = 3,
                Name = "Kisumu",
                Description = "Samaki tu"

        },
            new CityDto()
        {
            Id = 4,
                Name = "Paris",
                Description = "Eiffel tower"

        }
    };

        }

    }
}
