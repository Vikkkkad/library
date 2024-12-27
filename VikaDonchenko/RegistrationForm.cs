using System;
using System.Windows.Forms;

namespace VikaDonchenko
{
    public partial class RegistrationForm : Form
    {
        private UserManager userManager;
        public RegistrationForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        // Обработчик события нажатия кнопки "Зарегистрироваться"
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Получение введенного имени пользователя и пароля из текстовых полей
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            

            if (userManager.Register(username, password, UserRole.User))
            {
                // Если регистрация успешна, выводим сообщение об успехе
                lblMessage.Text = "Регистрация успешна!";
                this.Hide(); // Скрываем форму регистрации
                LoginForm loginForm = new LoginForm(userManager);
                loginForm.ShowDialog(); // Показываем форму входа
                this.Close(); // Закрываем форму регистрации
                
            }
            else
            {
                // Если регистрация не удалась, выводим сообщение об ошибке
                lblMessage.Text = "Ошибка: имя пользователя уже занято.";
            }
        }
    }
}
