namespace agricocw_ContactList.Models
{
    public class Contact
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Description { get; set; }
        public required string Photo { get; set; }
    }
}