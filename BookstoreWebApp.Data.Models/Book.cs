﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; } = new Guid();

        public string Title { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public int Pages { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; } = null!;

        public virtual ICollection<AuthorBook> BookAuthors { get; set; } = new HashSet<AuthorBook>();

    }
}
