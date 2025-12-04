using System;
using System.Collections.Generic;
using System.Linq;

public class CashierSales
{
    public string CashierName { get; set; }
    public double SalesAmount { get; set; }
}

public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Music
{
    public string Title { get; set; }
    public int DurationInSeconds { get; set; }
}

public class Task5
{
    public static void Run()
    {
        // --------------------------------------
        // 1. Aggregation Operators
        // --------------------------------------
        Console.WriteLine("\n--- Aggregation Operators ---");

        List<CashierSales> cashiers = new List<CashierSales>
        {
            new CashierSales { CashierName = "Aarav", SalesAmount = 12000 },
            new CashierSales { CashierName = "Sita", SalesAmount = 18000 },
            new CashierSales { CashierName = "Raju", SalesAmount = 9000 },
            new CashierSales { CashierName = "Anita", SalesAmount = 15000 }
        };

        int totalCashiers = cashiers.Count();
        double totalSales = cashiers.Sum(c => c.SalesAmount);
        double highestSale = cashiers.Max(c => c.SalesAmount);
        double lowestSale = cashiers.Min(c => c.SalesAmount);
        double avgSale = cashiers.Average(c => c.SalesAmount);

        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: Rs. {totalSales}");
        Console.WriteLine($"Highest Sale: Rs. {highestSale}");
        Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
        Console.WriteLine($"Average Sale: Rs. {avgSale}");



        // --------------------------------------
        // 2. Quantifier Operators (Any / All)
        // --------------------------------------
        Console.WriteLine("\n--- Quantifier Operators ---");

        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Sam", Age = 17 },
            new Applicant { Name = "John", Age = 22 },
            new Applicant { Name = "Rina", Age = 19 },
            new Applicant { Name = "Aditi", Age = 16 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"All applicants above 16? {allAbove16}");



        // --------------------------------------
        // 3. Element Operators (First, Last, FirstOrDefault)
        // --------------------------------------
        Console.WriteLine("\n--- Element Operators ---");

        List<Music> songs = new List<Music>
        {
            new Music { Title = "Dreams", DurationInSeconds = 210 },
            new Music { Title = "Stars", DurationInSeconds = 140 },
            new Music { Title = "Vibes", DurationInSeconds = 280 },
            new Music { Title = "Chill", DurationInSeconds = 400 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstLongSong = songs.First(s => s.DurationInSeconds > 240); // > 4 minutes
        var safeLongSong = songs.FirstOrDefault(s => s.DurationInSeconds > 600); // > 10 minutes

        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First song > 4 min: {firstLongSong.Title}");

        if (safeLongSong == null)
            Console.WriteLine("No song longer than 10 minutes found (safe result: null)");
        else
            Console.WriteLine($"Song longer than 10 minutes: {safeLongSong.Title}");
    }
}
