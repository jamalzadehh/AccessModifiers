using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace AccesModifiers
{
    internal class Program
    {
        static void Main(string[] args)
    // Task 1 
    //    {
    //        Employee maas = new Employee { Name = "Sebuhi", IsSuccessful = true, Salary = 1000 };
    //        Assistant assistant = new Assistant();


    //        Console.WriteLine($"Evvelki maash: {maas.Salary}");
    //        assistant.GetFeedback(maas);
    //        Console.WriteLine($"Sonraki maash: {maas.Salary}");

    //    }

    //}
    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public bool IsSuccessful { get; set; }
    //    public decimal Salary { get; set; }
      
    //}
    //public class Manager
    //{
    //    protected static void GetPromotion(Employee employee)
    //    {
    //        employee.Salary += 100;
    //    }
    //}
    //public  class Assistant : Manager
    //{
    //    public void GetFeedback(Employee employee)
    //    {
    //        if (employee.IsSuccessful)
    //        {
    //            Manager.GetPromotion(employee);
    //        }
    //    }

    //}
}
// Task 2
//    {
//        Student student = new Student();

//        Console.WriteLine("Adinizi daxil edin:");
//        student.Name = Console.ReadLine();

//        Console.WriteLine("Yashinizi daxil edin:");
//        if (int.TryParse(Console.ReadLine(), out int age))
//        {
//            student.Age = age;
//        }
//        else
//        {
//            Console.WriteLine("Düzgün bir yaş daxil edilmədi.");
//        }

//        Console.WriteLine("Qiymet daxil edin:");
//        if (int.TryParse(Console.ReadLine(), out int grade))
//        {
//            student.Grade = grade;
//        }
//        else
//        {
//            Console.WriteLine("Düzgün bir qiymət daxil edilmədi.");
//        }

//        Console.WriteLine("Ad:" + student.Name);
//        Console.WriteLine("Yash:" + student.Age);
//        Console.WriteLine("Qiymet;" + student.Grade);



//    }

//}
//public class Student
//{
//    private string _name;
//    private int _age;
//    private int _grade;

//    public string Name {
//        get 
//        {
//            return _name;            
//        }
//        set 
//        {
//            if (Regex.IsMatch(value, "^[A-Z][a-zA-Z]*$"))
//                _name = value;
//            else
//            {
//                Console.WriteLine("Adi duzgun daxil edin.Boyuk herfle bashlasin.");
//                Name = Console.ReadLine();
//            }
//        }            
//    }
//    public int Age { get 
//        {
//            return _age;            
//        } 
//        set {
//            if (value>0 && value<100)
//            {
//                _age = value;
//            }
//            else
//            {
//                Console.WriteLine("Verilen deyer yanlishdir, yeniden deyer daxil edin:");
//                if (int.TryParse(Console.ReadLine(), out int result))
//                {
//                    Age = result;
//                }
//                else
//                {
//                    Console.WriteLine("Düzgün bir yaş daxil edilmədi.");
//                }

//            }
//        } 
//    }
//    public int Grade { get
//        {
//            return _grade;
//        } 
//        set 
//        {
//            if (value>=0 && value<=100)
//            {
//                _grade = value;
//            }
//            else
//            {
//                Console.WriteLine("Verilenn deyer yanlishidir, yeniden deyer dacil edin:");
//                if (int.TryParse(Console.ReadLine(), out int result))
//                {
//                    Grade = result;
//                }
//                else
//                {
//                    Console.WriteLine("Düzgün bir qiymət daxil edilmədi.");
//                }

//            }
//        } 
//    }