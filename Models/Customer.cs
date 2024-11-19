namespace CustomerManagementWebApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // Non-nullable with default value
        public string Email { get; set; } = string.Empty;  // Non-nullable with default value
    }
}
