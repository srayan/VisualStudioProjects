﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            EmailHandlerModule.EmailHandler();

            //Console.ReadLine();
        }
    }
}