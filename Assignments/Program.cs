// Assignment 18/10/2023
/*using Assignments;

Student student1 = new ("Abhi",45, 80, 15);
Console.WriteLine(student1.student_name);
Console.WriteLine("Average"+student1.calculateAverage());
//19/10/2023
using Assignments;

Product[] prod = new Product[3];
prod[0] = new Product("SAMSUNG",10000,2);
prod[1] = new Product("Apple", 30000, 3);
prod[2] = new Product("Realme", 20000, 5);
//prod[0]=SetPrice(20000)
foreach (Product product in prod)
{
    product.DisplayProduct();
    product.ProductValue();
}
using Assignments;
Student[] student = new Student[3];
student[0] = new Student("Abhi", "A",new int[] {90,80,70});
student[1] = new Student("Aju", "B",new int[] { 60, 90, 40 });
student[2] = new Student("Riju","B",new int[] { 50, 80, 50 });

foreach (Student st in student)
{
    st.DisplayStudent();
    st.CalculateAverage();
    st.GetMarkssummary();
    Console.WriteLine();
}

using Assignments;


Console.WriteLine("1.EP 2.DP 3.CP ");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        ElectronicsProduct ep = new ElectronicsProduct("Samsung",10000,1,12);
        ep.DisplayProduct();
        ep.DisplayWarrentyPeriod();
       
        break;
    case 2:
        DigitalProduct dp=new DigitalProduct("Samsung", 100000,2,12,"MP3");
        
        dp.DisplayDigitalProduct();
        dp.DisplayProduct();
        break;
    case 3:
        ClothingProduct cp = new ClothingProduct("RM", 30000, 2, "Medium");
      
        cp.DisplayProduct();
        cp.DisplaySize();
       
        break;
    
}

using Assignments;
Employee emp = new(12, "Abhi", "nand", 17);
emp.DisplayInfo();
using Assignments;
Circle circle = new Circle()
{
    Radius =4
};
Rectangle rect = new Rectangle
{
    Width = 10,
    Length = 10
};
circle.Draw();
rect.Draw();*/
//using Assignments;
// InsurancePolicy ip=new InsurancePolicy("Healthcare",200,20000);
//Console.WriteLine("Premium amount");
//ip.Display();
//ip.RenewPolicy(21000);
//ip.RenewPolicy();
//LifeInsurance li = new("Jeevan", 233, 1200, 65);
//li.CalculatePremium();
//Console.WriteLine("Life insurance premium amount:"+li.PremiumAmount);
//CarInsurance ci = new("Jeevanraksha", 234, 12000, 2000000);
//ci.CalculatePremium();
//Console.WriteLine(" Car Insurance premium amount:" + ci.PremiumAmount);

