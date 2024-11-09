using BookstoreWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Data.Configuration
{
    public class AuthorBookConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder.HasKey(ab => new { ab.AuthorId, ab.BookId });

            builder
                .HasOne(ab => ab.Author)
                .WithMany(a => a.AuthorBooks)
                .HasForeignKey(ab => ab.AuthorId)
                .OnDelete(DeleteBehavior.NoAction); 

            builder
                .HasOne(ab => ab.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ab => ab.BookId)
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
