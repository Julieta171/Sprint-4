namespace MoviesSeries.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public string Description { get; set; }

    }


}