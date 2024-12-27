using System;

namespace VikaDonchenko
{
    public class Book
    {
        public Guid Id { get; set; } // Добавлен публичный сеттер
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Format { get; set; }

        // Публичный беспараметрический конструктор
        public Book()
        {
            Id = Guid.NewGuid(); // Инициализируем уникальный идентификатор
        }

        // Конструктор с параметрами
        public Book(string title, string author, int year, string format) : this()
        {
            Title = title;
            Author = author;
            Year = year;
            Format = format;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Название: {Title}, Автор: {Author}, Год: {Year}, Формат: {Format}";
        }

        public void ChangeFormat(string newFormat)
        {
            Format = newFormat;
        }

    }
}


