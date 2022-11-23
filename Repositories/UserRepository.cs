using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User { Id = 1, UserName = "Juliano", Password = "1234", Role = "manager"},
                new User { Id = 2, UserName = "Raul", Password = "1234", Role = "employee"}

            };

            return users.Where(u =>
                        u.UserName?.ToLower() == username.ToLower() &&
                        u.Password == password).First();

        }
    }
}
