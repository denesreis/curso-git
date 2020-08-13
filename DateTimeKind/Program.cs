using System;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 8, 15, 13, 5, 58, System.DateTimeKind.Local);

            DateTime d2 = new DateTime(2020, 8, 15, 13, 5, 58, System.DateTimeKind.Utc);

            DateTime d3 = new DateTime(2020, 8, 15, 13, 5, 58, System.DateTimeKind.Unspecified);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine("------");
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Local Time: " + d1.ToLocalTime());
            Console.WriteLine("d1 Universal Time: " + d1.ToUniversalTime());

            Console.WriteLine("------");
            Console.WriteLine("d2: "+d2);
            Console.WriteLine("d2 Local Time: "+d2.ToLocalTime());
            Console.WriteLine("d2 Universal Time: "+d2.ToUniversalTime());

            Console.WriteLine("------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Local Time: " + d3.ToLocalTime());
            Console.WriteLine("d3 Universal Time: " + d3.ToUniversalTime());


        }
    }
}
