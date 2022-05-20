using System.ComponentModel.DataAnnotations;

namespace EShoppingZone.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
}
