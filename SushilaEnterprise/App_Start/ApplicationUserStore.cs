using Microsoft.AspNet.Identity.EntityFramework;
using SushilaEnterprise.Models;
using System.Data.Entity;

namespace SushilaEnterprise
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(DbContext context)
            : base(context)
        {
        }
    }
}