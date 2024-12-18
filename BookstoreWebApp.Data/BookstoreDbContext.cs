﻿using BookstoreWebApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Data
{
    public class BookstoreDbContext : IdentityDbContext<IdentityUser>
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
        : base(options) 
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<AuthorBook> AuthorBooks { get; set; } = null!;
        public virtual DbSet<ApplicationUserBook> UserBooks { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
