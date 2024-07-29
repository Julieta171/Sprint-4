namespace MoviesSeries.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public string Description { get; set; }
    }
}