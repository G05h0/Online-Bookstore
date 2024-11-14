namespace BookstoreWebApp.Data.Models
{
    public class ApplicationUserBook
    {
        public Guid ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid BookId{ get; set; }

        public virtual Book Book { get; set; } = null!;
    }
}