
namespace MvcMovie.Models
{

    public class CountriesName
    {


        public required string Common { get; set; }
        public required string Official { get; set; }

    }

    public class Countries
    {

        public required CountriesName Name { get; set; }
        public required string[] Capital { get; set; }
    }
}