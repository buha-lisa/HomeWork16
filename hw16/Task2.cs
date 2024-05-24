
namespace hw16
{
    class Task2
    {
        public void CurrentTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToLongTimeString()}");
        }
        public void CurrentDate()
        {
            Console.WriteLine($"Current Date: {DateTime.Now.ToShortDateString()}");
        }
        public void CurrentDayOfWeek()
        {
            Console.WriteLine($"Current Day of the Week: {DateTime.Now.DayOfWeek}");
        }
        public double TriangleSquare(double length, double height)
        {
            return 0.5 * length * height;
        }
        public double RectangleSquare(double length, double width)
        {
            return length * width;
        }
    }
}
