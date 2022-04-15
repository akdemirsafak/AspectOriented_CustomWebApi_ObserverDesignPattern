namespace Store_Dapper.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? LastName { get; set; }
        public decimal Balance { get; set; }
        
        public List<Book> Books { get; set; }
        
        

    }
}