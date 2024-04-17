using System;

namespace StudentNamespace
{
    class Student
    {
        public string FullName;
        public int GroupNumber;
        private int age;

        public Student(string fullName, int groupNumber, int age)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
            this.age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {FullName}, Группа: {GroupNumber}, Возраст: {age}");
        }
    }
}
namespace ReaderNamespace
{
    class Reader
    {
        private string fullName;
        public int LibraryCardNumber;
        public string Faculty;
        private DateTime dateOfBirth;
        public string PhoneNumber;

        public Reader(string fullName, int libraryCardNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.fullName = fullName;
            LibraryCardNumber = libraryCardNumber;
            Faculty = faculty;
            this.dateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Читатель: {fullName}, Номер читательского билета: {LibraryCardNumber}, Факультет: {Faculty}, Дата рождения: {dateOfBirth.ToShortDateString()}, Телефон: {PhoneNumber}");
        }
        public void TakeBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} взял {numberOfBooks} книги.");
        }
        public void TakeBook(params string[] bookTitles)
        {
            Console.Write($"{fullName} взял книги: ");
            foreach (var bookTitle in bookTitles)
            {
                Console.Write($"{bookTitle}, ");
            }
            Console.WriteLine();
        }
        public void ReturnBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} вернул {numberOfBooks} книги.");
        }
        public void ReturnBook(params string[] bookTitles)
        {
            Console.Write($"{fullName} вернул книги: ");
            foreach (var bookTitle in bookTitles)
            {
                Console.Write($"{bookTitle}, ");
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        StudentNamespace.Student[] students = new StudentNamespace.Student[3];
        students[0] = new StudentNamespace.Student("Титов И.А.", 1, 20);
        students[1] = new StudentNamespace.Student("Шорников И.П.", 2, 19);
        students[2] = new StudentNamespace.Student("Марков М.В.", 3, 18);

        ReaderNamespace.Reader[] readers = new ReaderNamespace.Reader[3];
        readers[0] = new ReaderNamespace.Reader("Титов И.А.", 1001, "Факультет1", new DateTime(1243, 5, 10), "8800-555-35-35");
        readers[1] = new ReaderNamespace.Reader("Шорников И.П.", 1002, "Факультет2", new DateTime(1999, 6, 15), "01");
        readers[2] = new ReaderNamespace.Reader("Марков М.В.", 1003, "Факультет3", new DateTime(2015, 7, 20), "03");

        Console.WriteLine("Информация о студентах:");
        foreach (var student in students)
        {
            student.PrintInfo();
        }
        Console.WriteLine("\nИнформация о читателях:");
        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[1].TakeBook("Учимся читать", "Алфавит", "Раскраска");
        readers[2].ReturnBook("Учимся читать", "Алфавит", "Раскраска");
        readers[0].ReturnBook(2);
    }
}
