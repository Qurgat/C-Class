using System;
namespace Defining{
    class Program
    {
        static void Main(string[]args)
        {
            Book b1 = new Book("War and Peace", "leo",825);
            Book b2 = new Book("Tears and Joy", "The 5th",125);
            Book b3 = new Book("Blood and water", "Alex",17);
            Book b4 = new Book("Me, myself and I", "They",825);
           Console.WriteLine(b1.GetDescription());
           Console.WriteLine(b2.GetDescription());
        }
        
    }
}