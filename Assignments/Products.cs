using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    
        internal class Products<T>
        {
            private int ProductId;
            private T Name;
            private double Price;
            private int Quantity;

            public Products(int productId, T name, double price, int quantity)
            {
                ProductId1 = productId;
                Name1 = name;
                Price1 = price;
                Quantity1 = quantity;
            }

            public int ProductId1 { get => ProductId; set => ProductId = value; }
            public T Name1 { get => Name; set => Name = value; }
            public double Price1 { get => Price; set => Price = value; }
            public int Quantity1 { get => Quantity; set => Quantity = value; }

            public static List<Products<T>> list = new();

            public static void AddProduct(int productid, ref T name, double price, int quantity)
            {
                Products<T> prod = new(productid, name, price, quantity);
                list.Add(prod);
                Console.WriteLine("Product Added {0}", prod.Name);
            }
            public static void UpdateProduct(int productid, T name)
            {
                foreach (var i in list)
                {
                    if (i.ProductId == productid)
                    {
                        i.Name = name;
                    }
                }
                Console.WriteLine("Product Name Updated to {0}", name);
            }
            public static void DeleteProduct(int productid)
            {
                foreach (var i in list)
                {
                    if (i.ProductId == productid)
                    {
                        list.Remove(i);
                    }
                    Console.WriteLine("Product Deleted");
                }
            }
            public static void SearchProduct(int id)
            {
                foreach (var i in list)
                {
                    if (i.ProductId == id)
                    {
                        Console.WriteLine("Product Found\nId:{0},\tName:{1},\tPrice:{2},\tQuantity:{3}", i.ProductId, i.Name, i.Price, i.Quantity);
                    }

                }
            }
        }
    }

