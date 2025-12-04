public class Task4
{
    public static void Run()
    {
        // 1. Squaring numbers
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        var squared = nums.Select(n => n * n).ToList();

        Console.WriteLine("\n--- Squared Numbers ---");
        foreach (var s in squared)
            Console.WriteLine(s);

        // 2. Filtering books
        List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Price = 800 },
            new Book { Title = "Advanced Java", Price = 1500 },
            new Book { Title = "Python 101", Price = 1200 },
            new Book { Title = "HTML & CSS", Price = 600 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000).ToList();

        Console.WriteLine("\n--- Premium Books (Price > 1000) ---");
        foreach (var b in premiumBooks)
            Console.WriteLine($"{b.Title} - Rs. {b.Price}");

        // 3. Sorting students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sahajadi" },
            new Student { Name = "Isha" },
            new Student { Name = "PAnkita" },
            new Student { Name = "RAnkita" },
            new Student { Name = "Aarohi" },
            new Student { Name = "Pensu" },
            new Student { Name = "Sital" },
            new Student { Name = "Prashidika" },
            new Student { Name = "xyz" },
            new Student { Name = "abc" }
        };

        var sortedStudents = students.OrderBy(s => s.Name).ToList();

        Console.WriteLine("\n--- Sorted Students (Alphabetical) ---");
        foreach (var s in sortedStudents)
            Console.WriteLine(s.Name);
    }
}
