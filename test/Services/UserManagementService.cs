using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using test.Areas.Identity.Data;

namespace test.Services
{
    public class UserManagementService
    {
        private readonly UserManager<testUser> _userManager;
        private readonly SignInManager<testUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserManagementService(UserManager<testUser> userManager, SignInManager<testUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task BlockUsers(List<string> selectedUserIds, bool isBlocked)
        {
            var users = await _userManager.Users.Where(u => selectedUserIds.Contains(u.Id)).ToListAsync();

            foreach (var user in users)
            {
                user.IsBlocked = isBlocked;
                if (isBlocked && user.Id == _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value)
                {
                    await _signInManager.SignOutAsync(); // Разлогинивание текущего пользователя, если он заблокирован
                }
            }

            foreach (var user in users)
            {
                await _userManager.UpdateAsync(user);
            }
        }
        public async Task DeleteUsers(List<string> userIds)
        {
            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    await _userManager.DeleteAsync(user);
                }
            }
        }

    }
}
