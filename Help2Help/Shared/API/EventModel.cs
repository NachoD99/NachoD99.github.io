namespace Help2Help.Shared.API
{
    public class EventModel
    {
        public int Id { get; set; }
        public string EventTitle { get; set; } = string.Empty;
        public string EventDescription { get; set; } = string.Empty;
        public DateTime EventDateCreated { get; set; } 
        public string UserName { get; set; } = string.Empty;
        public string FatherCategory { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int StreetNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}