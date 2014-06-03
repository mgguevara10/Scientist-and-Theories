using Microsoft.AspNet.Identity.EntityFramework;
using Scientist.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientist.Data
{
 public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection",throwIfV1Schema:false)
        {
            
        }
        public DbSet<Theory> Theories { get; set; }
    }
}