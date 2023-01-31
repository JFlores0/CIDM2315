namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        // Q1

        Console.WriteLine("Please input a letter grade: ");
        string user_input = Console.ReadLine();
        string grade = user_input.ToUpper();
        switch (grade) {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        // Q2

        Console.WriteLine("Please input the first num: ");
        string user_num1 = Console.ReadLine();
        int num1 = Convert.ToInt16(user_num1);
        Console.WriteLine("Please input the second num: ");
        string user_num2 = Console.ReadLine();
        int num2 = Convert.ToInt16(user_num2);
        Console.WriteLine("Please input the third num: ");
        string user_num3 = Console.ReadLine();
        int num3 = Convert.ToInt16(user_num3);
        if ((num1 < num2) && (num1 < num3)) {
            Console.WriteLine("The smallest value is: " +num1);
        } else if ((num2 < num1) && (num2 < num3)) {
            Console.WriteLine("The smallest value is: " +num2);
        } else if ((num3 < num1) && (num3 < num2)) {
            Console.WriteLine("The smallest value is: " +num3);
        }

        // BONUS

        Console.WriteLine("Please input a year: ");
        string user_year = Console.ReadLine();
        int leap = Convert.ToInt16(user_year);
        if ((leap % 4 == 0) && (leap % 100 != 0)) {
                Console.WriteLine($"{leap} is a Leap Year.");
            } else if (leap % 400 == 0) {
                Console.WriteLine($"{leap} is a Leap Year.");
            } else {
                Console.WriteLine($"{leap} is not a Leap Year.");
            }



    }// end of main Args[]
}
