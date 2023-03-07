namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.setSalary(9000);

        Console.WriteLine("Professor "+p1.profName+" teaches "+p1.classTeach+", and the salary is: "+p1.getSalary());

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.setSalary(8000);

        Console.WriteLine("Professor "+p2.profName+" teaches "+p2.classTeach+", and the salary is: "+p2.getSalary());


        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.setGrade(90);

        Console.WriteLine("Student "+s1.studentName+" enrolls in "+s1.classEnroll+", and the grade is: "+s1.getGrade());


        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.setGrade(80);

        Console.WriteLine("Student "+s2.studentName+" enrolls in "+s2.classEnroll+", and the grade is: "+s2.getGrade());

        Console.WriteLine("The salary difference bewteen "+p1.profName+" and "+p2.profName+" is: "+(p1.getSalary() - p2.getSalary()));
        Console.WriteLine("The total grade of "+s1.studentName+" and "+s2.studentName+" is: "+(s1.getGrade() + s2.getGrade()));
        
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");  

    }// end of main class do not delete

    class Professor
{

    public string profName;

    public string classTeach;

    private double salary;

    public void setSalary( double salary_amaount) {
        salary = salary_amaount;
    }

    public double getSalary() {
        return salary;
    }

}// end of professor class do not delete

class Student
{
    public string studentName;

    public string classEnroll;

    private double studentGrade;

    public void setGrade( double newGrade) {
        studentGrade = newGrade;
    }

    public double getGrade() {
        return studentGrade;
    }

}// end of class student do not delete

}// end of main program do not delete
