namespace HTDPlaces.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EventViewModel> Events { get; set; } = new List<EventViewModel>();
    }
}
