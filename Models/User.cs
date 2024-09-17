namespace ConvicartMvcWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Subscription { get; set; }
        public bool SubscriptionValid { get; set; }
        public int MobileNumber { get; set; }
    }
}