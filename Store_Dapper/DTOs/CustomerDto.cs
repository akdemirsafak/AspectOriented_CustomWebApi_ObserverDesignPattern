namespace Store_Dapper.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public decimal Balance { get; set; }
        
    }
}