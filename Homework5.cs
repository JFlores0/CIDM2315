namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        
        int num1 = getIntegers();
        int num2 = getIntegers();
        Console.WriteLine($"a = {num1}; b = {num2} ");
        largestInteger(num1,num2);
        
        int num3 = getIntegers();
        int num4 = getIntegers();
        Console.WriteLine($"a = {num1}; b = {num2}; c = {num3}; d = {num4}");
        largestInteger(num1, num2, num3, num4);

        createAccount();
        
        
    }

    static int getIntegers () {
        Console.WriteLine("Please enter an integer: ");
        int number = Convert.ToInt16(Console.ReadLine());
        return number;
    }

    static void largestInteger (int a, int b, int c = 0, int d = 0) {
        if (a > b && a > c && a > d) {
            Console.WriteLine($"The largest number is: {a}");
        } else if (b > a && b > c && b > d) {
            Console.WriteLine($"The largest number is: {b}");
        } else if (c > a && c > b && c > d) {
            Console.WriteLine($"The largest number is: {c}");
        } else {
            Console.WriteLine($"The largest number is: {d}");
        } 
    }

        static bool checkAge (int birth_year) {
        int age = 2023 - birth_year;
        if (age >= 18) {
            return true;
        } else {
            return false;
        }
    }
        static void createAccount() {
        Console.WriteLine("Please enter a username: ");
        string users_name = Console.ReadLine();
        Console.WriteLine("Please enter a password: ");
        string users_password = Console.ReadLine();
        Console.WriteLine("Please re-enter your password: ");
        string users_rePassword = Console.ReadLine();
        Console.WriteLine("Please enter your birthyear");
        int birthYear = Convert.ToInt16(Console.ReadLine());
        checkAge(birthYear);
        if (checkAge(birthYear) == true)
        {
            if (users_password == users_rePassword)
            {
                Console.WriteLine("Account is created successfully.");
            }
            else
            {
                Console.WriteLine("Wrong Password.");
            }
        }
        else
        {
            Console.WriteLine("Could not create an Account.");
        }

    }







    




}
