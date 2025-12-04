namespace workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle object
            Rectangle rect = new Rectangle
            {
                Length = 20,
                Breadth = 10
            };

            // Display results
            Console.WriteLine(rect.ShowDetails());
            Console.WriteLine($"Area: {rect.GetArea()}");
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");
        }
    }
}
