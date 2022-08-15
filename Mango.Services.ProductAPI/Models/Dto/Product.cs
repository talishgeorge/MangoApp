using System.ComponentModel.DataAnnotations;
//Products
namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int PoductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
