using System;
using System.Windows.Forms;

namespace VikaDonchenko
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserManager userManager = new UserManager();
           

            using (LoginForm loginForm = new LoginForm(userManager))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    User loggedInUser = loginForm.LoggedInUser; // Получение текущего пользователя из формы входа
                    Application.Run(new Form1(userManager, loggedInUser));
                }
            }
        }
    }
}
