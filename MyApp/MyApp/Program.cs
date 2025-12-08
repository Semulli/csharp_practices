using System.Globalization;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool control = true;
            Student student1 = new Student(10, "Sama", "Abdulazizova", 19, 15, 35, "Khazar University");
            Console.WriteLine("Welcome to the our app.... please choose the process ");


            while (control)
            {
                showProcesses();

                string yourChoose = Console.ReadLine();
                switch (yourChoose)
                {
                    case "1":
                        student1.showStudentInformation();
                        break;
                    case "2":
                        double avarageNote = student1.avarageNotes();
                        Console.WriteLine($"Student 1 Gpo is: {avarageNote}");
                        break;
                    case "3":
                        student1.school();
                        break;
                    case "4":
                        control = false;
                        break;
                }
            }

            static void showProcesses()
            {
                Console.WriteLine($"1-Show student informations:");
                Console.WriteLine($"2-Show student GPO:");
                Console.WriteLine($"3-Show stuudent's school:");
                Console.WriteLine("4-Exit");
            }
        }
    }
}