using System;
using System.IO;
using System.Windows.Forms;

namespace VikaDonchenko
{

    public partial class Form1 : Form
    {
        private BookManager bookManager;
        private UserManager userManager;
        private User currentUser;
        public Form1(UserManager userManager, User currentUser)
        {
            InitializeComponent();
            this.userManager = userManager;
            this.currentUser = currentUser;
            bookManager = new BookManager();

            ConfigureAccessRights();

            comboBoxFormat.Items.Add("PDF");
            comboBoxFormat.Items.Add("DOCX");

            comboBoxNewFormat.Items.Add("PDF");
            comboBoxNewFormat.Items.Add("DOCX");
        }

        private void ConfigureAccessRights()
        {
            // Настройка прав доступа для разных пользователей
            if (currentUser.Role == UserRole.User)
            {
                // Если роль - обычный пользователь, отключаем функции админа
                button2.Enabled = false; // Кнопка удаления книг
                buttonConvertFormat.Enabled = false; // Кнопка изменения формата
                comboBoxNewFormat.Enabled = false; // Текстовое поле для изменения формата
            }
        }

        // Обработчик события нажатия кнопки "Добавить"
        private void button1_Click(object sender, EventArgs e)
        {
            // Получение введенных данных о книге
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            if (int.TryParse(txtYear.Text, out int year))
            {
                string format = comboBoxFormat.SelectedItem?.ToString() ?? "Unknown";
                bookManager.AddBook(title, author, year, format);
                MessageBox.Show("Книга добавлена."); // Уведомление об успешном добавлении
                ClearFields();
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Введите корректный год."); // Уведомление об ошибке
            }
        }

        // Обработчик события нажатия кнопки "Удалить"
        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли книга для удаления
            if (listBoxBooks.SelectedItem is Book selectedBook)
            {
                bookManager.RemoveBook(selectedBook.Id);
                MessageBox.Show("Книга удалена."); // Уведомление об успешном удалении
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления."); // Уведомление об ошибке
            }
        }

        // Обработчик события нажатия кнопки "Поиск по названию"
        private void button3_Click(object sender, EventArgs e)
        {
            // Поиск книг по названию
            var foundBooks = bookManager.FindBookByName(txtSearch.Text);
            listBoxBooks.Items.Clear();
            foreach (var book in foundBooks)
            {
                listBoxBooks.Items.Add(book);
            }
        }

        // Обработчик события нажатия кнопки "Поиск по автору"
        private void button4_Click(object sender, EventArgs e)
        {
            // Поиск книг по автору
            var foundBooks = bookManager.FindBookByAuthor(txtSearch.Text);
            listBoxBooks.Items.Clear();
            foreach (var book in foundBooks)
            {
                listBoxBooks.Items.Add(book);
            }
        }

        // Метод для обновления списка книг
        private void UpdateBookList()
        {
            listBoxBooks.Items.Clear();
            foreach (var book in bookManager.GetAllBooks())
            {
                listBoxBooks.Items.Add(book);
            }
        }

        // Метод для очистки полей ввода
        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtSearch.Clear();
        }

        // Обработчик события нажатия кнопки "Импорт книг"
        private void buttonImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bookManager.ImportBooks(openFileDialog.FileName);
                        MessageBox.Show("Книги успешно импортированы.");
                        UpdateBookList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при импорте: {ex.Message}");
                    }
                }
            }
        }

        // Обработчик события нажатия кнопки "Экспорт книг"
        private void buttonExportText_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bookManager.ExportBooksToTextFile(saveFileDialog.FileName);
                        MessageBox.Show("Книги успешно экспортированы.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте: {ex.Message}");
                    }
                }
            }
        }

        private void buttonConvertFormat_Click(object sender, EventArgs e)
        {
            // Проверка, выбрана ли книга для конвертации
            if (listBoxBooks.SelectedItem is Book selectedBook && comboBoxNewFormat.SelectedItem is string newFormat)
            {
                bookManager.ChangeBookFormat(selectedBook.Id, newFormat);
                MessageBox.Show($"Формат книги '{selectedBook.Title}' изменен на '{newFormat}'.");
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Выберите книгу и новый формат.");
            }
        }
    }
}
