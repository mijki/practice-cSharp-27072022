using PracticeProject;
//Date time practice
DateTime hireDate = new DateTime(2022, 4, 28);
Console.WriteLine($"The hire date was {hireDate:D}");

DateTime exitDate = new DateTime(2022, 5, 28);
Console.WriteLine($"The exit date was {exitDate:D}");

TimeSpan spentTime = exitDate - hireDate;
Console.WriteLine($"The employee was here for {spentTime.Days} days");

Console.WriteLine($"Please enter the hourly wage: ");
var hourlyWage = double.Parse(Console.ReadLine());

Console.WriteLine($"Please enter the number of hours worked: ");
var numberOfWorkHours = double.Parse(Console.ReadLine());
Utilities.CalculateAnnualWage(hourlyWage, numberOfWorkHours);


//Playing with strings
string inputStringToModify;
Console.WriteLine($"Please enter the string you want to modify: ");
StringPractice.ModifyString(inputStringToModify = Console.ReadLine());

Console.WriteLine("Please enter your firstname: ");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name: ");
string lastName = Console.ReadLine();

StringPractice.CreateUserName(firstName, lastName);

//Playing with OOP

Employee johnAdams = new Employee("John","Adams",25,"johnadams@gmail.com",001,20.99,new DateTime (1993,3,13));
johnAdams.PerformWork(52);
johnAdams.ReceiveWage(true);

//OOP - Encapsulation
EncapsulatedEmployee encEmp = new EncapsulatedEmployee("Sandra",15);
Console.WriteLine(encEmp.firstName);
Console.WriteLine(Convert.ToString(encEmp.GetAge()));

//OOP - Inheritance
Manager jessicaJohns = new Manager("Jessica", "Johns", 25, "johnadams@gmail.com", 002, 25.99, new DateTime(1993, 3, 13));
jessicaJohns.PerformWork(64);
jessicaJohns.DisplayEmployeeDetails();
jessicaJohns.AttendOnMeetings();

JuniorResearcher bobJones = new JuniorResearcher("Bob", "Jones", 25);

//OOP - Polymorphism
