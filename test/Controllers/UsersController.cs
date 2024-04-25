using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Data;
using test.Services;
using Microsoft.AspNetCore.Identity;
using test.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace test.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly testContext _context;
        private readonly UserManagementService _userManagementService;
        private readonly UserManager<testUser> _userManager;
        private readonly SignInManager<testUser> _signInManager;

        public UsersController(testContext context, UserManagementService userManagementService, UserManager<testUser> userManager, SignInManager<testUser> signInManager)
        {
            _context = context;
            _userManagementService = userManagementService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> BlockUsers(List<string> selectedUserIds, string command)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null && currentUser.IsBlocked)
            {
                // Если текущий пользователь заблокирован, разлогиниваем его
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home"); // Или перенаправьте пользователя куда-либо еще
            }
            // Вызов метода BlockUsers из UserManagementService для блокировки пользователей
            bool isBlocked = command == "block";
            await _userManagementService.BlockUsers(selectedUserIds, isBlocked);

            // После блокировки пользователей перенаправляем на страницу Users
            return RedirectToAction("Users");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUsers(List<string> selectedUserIds)
        {
            // Удаляем пользователей
            await _userManagementService.DeleteUsers(selectedUserIds);

            // После удаления пользователей перенаправляем на страницу Users
            return RedirectToAction("Users");
        }
    }
}


