using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    class Mobike
    {
        String bno, phno, name;
        int days, charge;

        public String Bno
        {
            set
            {
                this.bno = value;
            }
            get
            {
                return this.bno;
            }
        }
        public String Phno
        {
            set
            {
                this.phno = value;
            }
            get
            {
                return phno;
            }
        }
        public String Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public int Days
        {
            set
            {
                this.days = value;
            }
            get
            {
                return this.days;
            }
        }

        public int Charge
        {
            set
            {
                this.charge = value;
            }
            get
            {
                return this.charge;
            }
        }

        public void input()
        {
            Console.Write("Enter booking number (bno): ");
            bno = Console.ReadLine();

            Console.Write("Enter phone number (phno): ");
            phno = Console.ReadLine();

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter number of days: ");
            days = int.Parse(Console.ReadLine());
            compute();
        }

        public void compute()
        {
            if (days <= 5)
            {
                charge = days * 500;
            }
            else if (days <= 10)
            {
                charge = 2500 + (days - 5) * 400;
            }
            else
            {
                charge = 2500 + 2000 + (days - 10) * 200;
            }    
        }

        
        public void display()
        {
            Console.WriteLine("Booking Number (bno): " + bno);
            Console.WriteLine("Phone Number (phno): " + phno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Number of Days: " + days);
            Console.WriteLine("Total Charge: " + charge);
        }

    }
    internal class Case1
    {
        
        static void Main(string[] args)
        {   /*
            Mobike m=new Mobike(); 
            m.input();
            m.display();
            */

            Mobike m2= new Mobike();
            m2.Bno = "129j";
            m2.Name = "SSM";
            m2.Phno = "1234567890";
            m2.Days = 12;
            m2.compute();
            Console.WriteLine("Bno="+m2.Bno);
            Console.WriteLine("Phone="+m2.Phno);
            Console.WriteLine("Name="+m2.Name);
            Console.WriteLine("Days="+m2.Days);
            Console.WriteLine("Charge="+m2.Charge);
        }
    }
}
