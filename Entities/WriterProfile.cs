namespace AsSplitQueryDemo.Entities
{
    public class WriterProfile
    {
        public int Id { get; set; }

        public string Bio { get; set; }

        public string Website { get; set; }

        public int WriterId { get; set; }

        public Writer Writer { get; set; }
    }
}
