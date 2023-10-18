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


//driver
using Basic_programs;

Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
 double  res=calculation.Add(num1, num2);
Console.WriteLine(res);*/


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