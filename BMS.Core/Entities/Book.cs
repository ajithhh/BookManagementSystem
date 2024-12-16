namespace BMS.Core.Entities
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Author { get; set; }
        public string? Genre { get; set; }
        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
