using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsConsoleApp
{
    internal class userDefinedException
    {
        class smException:Exception
        {
            public smException(string message): base(message)
            {
                
            }

        }
        static void Main(string[] args)
        {
            try
            {
                throw new smException("sm error");
            }
            catch (smException e) 
            { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
