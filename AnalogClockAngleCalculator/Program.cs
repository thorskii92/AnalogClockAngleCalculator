using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static double CalculateAngle(int hours, int minutes)
        {           
            double hourAngle = (hours % 12 + minutes / 60.0) * 30;         
            double minuteAngle = minutes * 6;          
            double angle = Math.Abs(hourAngle - minuteAngle);          
            return Math.Min(angle, 360 - angle);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Analog Clock Angle Calculator");
            Console.Write("Enter the hours (0-12): ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the minutes (0-59): ");
            int minutes = int.Parse(Console.ReadLine());
            double angle = CalculateAngle(hours, minutes);    
            Console.WriteLine("The smaller angle between the hour and minute hands is " + angle + " degrees.");      
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
