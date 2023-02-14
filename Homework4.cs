namespace Homework4;
class Program
{
    static void Main(string[] args)

    //Q1
    {
        Console.WriteLine("Please input two integers: ");
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        TwoInputs(a, b);
        Console.WriteLine("End Q1.");
        Console.WriteLine("Assign an integer value to N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Assign a shape (type 'left' or 'right'):");
        string a_shape = Console.ReadLine();
        string shape = a_shape.ToUpper();
        NShape(N, shape);
    }

    static void TwoInputs (int a, int b) 
    {

        if (a > b) {
            Console.WriteLine($"a: {a}; b: {b}\nThe largest number is: {a}");
        } else if (a < b) {
            Console.WriteLine($"a: {a}; b: {b}\nThe largest number is: {b}");
        } else if (a == b) {
            Console.WriteLine($"a: {a}; b: {b}\nThese numbers are the same.");
        } else {
            Console.WriteLine($"a: {a}; b: {b}\nI dont know if this line is needed.");
        }       

    }

    //Q2

    static void NShape (int N, string shape) {

        Console.WriteLine($"N is: {N}; shape is {shape}");
        if (shape == "LEFT") {
            for(int row = 0; row<N; row++)  {
            for(int col = 0; col<N; col++) {
                if(row>=col) 
                    Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("End Q2.");
        } else {
            for(int row = 0; row<N; row++)  {
            for(int col = 0; col<N; col++) {
                if(col>=row) 
                    Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("End Q2.");
        }

    }
}
