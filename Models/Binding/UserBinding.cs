using WebShopSeminar.Models.Dbo;

namespace WebShopSeminar.Models.Binding
{
    public class UserBinding : UserBaseBinding
    {
    }


    public class UserBaseBinding
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserAdminBinding : UserBaseBinding
    {
        public string RoleId { get; set; }
    }

    public class UserAdminUpdateBinding : UserAdminBinding
    {
        public string Id { get; set; }
    }
}
