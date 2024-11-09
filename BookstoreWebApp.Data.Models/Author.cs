namespace BookstoreWebApp.Data.Models
{
    public class Author
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; } = null!;

        public string Biography { get; set; } = null!;

        public string ImageUrl { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; } 
            = new HashSet<AuthorBook>();
    }
}