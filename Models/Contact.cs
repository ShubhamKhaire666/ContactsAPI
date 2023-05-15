namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid id { get; set; }
        
        public string FullName { get; set; }

        public string Address { get; set; }

        public long Phone { get; set; }

        public string Email { get; set; }
    }
}
