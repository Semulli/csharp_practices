namespace MyApp;

public class Student
{
    private int studentNo;
    private string studentName;
    private string studentSurname;
    private int midterm;
    private int midterm2;
    private int finalExam;
    private string schoolName;

    public Student(int _studentNo, string _studentName, string _studentSurname, int _midterm, int _midterm2,
        int _finalExam, string _schoolName)
    {
        studentName = _studentName;
        studentSurname = _studentSurname;
        studentNo = _studentNo;
        midterm = _midterm;
        midterm2 = _midterm2;
        finalExam = _finalExam;
        schoolName = _schoolName;
    }

    public void showStudentInformation()
    {
        Console.WriteLine($"Student No: {studentNo}");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Student Surname: {studentSurname}");
        Console.WriteLine($"Midterm Exam1: {midterm}");
        Console.WriteLine($"Midterm Exam2: {midterm2}");
        Console.WriteLine($"Final Exam: {finalExam}");
        Console.WriteLine($"School Name: {schoolName}");
    }

    public double avarageNotes()
    {
        double avaragePoint = midterm * 0.2 + midterm2 * 0.2 + finalExam * 0.6;

        return avaragePoint;
    }

    public void school()
    {
        Console.WriteLine($"Student's School Name: {schoolName}");
    }
}