// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Enter 2 numbers");
int num1, num2, ans;
num1= Convert.ToInt32(Console.ReadLine()); 
num2 = Convert.ToInt32(Console.ReadLine());
ans=num1+num2;
Console.WriteLine(ans);

using System;
using System.Security.Cryptography;

string? s1=" ";
string? s2 = " ";
string? s3 = " ";
s1 =Console.ReadLine();
s2 = Console.ReadLine();
s3 = s1 +" "+ s2;
Console.WriteLine(s3);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.Substring(3));
string[] s=s3.Split(' ');
for (int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
int x = "5";
switch(x)
{ case 1:
        Console.WriteLine("1");
        break;
case 2:
        Console.WriteLine("2");
        break;
case 3:
        Console.WriteLine("3");
break;
default:Console.Writeline("4");
break;



Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
 double  res=calculation.Add(num1, num2);
Console.WriteLine(res);


using Basic_programs;
using System.Xml.Schema;

Electricity eletricity1 = new Electricity(12345,9000,9312,"Abhi");
Console.WriteLine(eletricity1.consumernumber);
Console.WriteLine(eletricity1.consumername);
Console.WriteLine(eletricity1.CalculateBill());

Electricity eletricity2 = new Electricity(23456, 9000, 10000, "Aju");
//double billamount = eletricity.CalculateBill();
Console.WriteLine(eletricity2.consumernumber);
Console.WriteLine(eletricity2.consumername);
Console.WriteLine(eletricity2.CalculateBill());


using Basic_programs;
Employee employee = new Employee(111, "Abhi", "IT", 10000);

Console.WriteLine("Emp id : {0} \n Name : {1} \n Dept : {2} \n  Basicpay : {3}",
    employee.Empid,
    employee.Empname,
    employee.Empdept,
    employee.Basicpay);
//Console.WriteLine("Emplid"+employee.Empid);
//Console.WriteLine(employee.Empname);
//Console.WriteLine(employee.Empdept);
//Console.WriteLine(employee.Basicpay);
//Console.WriteLine(employee.CalculateSalary());
//driver
using Basic_programs;
ArraysEx arr=new ArraysEx();
//arr.Onedim(); 
//arr.Twodim();
arr.Ja();
//20/10/2023
using Basic_programs;
StudentMarks marks = new();
marks.Rollno = 10;
marks.StudName = "Abhi";
marks.Mark1 = 97;
marks.Mark2 = 87;
marks.Mark3 = 93;
marks.DisplayStudentDetials();
Console.WriteLine("Total" +marks.CalculateTotal());
Console.WriteLine("Average" + marks.CalculateAverage());
using Basic_programs;
StudentGrade grade = new ();
grade.Rollno = 180;
grade.StudName = "Amr";
grade.Mark1 = 97;
grade.Mark2 = 77;
grade.Mark3 = 93;
grade.DisplayStudentDetials();
Console.WriteLine("Total" + grade.CalculateTotal());
Console.WriteLine("Average" + grade.CalculateAverage()); 
Console.WriteLine("Grade"+ grade.CalculateGrade());
using Basic_programs;

Console.WriteLine("1.TS 2.NTS");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.Name = "TS1";
        ts.Dept = "cs";
        ts.Specializations = "OS,DBMS,DS";
        ts.sem = 4;
        ts.DisplayStaffDetials();
        ts.DisplayTSStaffDetails();
        break;
        case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.Staffid = 100;
        nts.Name = "NTS1";
        nts.Dept = "Admin";
        nts.Responsibilities = "Attendence";
        nts.Experience = 4;
        nts.DisplayStaffDetials();
        nts.DisplayNTSStaffDetails();
        break;
}
using Basic_programs;

Console.WriteLine("1.TS 2.NTS 3.College 4.Student");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.Name = "TS1";
        ts.Dept = "cs";
        ts.Specializations = "OS,DBMS,DS";
        ts.sem = 4;
        ts.DisplayStaffDetials();
        ts.DisplayTSStaffDetails();
        break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.Staffid = 100;
        nts.Name = "NTS1";
        nts.Dept = "Admin";
        nts.Responsibilities = "Attendence";
        nts.Experience = 4;
        nts.DisplayStaffDetials();
        nts.DisplayNTSStaffDetails();
        break;
        case 3:
        College collg=new College();
        collg.Collegeid = 19678;
        collg.CollegeName = "COET";
        collg.CollegeEstablished = 1999;
        collg.DisplayCollegeDetials();
        break;
    case 4:
        StudentDetails sd=new StudentDetails();
        sd.Rollno = 1;
        sd.StudName = "Abhi";
        sd.City = "LA";
        sd.DisplayStudentDetials();
        break;
}

