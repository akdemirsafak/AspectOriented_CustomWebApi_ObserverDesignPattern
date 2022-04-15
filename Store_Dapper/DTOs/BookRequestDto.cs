namespace Store_Dapper.DTOs
{
    public class BookRequestDto
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    
    }
}