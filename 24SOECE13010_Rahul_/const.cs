using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13010_Rahul_
{

    class Book
    {

        int id;
        string title;
        string author;
        int price;
        public Book()
        {
            Console.WriteLine("Enter Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Title:");
            title = Console.ReadLine();
            Console.WriteLine("Enter Author:");
            author = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void Bookdetalis()
        {
            Console.WriteLine("Book ID:" + id);
            Console.WriteLine("Book Title:"+title);
            Console.WriteLine("Book Author:"+author);
            Console.WriteLine("Book Price:" + price);
        }
    }
    internal class @const
    {
        public static void Main(string[] args)
        {
            Book []book = new Book[5];


            for (int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();
            }

            for (int i = 0;i < book.Length; i++)
            {
                book[i].Bookdetalis();
            }
        }
    }
}
