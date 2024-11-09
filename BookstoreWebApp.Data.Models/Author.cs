namespace BookstoreWebApp.Data.Models
{
    public class Author
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; } = null!;

        public string Biography { get; set; } = null!;
    }
}