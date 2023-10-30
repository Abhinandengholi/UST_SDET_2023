/*using Case_Study;
using System.ComponentModel.Design;


int num = 1;
string? title;
do
{
    Console.WriteLine("choose option");
    Console.WriteLine("1.Add Book\n 2.Add Customer\n 3.Place order\n 4.Search for book\n 5.Exit\n ");
    int option = Convert.ToInt32(Console.ReadLine());
    Order or = new Order();
    Booktype[] bt = new Booktype[]
        { new("Alchemist", "Paulo coelho", 198, 243, true, "FantasyFiction"),
        new ("Ikigai", "Hector", 199, 353, true, "Motivation")
        };

    switch (option)
    {
        case 1:
            Console.WriteLine("Book Added");
            foreach (Booktype b in bt)
            {
                b.DisplayDetails();
            }
            break;
        case 2:
            int customerid;
            string? customerName;
            double contactDetail;
            Console.WriteLine("Enter customerid");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Contact details");
            contactDetail = Convert.ToDouble(Console.ReadLine());

            Customer customer = new Customer(customerid, customerName, contactDetail);
            customer.DisplayCustomerDetails();
            break;
        case 3:
            Console.WriteLine("Enter the title");
            title = Console.ReadLine();
            foreach (var book in bt)
            {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine("Enter order placed date");
                    or.OrderPlacedDate = Console.ReadLine();
                    Console.WriteLine("order confirmed");
                    Console.WriteLine("Book title is:{0}\n Book price is:{1} Book availiabilty is:{2}", book.Title, book.Price, book.Availiability);
                    or.Totalprice = book.Price;
                    Console.WriteLine("Book total price:{0}", or.Totalprice);
                }
                else
                {
                    Console.WriteLine("No book availaible");
                }
            }
            break;

        case 4:
            Console.WriteLine("Enter the title");
            title = Console.ReadLine();
            foreach (var book in bt)
            {
                if (book.Title.Equals(title))
                {
                    Console.WriteLine("Book title is:{0}\n Book price is:{1} Book availiabilty is:{2}", book.Title, book.Price, book.Availiability);
                    or.Totalprice = book.Price;
                    Console.WriteLine("Book total price is:{0}", or.Totalprice);
                }



                else
                {
                    Console.WriteLine("No books");
                }
            }


            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
    Console.WriteLine("Do you want to continue?");
    num =Convert.ToInt32( Console.ReadLine());
} while (num!=0);*/
//28/10/2023
using Case_Study;
Customers cust = new Customers(100, "Abhie", "Abhi@example.com");
PhysicalProduct physProd1 = new PhysicalProduct(10, "Realme", 55, 102, 3.5, "140*120");
PhysicalProduct physProd2 = new PhysicalProduct(11, "Pixel", 55, 101, 5.5, "120*110");
DigitalProduct digiProd1 = new DigitalProduct(21, "giftcard1", 35, 400, "www.flipkart.com", "txt");
DigitalProduct digiProd2 = new DigitalProduct(20, "giftcard2", 35, 400, "www.flipkart.com", "txt");
Order ordr = new();
ordr.AddProduct(physProd1);
ordr.AddProduct(physProd2);
ordr.AddProduct(digiProd1);
ordr.AddProduct(digiProd2);


Console.WriteLine("Welcome");
repeat1:
repeat2:
Console.WriteLine("1.Admin 2.customer");
string? choose = Console.ReadLine();
if (choose == "1")
{
repeat:
    Console.WriteLine("1.Add Product 2.View Product 3.Back");
    string? choose1 = Console.ReadLine();
    if (choose1 == "1")
    {
        Console.WriteLine("Products Added");
    }
    else if (choose1 == "2")
    {
        Console.WriteLine("Products");
        foreach (var product in Order.products)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Price: {2}, Stock: {3}", product.Value.ProductId, product.Value.Name, product.Value.Price, product.Value.StockQuantity);
        }
    }
    else if (choose1 == "3")
    {
        goto repeat1;
    }
    goto repeat;
}
else if (choose == "2")
{
    Console.WriteLine("Products");
    
    Console.WriteLine("1.Physical Product 2.Digital Product");
    string? choose2 = Console.ReadLine();
    if (choose2 == "1")
    {
        Console.WriteLine("1.Place Order 2.Contact Support");
        string? choose3 = Console.ReadLine();
        if (choose3 == "1")
        {
            Order customerOrder = new Order
            {
                OrderID = 1,
                ProductID = 10,
                Quantity = 1,
                TotalAmount = 25,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };
            ordr.GetProduct(10);
            Console.WriteLine("Confirm Order? y/n");
            string? choice = Console.ReadLine();
            if (choice == "y")
            {
                cust.PlaceOrder(customerOrder);
                physProd1.PlaceOrder();
                ordr.AddOrder(100, customerOrder);
                ordr.GetCustomerOrders(100);
                Console.WriteLine("Proceed for payment? y/n");
                string? choice1 = Console.ReadLine();
                if (choice1 == "y")
                {
                    physProd1.ProcessPayment();
                    cust.ProcessPayment();
                    cust.ViewOrderHistory();
                    physProd1.DeliverProduct();
                    Order.AddReport(customerOrder);
                }
            }
        }
        else if (choose3 == "2")
        {
            cust.ContactSupport();
        }
    }
    if (choose2 == "2")
    {
        Console.WriteLine("1.Place Order 2.Contact Support");
        string? choose4 = Console.ReadLine();
        if (choose4 == "1")
        {
            Order customerOrder = new Order
            {
                OrderID = 1,
                ProductID = 21,
                Quantity = 1,
                TotalAmount = 25,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };
            ordr.GetProduct(21);
            Console.WriteLine("Confirm? y/n");
            string? choice = Console.ReadLine();
            if (choice == "y")
            {
                cust.PlaceOrder(customerOrder);
                digiProd1.PlaceOrder();
                ordr.AddOrder(100, customerOrder);
                ordr.GetCustomerOrders(100);
                cust.ViewOrderHistory();
                Console.WriteLine("Proceed for payment? y/n");
                string? choice1 = Console.ReadLine();
                if (choice1 == "y")
                {
                    digiProd1.ProcessPayment();
                    cust.ProcessPayment();
                    cust.ViewOrderHistory();
                    digiProd1.DeliverProduct();
                    Order.AddReport(customerOrder);
                }
            }
        }
        else if (choose4 == "2")
        {
            cust.ContactSupport();
        }
    }
}
Console.WriteLine("Do you want to continue? (Y/N");
string? titleread = Console.ReadLine();
if (titleread == "y")
{
    goto repeat2;
}