using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HTDPlaces.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Location { get; set; }

        public User Creator { get; set; }

        public Category Category { get; set; }

        public List<User>? Participants { get; set; }
    }
}
