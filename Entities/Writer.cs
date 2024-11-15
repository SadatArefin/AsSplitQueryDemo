namespace AsSplitQueryDemo.Entities
{
    public class Writer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<Book> Books { get; set; } = new();

        public WriterProfile Profile { get; set; }
    }
}
