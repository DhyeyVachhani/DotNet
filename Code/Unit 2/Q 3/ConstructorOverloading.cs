using System;

class Student
{
    public string name, email;
    public int number;
    public Student()
    {
    }
    public Student(string name)
    {
        this.name = name;
    }
    public Student(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
    public Student(string name, int number)
    {
        this.name = name;
        this.number = number;
    }
}
class MainClass
{
    public static void Main()
    {
        Student S1 = new Student();
        Student S2 = new Student("Raj");
        Student S3 = new Student("Amit","amit@gmail.com");
        Student S4 = new Student("Ashok",34);

        Console.WriteLine("Student 1 Name is: {0} email is: {1} and Number is: {2}",S1.name, S1.email, S1.number);
        Console.WriteLine("Student 2 Name is: {0} email is: {1} and Number is: {2}",S2.name, S2.email, S2.number);
        Console.WriteLine("Student 3 Name is: {0} email is: {1} and Number is: {2}",S3.name, S3.email, S3.number);
        Console.WriteLine("Student 4 Name is: {0} email is: {1} and Number is: {2}",S4.name, S4.email, S4.number);
    }
}