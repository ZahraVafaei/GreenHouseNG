namespace GreenHouseNG.Models.User
{
    public class UserReadOnlyDto
    {
        public int IdUser { get; set; }

        public string Uname { get; set; } = null!;

        public string UserRole { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
    }
}
