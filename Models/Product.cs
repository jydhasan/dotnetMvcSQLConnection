using System.ComponentModel.DataAnnotations;

namespace dotnetMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public decimal Price { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

    }
}