/*using Assignments;
using System.Security.Cryptography.X509Certificates;

Customer cust1=new (1,"Abhi","6473553763",2300.4);
Customer cust2 = new (2, "Amr", "6474553763", 2600.4);
Customer cust3 = new (3, "Aju", "6473353763", 2360.4);
List<Customer> cust=new List<Customer>()
{ cust1,cust2,cust3};
     void SearchCust(string phonenumber)

{
    Customer cus = null;
    foreach (var i in cust)
    {

        if (i.PhoneNumber == phonenumber)
        {
            cus = i;
            // Console.WriteLine("name:{0}\t Balance:{1}\t", i.Name, i.Balance);
            break;
        }
    }
        if (cus != null) { Console.WriteLine("name:{0}\t Balance:{1}\t", cus.Name, cus.Balance); }

    
    else
    {
        Console.WriteLine("Customer Deatails not found or phonenumber not match");
    }

    }

     void DisplayCustomer()
    {
        foreach (var i in cust)
        {
            Console.WriteLine("Customer id:{0}\t CustomerName:{1}\t Customer Phonenumber:{2}\t Balance{3}\t", i.CustomerId, i.Name, i.PhoneNumber, i.Balance);
        }
    }
    
   

SearchCust("6473553763");
SearchCust("6543544366");
DisplayCustomer();
using Assignments;
CallRecord clr1 = new(1, 7846586856, 21);
CallRecord clr2 = new(2, 8764486438, 11);
CallRecord clr3 = new(3, 76743764376, 31);
CallRecord.clr.Add(1,clr1)
CallRecord.clr.Add(2,clr2)
CallRecord.clr.Add(3,clr3)
CallRecord.CallHistory(7846586856);
CallRecord.TotalCalls();
using Assignments;
Patient pat = new(1, "Aji", 125, "Maleria");
try
{
    pat.AddPatient(pat);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message );
}
using Assignments;
using Assignments.ExceptionMesages;

MedicalRecord mrec = new(1, "Aji", 125, "Maleria",12,2340);
try
{
    MedicalRecord.AddRecord(mrec);
}
catch (InvalidPatientDataException ex)
{
    Console.WriteLine(ex.Message);
}
MedicalRecord mrec1 = new(1, "Adi", 125, "fever", 12, 2340);
try
{
    MedicalRecord.AddRecord(mrec1);
}
catch (InvalidMedicalDataException ex)
{
    Console.WriteLine(ex.Message);
}

using Assignments;
repeat:
Console.WriteLine("choose option");
Console.WriteLine("1.Add Patient\n 2.View Patient\n 3.Exit ");
int option = Convert.ToInt32(Console.ReadLine());
if (option == 1)
{
    Console.WriteLine("Enter patient id:");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter patient name:");
    string? name = Console.ReadLine();
    Console.WriteLine("Enter age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Diagnosis:");
    string? diagnosis = Console.ReadLine();
    Patient pat = new(id, name, age, diagnosis);
    Patient.PatientDetail(pat);
}
else if (option == 2)
{
    Patient.ViewPatientData();
}
Console.WriteLine("Do you want to continue?Y/N");
string? title=Console.ReadLine();
if (title == "Y") 
{
    goto repeat;
}
using Assignments;
MedicalHistory mh1 = new MedicalHistory(1, 10, "fever", "11/10/2023");
MedicalHistory mh2 = new MedicalHistory(2, 20, "Maleria", "13/10/2023");
MedicalHistory mh3 = new MedicalHistory(3, 30, "chickengunia", "17/10/2023");

repeat:
Console.WriteLine("1.Add Medical History\n 2.View Medical History\n 3.Exit ");
int option = Convert.ToInt32(Console.ReadLine());
if (option == 1)
{
    MedicalHistory.AddMedicalHistory(mh1);
    MedicalHistory.AddMedicalHistory(mh2);
    MedicalHistory.AddMedicalHistory(mh3);
}
else if (option == 2)
{
    MedicalHistory.ViewMHData();
}
Console.WriteLine("Do you want to continue?Y/N");
string? title = Console.ReadLine();
if (title == "Y")
{
    goto repeat;
}
//30/10/2023
using Assignments;
var typ1 = "double";
var typ2 = 2;
RoomReservation<string>.RoomBook(123, ref typ1);
RoomReservation<int>.RoomBook(101, ref typ2);
RoomReservation<string>.RoomCancel(123);
//Assignment2
using Assignments;
var typ1 = "Phone1";
var typ2 = 1010;
var typ3 = "phone2";
Products<string>.AddProduct(1, ref typ1, 100, 2);
Products<int>.AddProduct(2, ref typ2, 50, 3);
Products<string>.UpdateProduct(1, typ3);
Products<string>.DeleteProduct(2);
Products<string>.SearchProduct(1);

//31/10/2023 Assignment
using Assignments;
public delegate double Empl(double performncrate);
class Program
{
    public static void Main(string[] args) 
    {

    
    repeat:
        Console.WriteLine("Enter Employee ID:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name:");
        string? b = Console.ReadLine();
        Employee1 emply = new();
        emply.EmployeeID = a;
        emply.Name = b;
        Console.WriteLine("Bonus Calculation Method:");
        Console.WriteLine("1. Performance Threshold 2. Department Specific Rules");
        string? choose = Console.ReadLine();
        if (choose == "1")
        {
            Empl empl = Employee1.BonusCalculation;
            Console.WriteLine("Enter Performance Threshold:");
            Console.WriteLine(empl.Invoke(Convert.ToDouble(Console.ReadLine())));
        }
        else if (choose == "2")
        {
            Empl empl = Employee1.CalculateBonus;
            Console.WriteLine("Enter Department Spcific Rule Rate:");
            Console.WriteLine(empl.Invoke(Convert.ToDouble(Console.ReadLine())));
        }
        Console.WriteLine("Do you want to continue? (Y/N");
        string? titleread = Console.ReadLine();
        if (titleread == "y")
        {
            goto repeat;
        }
    }
}
using Assignments;

public delegate void Htl();

class Program
{
    public static void Main(string[] args)
    {

        HotelEvent hotelEvent = new HotelEvent("DJFunk", "11-10-23", "Tvm", 1000);
        HotelEvent hotelEvent1 = new HotelEvent("AmigozDj", "03-10-23", "Tvm", 4000);
        HotelEvent.AddEvent(hotelEvent);
        HotelEvent.AddEvent(hotelEvent1);
        Htl hotlevt2 = HotelEvent.RegisterEvent;
        Htl hotlevt3 = HotelEvent.RegStatus;
        Htl objall = hotlevt2 + hotlevt3;
        objall.Invoke();
    }
}
*/
//1/11/2023
using Assignments;
//TourismDestination.Sorting();
TouristDestination.TouristSpot();




