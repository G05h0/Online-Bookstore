using BookstoreWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookstoreWebApp.Common.EntityValidationConstants.BookEntityValidations;

namespace BookstoreWebApp.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLenght);


            builder
                .Property(b => b.Genre)
                .IsRequired()
                .HasMaxLength(GenreMaxLenght);

            builder
                .Property(b => b.Pages)
                .IsRequired()
                .HasMaxLength(PagesMaxLenght);

            builder
                .Property(b => b.ImageUrl);

            builder
                .Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLenght);

        }
    }
}
