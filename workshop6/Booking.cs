using System;

namespace workshop6
{
    public class Booking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }
    }
}
