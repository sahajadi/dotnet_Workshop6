namespace workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1  
            //// Create a rectangle object
            //Rectangle rect = new Rectangle
            //{
            //    Length = 20,
            //    Breadth = 10
            //};

            //// Display results
            //Console.WriteLine(rect.ShowDetails());
            //Console.WriteLine($"Area: {rect.GetArea()}");
            //Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");



            //// TAsk 2 
            //Calculate calc;

            //calc = MathOps.Add;
            //Console.WriteLine($"Add: {calc(20, 10)}"); // 15

            //calc = MathOps.Subtract;
            //Console.WriteLine($"Subtract: {calc(20, 10)}"); // 5




            // ---------- TASK 2.1, 2.2, 2.3 ----------
            Console.WriteLine("\n--- Task 2: Custom Delegate Extended ---");

            double price = 1000;

            // Using existing discount methods
            Console.WriteLine($"Festival Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.FestivalDiscount)}");
            Console.WriteLine($"Seasonal Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.SeasonalDiscount)}");
            Console.WriteLine($"No Discount Final Price: {DiscountService.CalculateFinalPrice(price, DiscountService.NoDiscount)}");

            // Lambda expression for 30% discount (Task 2.3)
            Console.WriteLine($"30% Discount Final Price: {DiscountService.CalculateFinalPrice(price, p => p * 0.70)}");


        }
    }

}


    
