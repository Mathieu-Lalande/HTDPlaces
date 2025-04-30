namespace HTDPlaces.ViewModels
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string Creator { get; set; }
        public List<string> Participants { get; set; } = new List<string>();
        public string Category { get; set; }
        public int MaxParticipants { get; set; }
        public bool IsPrivate { get; set; }
    }
}
