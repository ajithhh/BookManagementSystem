using System.ComponentModel.DataAnnotations;

namespace BMS.Application.DTOs
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string? Genre { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }
    }
}