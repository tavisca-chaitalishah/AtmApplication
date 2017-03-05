using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmTransactionMachine atmObject = new AtmTransactionMachine();
            atmObject.UserTranscation();
        }
    }
}
