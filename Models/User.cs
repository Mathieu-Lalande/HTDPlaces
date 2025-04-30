using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace HTDPlaces.Models
{
    public class User : IdentityUser
    {
        public List<Event>? CreatedEvent { get; set; }
        public List<Event>? JoinedEvents { get; set; }
    }
}
