namespace BookstoreWebApp.Data.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Biography { get; set; } = null!;
    }
}