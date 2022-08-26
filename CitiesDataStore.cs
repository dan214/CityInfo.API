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
                Description = "City in the sun",
                PointOfInterests = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="Uhuru Park",
                        Description="Park"
                    },
                     new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="Uhuru Park",
                        Description="Park"
                    },
                }

        },
            new CityDto()
        {
            Id = 2,
                Name = "Mombasa",
                Description = "Ocean tides",
                PointOfInterests = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="Mombasa Park",
                        Description="Park"
                    },
                     new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="Mombasads Park",
                        Description="Park"
                    },
                }

        },
            new CityDto()
        {
            Id = 3,
                Name = "Kisumu",
                Description = "Samaki tu",
                PointOfInterests = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="kisumu Park",
                        Description="Park"
                    },
                     new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="parko",
                        Description="Park"
                    },
                }

        },
            new CityDto()
        {
            Id = 4,
                Name = "Paris",
                Description = "Eiffel tower",
                PointOfInterests = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="paris Park",
                        Description="Park"
                    },
                     new PointOfInterestDto()
                    {
                        Id= 2,
                        Name="eiffer Park",
                        Description="Park"
                    },
                }

        }
    };

        }

    }
}
