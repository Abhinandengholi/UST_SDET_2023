using Case_Study;
using System.ComponentModel.Design;

//String? a = "YES";
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
} while (num!=0);