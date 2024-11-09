using BookstoreWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static BookstoreWebApp.Common.EntityValidationConstants.AuthorEntityValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Data.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLenght);

            builder
                .Property(a => a.Biography)
                .IsRequired()
                .HasMaxLength(BiographyMaxLenght);

            builder
                .Property(a => a.ImageUrl);

        }
    }
}
