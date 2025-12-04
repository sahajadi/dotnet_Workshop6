using System;

namespace workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // ---------- TASK 1 ----------
            //Rectangle rect = new Rectangle
            //{
            //    Length = 20,
            //    Breadth = 10
            //};

            //Console.WriteLine(rect.ShowDetails());
            //Console.WriteLine($"Area: {rect.GetArea()}");
            //Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");


            // ---------- TASK 2.1, 2.2, 2.3 ----------
            //Console.WriteLine("\n--- Task 2: Custom Delegate Extended ---");

            //double price = 1000;

            //// Using existing discount methods
            //Console.WriteLine($"Festival Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.FestivalDiscount)}");
            //Console.WriteLine($"Seasonal Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.SeasonalDiscount)}");
            //Console.WriteLine($"No Discount Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.NoDiscount)}");

            //// Lambda expression for 30% discount (Task 2.3)
            //Console.WriteLine($"30% Discount Final Price: {DiscountService.CalculateFinalPrice(price, p => p * 0.70)}");


            ////Task 3

            //Console.WriteLine("\n--- Task 3: Built-in Delegate ---");

            //int[] nums = { 2, 5, 12, 7, 18, 3, 22 };

            //// Only even numbers
            //Console.WriteLine("Even Numbers:");
            //NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

            //// Only numbers greater than 10
            //Console.WriteLine("\nNumbers > 10:");
            //NumberProcessor.ProcessNumbers(nums, n => n > 10);



            //// ---------- TASK 4 ----------

            //Console.WriteLine("\n--- Task 4: LINQ Basics ---");
            //Task4.Run();    


            //// ---------- TASK 5 ----------
            //Console.WriteLine("\n--- Task 5: LINQ Continued ---");
            //Task5.Run();

            // ---------- TASK 6 ----------
            Console.WriteLine("\n--- Task 6: LINQ Continued ---");

            // Sample data
            List<Booking> bookings = new List<Booking>()
            {
                new Booking { CustomerName = "Ram", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
                new Booking { CustomerName = "Sita", Destination = "Thailand", Price = 25000, DurationInDay = 5, IsInternational = true },
                new Booking { CustomerName = "Hari", Destination = "Chitwan", Price = 12000, DurationInDay = 6, IsInternational = false },
                new Booking { CustomerName = "Gita", Destination = "Dubai", Price = 30000, DurationInDay = 7, IsInternational = true }
            };

            // LINQ Query
            var report = bookings
                .Where(b => b.Price > 10000 && b.DurationInDay > 4)
                .Select(b => new
                {
                    b.CustomerName,
                    b.Destination,
                    Category = b.IsInternational ? "International" : "Domestic",
                    b.Price
                })
                .OrderBy(b => b.Category == "International")  // Domestic first
                .ThenBy(b => b.Price)
                .ToList();

            // Display Result
            foreach (var item in report)
            {
                Console.WriteLine($"Customer: {item.CustomerName}");
                Console.WriteLine($"Destination: {item.Destination}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Price: Rs. {item.Price}");
                Console.WriteLine("-----------------------------");
            }


        }


    }
}
