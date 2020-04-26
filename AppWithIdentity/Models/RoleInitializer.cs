using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AppWithIdentity.Models
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await roleManager.FindByNameAsync("группа 1") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("группа 1"));
            }
            if (await roleManager.FindByNameAsync("группа 2") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("группа 2"));
            }            
        }
    }
}
