using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace SushilaEnterprise
{
    public class ApplicationRoleStore : RoleStore<IdentityRole>
    {
        public ApplicationRoleStore(DbContext dbContext)
            : base(dbContext)
        {

        }

    }
}
