namespace Store_Dapper.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        
        
        
    }
}