using System.Globalization;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            cat Cat = new cat();
            Cat.animalName = "Lucy";
            Cat.animalSex = "female";
            Cat.animalColor = "Black";
            
            Cat.showAnimalInformation();
        }
    }
}