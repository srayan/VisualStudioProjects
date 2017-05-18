using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;

//Look into publishing this as an Azure Web Job. Lower costs.

namespace Evolution
{
    using EmailHandlerModule;
    class Program
    {
        static void Main(string[] args)
        {
            for (int iNum=0;iNum<50;iNum++)
            {
                //Pass the txt file with email addresses that spam you
                EmailHandlerModule.EmailHandler();
                Thread.Sleep(3000);
            }
            
        }
    }
}
