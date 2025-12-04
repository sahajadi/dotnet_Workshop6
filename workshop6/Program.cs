using System;

namespace workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------- TASK 1 ----------
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


            //Task 3

            Console.WriteLine("\n--- Task 3: Built-in Delegate ---");

            int[] nums = { 2, 5, 12, 7, 18, 3, 22 };

            // Only even numbers
            Console.WriteLine("Even Numbers:");
            NumberProcessor.ProcessNumbers(nums, n => n % 2 == 0);

            // Only numbers greater than 10
            Console.WriteLine("\nNumbers > 10:");
            NumberProcessor.ProcessNumbers(nums, n => n > 10);




        }

    }
}
