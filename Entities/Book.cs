namespace AsSplitQueryDemo.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime PublishedDate { get; set; }

        public int WriterId { get; set; }

        public Writer Writer { get; set; }

        public List<Review> Reviews { get; set; } = new();

    }
}
