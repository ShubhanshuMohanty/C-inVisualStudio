using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    internal class refOut
    {
        public static void smRef(ref int a)
        {
            a = 10;
        }
        public static void smCal(int n1,int n2,out int rem,out int que)
        {
            rem=n1%n2;
            que=n1/n2;  
        }
        static void Main(string[] args)
        {
            int a = 20;
            smRef(ref a);
            Console.WriteLine(a);
            int n1=10,n2=4,rem, que;
            smCal(n1,n2,out rem,out que);
            Console.WriteLine("rem="+rem+"\nque="+que);
        }
    }
}
