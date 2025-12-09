using System.Collections;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList collection = new ArrayList();

            collection.Add("Sama");
            collection.Add("Zahra");
            collection.Add("Gulsum");
            collection.Add("Shafa");
            collection.Add("Nurlana");

           
          


            int count = collection.Count;

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"count of people: {count}");
            Console.WriteLine( collection.IndexOf("Zahra"));
        }
    }
}