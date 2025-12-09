using System.Globalization;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.TcNo = "12345678987";
            Console.WriteLine("tc number is " + person1.TcNo);
        }
    }
}