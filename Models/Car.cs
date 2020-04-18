
namespace Rental.Models 
{
    public class Car
    {
        public int Id {get; set;}

        public string Make {get; set;}

        public string Model {get; set;}
        
        public int Year {get; set;}

        public decimal DailyPrice {get; set;}

        public int Cyls {get; set;}

        public int Passegers {get; set;}

        public int Type {get; set;}

        public string ImageUrl {get; set;}

        public string Description {get; set;}

        public string FuelType {get; set;}
    }
}