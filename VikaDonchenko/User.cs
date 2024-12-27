using System;

namespace VikaDonchenko
{
    public enum UserRole
    {
        Admin,
        User
    }

    public class User
    {
        // Свойство для хранения имени пользователя
        public string Username { get; set; }
        // Свойство для хранения пароля пользователя
        public string Password { get; set; }
        // Уровень доступа
        public UserRole Role { get; set; }

        public User(string username, string password, UserRole role = UserRole.User)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
