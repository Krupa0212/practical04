// See https://aka.ms/new-console-template for more information
using System;

using MainEmp;
namespace MainProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            PermanentEmp e1 = new PermanentEmp("Ash", "Gaekwad", "07-08-79", "12-02-21", 51000.0, 23000, 1000, 14000);
            Console.WriteLine($"Information about First Employee:\n{e1}"); e1.GiveRaise(10.0);
            Console.WriteLine($"Information about First Employee after 10% raise:\n{e1}");
            PermanentEmp e2 = new
            PermanentEmp("Vish", "Patel", "13-05-79", "03-01-21", 40000.0, 21000, 1200, 12000);
            Console.WriteLine($"Inforamtion about second Employee:\n{e2}"); e2.GiveRaise(10.0);
            Console.WriteLine($"Inforamtion about second Employee after raise:\n{e2}");
        }
    }
}
