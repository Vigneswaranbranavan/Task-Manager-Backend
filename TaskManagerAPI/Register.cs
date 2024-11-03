using TaskManagerAPI.Migrations;

namespace TaskManagerAPI
{
    public class Register
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public RegisterRole Role { get; set; }

    }
}
