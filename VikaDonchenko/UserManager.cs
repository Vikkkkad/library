using System;
using System.Collections.Generic;
using System.Linq;

namespace VikaDonchenko
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public UserManager()
        {
            // Админ
            Register("вика", "123", UserRole.Admin);
            // Пользователь
            Register("user", "123", UserRole.User);
        }

        // Метод для регистрации нового пользователя
        public bool Register(string username, string password, UserRole role)
        {
            // Проверка на уникальность имени пользователя
            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Имя пользователя уже занято
            }

            // Добавление нового пользователя в список
            users.Add(new User(username, password, role)); 
            return true; // Регистрация успешна
        }
        
        // Метод для входа пользователя в систему
        public bool Login(string username, string password, out User loggedInUser)
        {
            loggedInUser = users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            return loggedInUser != null; // возвращает true, если логин успешен
        }
    }
}
