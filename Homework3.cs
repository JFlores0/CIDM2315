namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Input an integer: ");
        int N = Convert.ToInt16(Console.ReadLine());

        for (int i = 2; i< N; i++) {
            if (N%i != 0) {
                Console.WriteLine($"{N} is prime");
                break;
            }
            Console.WriteLine($"{N} is non-prime");
            break;
        }
        Console.WriteLine("End Q1.");

        //Q2
        Console.WriteLine("Assign an int value to b: ");
        int b = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<b; row++){
          for(int col = 0; col <b; col++)
          {
                Console.Write("*");
          }
              Console.WriteLine("");
         }
        Console.WriteLine("End Q2.");

        //Q3
        Console.WriteLine("Assign an int value to h: ");
        int h = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<h; row++)  {
            for(int col = 0; col<h; col++) {
                if(row>=col) 
                    Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("End Q3.");

    }
}
