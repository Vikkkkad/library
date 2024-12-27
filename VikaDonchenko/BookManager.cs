using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VikaDonchenko
{
    public class BookManager
    {
        // Список книг
        private List<Book> books;

        public BookManager()
        {
            books = new List<Book>();
        }

        // Метод для добавления книги в список
        public void AddBook(string title, string author, int year, string format)
        {
            var book = new Book(title, author, year, format);
            books.Add(book);
        }


        // Метод для удаления книги по уникальному идентификатору
        public void RemoveBook(Guid id)
        {
            var bookToRemove = books.FirstOrDefault(b => b.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        // Метод для поиска книг по названию
        public List<Book> FindBookByName(string title)
        {
            return books.Where(b => b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Метод для поиска книг по автору
        public List<Book> FindBookByAuthor(string author)
        {
            return books.Where(b => b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // Метод для получения всех книг
        public List<Book> GetAllBooks()
        {
            return books;
        }

        // Импорт книг из файла 
        public void ImportBooks(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4 && int.TryParse(parts[2], out int year))
                {
                    AddBook(parts[0], parts[1], year, parts[3]);
                }
            }
        }

        // Экспорт книг в файл
        public void ExportBooksToTextFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    writer.WriteLine($"{book.Title}, {book.Author}, {book.Year}, {book.Format}");
                }
            }
        }

        public void ChangeBookFormat(Guid id, string newFormat)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                book.ChangeFormat(newFormat);
            }
        }
    }
}

