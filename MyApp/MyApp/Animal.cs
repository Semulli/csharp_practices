namespace MyApp;

public class Animal
{
    public string animalName;
    public string animalSex;
    public string animalColor;
    private int animalAge;

    public void showAnimalInformation()
    {
        Console.WriteLine($"Animal Name: {animalName}");
        Console.WriteLine($"Animal Sex: {animalSex}");
        Console.WriteLine($"Animal Color: {animalColor}");
    }
}