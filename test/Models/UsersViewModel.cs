using test.Areas.Identity.Data;

namespace test.Models
{
    public class UsersViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime lastLogin { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool IsSelected { get; set; }= false;
    }
}
