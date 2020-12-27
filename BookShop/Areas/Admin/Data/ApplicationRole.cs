using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Data
{
    public class ApplicationRole :IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string name) :base(name)
        {

        }

        public ApplicationRole(string name , string descriptin) : base(name)
        {
            Description = descriptin;
        }


        public virtual ICollection<ApplicationUserRole> Users { get; set; }
      
    }
}
