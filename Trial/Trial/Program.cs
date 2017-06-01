using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter account name");
            //string accountName = Console.ReadLine();
            //Console.WriteLine("Enter throughput");
            //var throughput = Convert.ToInt32(Console.ReadLine());

            //MyOtherFunction(accountName, throughput);//.GetAwaiter().GetResult();
            AnotherFunction();
        }

        static void MyOtherFunction(string accountName, int throughput)
        {
            Console.WriteLine("Entered account name ={0} and throughput is ={1}", accountName, throughput);
            
            switch (throughput)
            {
                case 1:
                    Console.WriteLine("You have entered 1");
                    break;

                case 2:
                    Console.WriteLine("You have entered 2");
                    break;
            }

        }


        static void AnotherFunction ()
        {
            Console.WriteLine("Choose the collection for which you want to change the throughput");
            string collectionName = Console.ReadLine();
            Console.WriteLine("Choose the resource for which you want to change the throughput");
            string resourceName = Console.ReadLine();
            
            
                if (collectionName == "afs" && resourceName == "azure")
                    {
                        Console.WriteLine("Bazingaa!");   
                    }

                else if (collectionName == "ifs" && resourceName == "azure")
                    {
                        Console.WriteLine("Double Bazingaa!");
                    }
            
        }
        
    }
}
