using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    class Customer
    {
        private int cno;
        private string phno;
        private string name;
        private double ticketCost;

        public void Input()
        {
            Console.Write("Enter Customer Number: ");
            cno = int.Parse(Console.ReadLine());

            Console.Write("Enter Phone Number: ");
            phno = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Ticket Cost: ");
            ticketCost = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Customer Number: " + cno);
            Console.WriteLine("Phone Number: " + phno);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Ticket Cost after Discount: " + ticketCost);
        }
    }
    internal class Case2
    {
        static void Main(string[] args)
        {
            
        }
    }
}