using Basic_programs;
EV ev = new();
ev.Vehnum = 9746;
ev.Brand = "EXT";
ev.Model = "AA";
ev.setTypeForVeh();
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.Vehnum = 5996;
pv.Brand = "PVT";
pv.Model = "YEY";
pv.Disp();
Console.WriteLine(pv.setTypeForVeh());
 

using Basic_programs;
//Doctor doct = new Doctor();
Doctor doct = new Doctor();

doct.AddNewDoctor(9004,"anj");
doct.DisplayDoctorDetails();
doct.ModifyDoctor(9005,"ab");
doct.DisplayDoctorDetails();
doct.BookApp(12, "Amr");
doct.DelApp("am");
using Basic_programs;
//BankDetails bnk3 = new();
//BankDetails bnk1 = new(123, 323232, "Abhi");
BankDetailsNew bnk2 = new(123, 323232, "Abhi", "Inactive");

BankDetails.Welcomemessage();
//bnk2.Welcomemessage("Abhi");
Console.WriteLine("1.Custid 2.Acc No 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:
        Console.WriteLine("Custid: ");
        //bnk1.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        bnk2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
       // bnk3.GetAccDetails(Convert.ToInt32(Console.ReadLine()));


        break;
    case 2:
        Console.WriteLine("Acc NO: ");
        //bnk1.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        bnk2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
       // bnk3.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("Name: ");
       // bnk1.GetAccDetails(Console.ReadLine());
        bnk2.GetAccDetails(Console.ReadLine());
       // bnk3.GetAccDetails(Console.ReadLine());
        break;
    default:Console.WriteLine("Enter between 1-3");
        break;
}
//BankDetails.ExitMessage();*/
//25/10/2023
//using Basic_programs;
////NGC nGC=new NGC();
////nGC.ArrayListHandling();
///////nGC.Stackhandling();
////nGC.Queuehandling();
////nGC.HashTableHandling();
////nGC.SortedListhandling();
//Basic_programs.GenericCollection gc = new GenericCollection();
//gc.ListHandling();
//gc.SortedListhandling();
//26/10/2023
/*using Basic_programs;
using Basic_programs.ExceptionMessages;
using static Basic_programs.ExceptionMessages.MyException;

ExcepHandling excep=new ExcepHandling(1,105);*/
//try
//{
//    excep.NumCheck();
//}
//catch (ArgumentException )
//{
//    //Console.WriteLine(MyException.exmessagelist[3]);
//    Console.WriteLine(ex.Message);
//}
/*try
{
    excep.NumCheck();
}
catch (Number1Exception ex)
{
    //Console.WriteLine(MyException.exmessagelist[3]);
    Console.WriteLine(ex.Message);
}
try
{
    excep.NumCheck2();
}
catch (Number2Exception ex)
{
    //Console.WriteLine(MyException.exmessagelist[3]);
    Console.WriteLine(ex.Message);
}*/
//try
//{
//    excep.Divide();

//}
//catch (ArithmeticException ex)
//{


//    Console.WriteLine(MyException.exmessagelist[0]);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(MyException.exmessagelist[1]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(MyException.exmessagelist[2]);
//}
//finally
//{
//    Console.WriteLine("done");//release memomry,before exiting the code
//}
//27/10/2023
using Basic_programs;

FileOperations fo=new FileOperations();
fo.CreateFile();
fo.WriteData();
fo.ReadData();
//fo.CopyMoveFile();
//fo.DeleteFile();
fo.FileProperties();

