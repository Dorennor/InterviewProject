using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public static class SignInManagerExtension
    {
        public static async Task<SignInResult> PasswordEmailSignInAsync(this SignInManager<User> signInManager, string email, string password, bool isPersistent, bool shouldLockout)
        {
            var user = await signInManager.UserManager.FindByEmailAsync(email);
            return await signInManager.PasswordSignInAsync(user.UserName, password, isPersistent, shouldLockout);
        }
    }
}