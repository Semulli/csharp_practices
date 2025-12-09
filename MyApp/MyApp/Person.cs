namespace MyApp;

public class Person
{
    private string tcNo;

    public string TcNo
    {
        get { return tcNo.Substring(0, 4) + "******"; }
        set
        {
            bool control = false;
            if (value.Length == 11)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool isNum = char.IsNumber(value[i]);
                    if (isNum)
                    {
                    }
                    else
                    {
                        control = true;
                        break;
                    }
                }

                if (control)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    tcNo = value;
                }
            }
            else
            {
                Console.WriteLine("Tc must consist of 11 letters");
            }
        }
    }
}