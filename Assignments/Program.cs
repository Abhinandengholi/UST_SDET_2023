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
using Assignments;
// InsurancePolicy ip=new InsurancePolicy("Healthcare",200,20000);
//Console.WriteLine("Premium amount");
//ip.Display();
//ip.RenewPolicy(21000);
//ip.RenewPolicy();
LifeInsurance li = new("Jeevan", 233, 1200, 65);
li.CalculatePremium();
Console.WriteLine("Life insurance premium amount:"+li.PremiumAmount);
CarInsurance ci = new("Jeevanraksha", 234, 12000, 2000000);
ci.CalculatePremium();
Console.WriteLine(" Car Insurance premium amount:" + ci.PremiumAmount);