


var employees = new List<Employee>()
{
    new Employee()
    {
        Id = 1,
        FirstName = "Alijon",
        LastName = "Zabirov",
        Age = 24,
        PhoneNumber = "881667007",
        Salary = 4000
    },
    new Employee()
    {
        Id = 2,
        FirstName = "Nurullo",
        LastName = "Sulaymonov",
        Age = 30,
        PhoneNumber = "908765432",
        Salary = 8000
    },
    new Employee()
    {
        Id = 3,
        FirstName = "Shodmon",
        LastName = "Inoyatzoda",
        Age = 26,
        PhoneNumber = "987009988",
        Salary = 7800
    },
};

//Section 3
var newList1 = new List<Employee>{
    new Employee {
        Id = 4,
        FirstName = "Akmal",
        LastName = "Narziev",
        Age = 15,
        PhoneNumber = "904363236",
        Salary = 5000
    },
     new Employee{
        Id = 5,
        FirstName = "Samir",
        LastName = "Samirov",
        Age = 30,
        PhoneNumber = "88166777",
        Salary = 3000
    },
};
employees.AddRange(newList1);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("-------------------------");
}
System.Console.WriteLine("***************************");


//Section 4
List<Employee> sortedList = employees.OrderBy(e => e.Salary).ToList();
foreach (var item in sortedList)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");


//Section 5
employees.RemoveAll(e => e.Age < 25);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 6

var f = employees.FindAll(e => e.Salary >= 5000);

foreach (var item in f)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

//Section 7

var emp = employees.FirstOrDefault(e => e.Id == 3);
employees.Remove(emp);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");

// Section 8

bool found = employees.Exists( e=> e.FirstName == "Jura");
if(!found)
{
    var newEmp = new Employee();
    newEmp.FirstName = "Jura";
    newEmp.Salary = 50;
    newEmp.Age = 16;
    employees.Insert(1,newEmp);
}




// Section 9
var emplo = new List<Employee>(){
    new Employee {
        Id = 6,
        FirstName = "yusufjon",
        LastName = "mirzoev",
        Age = 15,
        PhoneNumber = "904363236",
        Salary = 5000
    },
     new Employee{
        Id = 7,
        FirstName = "Samir",
        LastName = "Samirov",
        Age = 30,
        PhoneNumber = "88166777",
        Salary = 3000
    },

};
employees.InsertRange(1,emplo);
foreach (var item in employees)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("-------------------------");
}
System.Console.WriteLine("***************************");



//Section 10
List<Employee> reversesortedList = employees.OrderByDescending(e => e.Salary).ToList();
foreach (var item in reversesortedList)
{
    System.Console.WriteLine(item.Id);
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.Age);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine("--------------------------------");

}
System.Console.WriteLine("***************************");


public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Salary { get; set; }

    public Employee(){}
    public Employee(string name, string surname)
    {
        FirstName = name;
        LastName = surname;
    }

    public int GetBirthYear()
    {
        return 2024 - Age;
    }
}