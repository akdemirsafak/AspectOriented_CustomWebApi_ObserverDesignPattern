namespace Store_Dapper.DTOs
{
    public class CustomerRequestDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public decimal Balance { get; set; }
    }
}