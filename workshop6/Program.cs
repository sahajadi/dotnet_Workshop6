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



            // TAsk 2 part 1
            Calculate calc;

            calc = MathOps.Add;
            Console.WriteLine($"Add: {calc(20, 10)}"); // 15

            calc = MathOps.Subtract;
            Console.WriteLine($"Subtract: {calc(20, 10)}"); // 5



            // ---------- TASK 2 PART 2 ----------
            DiscountStrategy discount;

            discount = DiscountService.FestivalDiscount;
            Console.WriteLine($"Festival Discount on 1000: {discount(1000)}");

            discount = DiscountService.SeasonalDiscount;
            Console.WriteLine($"Seasonal Discount on 1000: {discount(1000)}");

            discount = DiscountService.NoDiscount;
            Console.WriteLine($"No Discount on 1000: {discount(1000)}");
        }
    }

}


    
