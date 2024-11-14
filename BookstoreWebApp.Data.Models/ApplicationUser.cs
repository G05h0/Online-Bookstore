using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreWebApp.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<ApplicationUserBook> ApplicationUserBooks { get; set; }
            = new HashSet<ApplicationUserBook>();
    }
}
