using System;
using System.Windows.Forms;

namespace VikaDonchenko
{
    public partial class LoginForm : Form
    {
        private UserManager userManager;
        public User LoggedInUser { get; private set; }
        public LoginForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        // Обработчик события нажатия кнопки "Войти"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Получение введенного имени пользователя и пароля из текстовых полей
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User loggedInUser; 
            if (userManager.Login(username, password, out loggedInUser)) // Теперь используем out логин
            {
                // Если вход успешен
                lblMessage.Text = "Вход успешен!";
                this.LoggedInUser = loggedInUser; // Устанавливаем текущего пользователя
                this.DialogResult = DialogResult.OK;
                this.Hide(); // Скрываем форму входа

              
            }
            else
            {
                // Если вход не удался
                lblMessage.Text = "Ошибка: неверное имя пользователя или пароль.";
            }
        }

        // Обработчик события нажатия кнопки "Регистрация"
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание и отображение формы регистрации
            RegistrationForm registrationForm = new RegistrationForm(userManager);
            registrationForm.ShowDialog();
        }
    }
}
