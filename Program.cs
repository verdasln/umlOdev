using System;
using System.Collections.Generic;

public class Book
{
    public string Title;
    public string GetTitle() => Title;
    private void SetTitle(string title) => Title = title;

    public string Author;
    public string GetAuthor() => Author;
    private void SetAuthor(string author) => Author = author;

    public int Pages;
    public int GetPages() => Pages;
    private void SetPages(int pages) => Pages = pages;

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
}

public class Student
{
    public int ID;
    public int GetID() => ID;
    private void SetID(int id) => ID = id;

    public string Name;
    public string GetName() => Name;
    private void SetName(string name) => Name = name;

    public string Major;
    public string GetMajor() => Major;
    private void SetMajor(string major) => Major = major;

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {ID}, Name: {Name}, Major: {Major}");
    }
}

public class Teacher
{
    public string Name;
    public string GetName() => Name;
    private void SetName(string name) => Name = name;

    public string Department;
    public string GetDepartment() => Department;
    private void SetDepartment(string department) => Department = department;

    public decimal Salary;
    public decimal GetSalary() => Salary;
    private void SetSalary(decimal salary) => Salary = salary;

    public Teacher(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book("1984", "George Orwell", 328),
            new Book("The Alchemist", "Paulo Coelho", 208),
            new Book("Sapiens", "Yuval Noah Harari", 443)
        };

        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Zeynep", Major = "Computer Engineering" },
            new Student { ID = 2, Name = "Ali", Major = "Mechanical Engineering" }
        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher("Dr. Ayşe", "Mathematics", 9500m),
            new Teacher("Dr. Emre", "Physics", 10000m)
        };

        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Search Teacher");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter book title: ");
                string title = Console.ReadLine();
                Book found = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (found != null)
                    Console.WriteLine($"Book: {found.Title}, Author: {found.Author}, Pages: {found.Pages}");
                else
                    Console.WriteLine("Book not found.");
            }
            else if (choice == "2")
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Student found = students.Find(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (found != null)
                    found.DisplayInfo();
                else
                    Console.WriteLine("Student not found.");
            }
            else if (choice == "3")
            {
                Console.Write("Enter teacher name: ");
                string name = Console.ReadLine();
                Teacher found = teachers.Find(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (found != null)
                    Console.WriteLine($"Teacher: {found.Name}, Department: {found.Department}, Salary: {found.Salary:C}");
                else
                    Console.WriteLine("Teacher not found.");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}