using Microsoft.AspNetCore.Identity;

namespace HTDPlaces.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<Event>? JoinedEvents { get; set; }
        public List<Event>? CreatedEvent { get; set; }
    }
}
