using System;

namespace methodsindetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            /*e1.Name = "Mohamed Ahmed";
            e1.Age = 22;
            int l = 2;
            e1.Info(l);*/
            /* int a = 5;
             e1.Inc(ref a);//6
             Console.WriteLine(a);//6
             */
            Point p1 = new Point();
            e1.IncPoint(p1);
            Console.WriteLine(p1.x);

        }
    }
}
