namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        
        Student Alice = new Student(111, "Alice");
        Student Bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        Console.WriteLine("<<<<<------Student Dictionary:------>>>>>");
        foreach(var grade in gradebook){
            Console.WriteLine($"Student Name: {grade.Key}, Student GPA: {grade.Value}");
        }
        Console.WriteLine("<<<<<------------------------------->>>>>");

        if(gradebook.ContainsKey("Tom")){
            Console.WriteLine("Searching for student, 'Tom'...\nStudent found!");
        } else {
            Console.WriteLine("Searching for student, 'Tom'...\nStudent not found.\nCreating new student, 'Tom'...");
            gradebook.Add("Tom", 3.3);
        }

        Console.WriteLine("<<<<<------Student Dictionary:------>>>>>");
        foreach(var grade in gradebook){
            Console.WriteLine($"Student Name: {grade.Key}, Student GPA: {grade.Value}");
        }
        Console.WriteLine("<<<<<------------------------------->>>>>");

        var gpaAvg = gradebook.Average(x => x.Value);
        Console.WriteLine("\nThe average GPA is: "+gpaAvg+"\n");  

        Console.WriteLine("These students have a GPA that is higher than the gradepoint averaage:");
        foreach(var grade in gradebook){
            if(grade.Value > gpaAvg){
                Console.WriteLine($"\tStudent GPA: {grade.Value}, Student Name: {grade.Key}");
            }
        }

        Console.WriteLine("<<<<<------------------------------->>>>>");

    }// end of Main
}// end of Program Class

class Student {
    private int studentID {get; set;}

    private string studentName {get; set;}

    public static List<Student> student_list = new List<Student>();

    public Student (int inputID, string inputName) {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }


}// end of Student Class
