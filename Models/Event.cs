using System.ComponentModel;

namespace HTDPlaces.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public User? Creator { get; set; }
        public List<User>? Participants { get; set; }
    }

}
