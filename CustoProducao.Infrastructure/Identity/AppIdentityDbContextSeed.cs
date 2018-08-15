using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CustoProducao.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "maguinho.aju", Email = "maguinho.aju@gmail.com" };
            await userManager.CreateAsync(defaultUser, "Fr4nc4V3!g4");
        }
    }
}
