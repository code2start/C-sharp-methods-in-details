using System;

namespace methodsindetails
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Info(int level)
        {
            Console.WriteLine($"Employee name is {Name} , age is {Age}, {level}");
        }
        public void Inc(ref int x)
        {
            x++;
            Console.WriteLine(x);
        }
        public void IncPoint(Point point)
        {
            point.x++;
            Console.WriteLine(point.x);
        }
    }
    public class Point
    {
        public int x = 10;
    }
}