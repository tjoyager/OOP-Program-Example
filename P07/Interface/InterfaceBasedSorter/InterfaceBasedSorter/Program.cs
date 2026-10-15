// See https://aka.ms/new-console-template for more information

using InterfaceBasedSorter;

Student[] students = {
            new Student("Alice", 3.4),
            new Student("Bob", 3.9),
            new Student("Charlie", 2.8)
        };

Console.WriteLine("Students before sorting:");
foreach (var s in students) Console.WriteLine(s);
Sorter.Sort(students);
Console.WriteLine("\nStudents after sorting by GPA:");
foreach (var s in students) Console.WriteLine(s);

Book[] books = {
            new Book("C# Fundamentals", 2015),
            new Book("Modern Java", 2020),
            new Book("Python Basics", 2012)
        };

Console.WriteLine("\nBooks before sorting:");
foreach (var b in books) Console.WriteLine(b);
Sorter.Sort(books);
Console.WriteLine("\nBooks after sorting by Year:");
foreach (var b in books) Console.WriteLine(b);

Car[] cars = {
            new Car("Toyota", 180),
            new Car("BMW", 250),
            new Car("Honda", 200)
        };

Console.WriteLine("\nCars before sorting:");
foreach (var c in cars) Console.WriteLine(c);
Sorter.Sort(cars);
Console.WriteLine("\nCars after sorting by Speed (descending):");
foreach (var c in cars) Console.WriteLine(c);
