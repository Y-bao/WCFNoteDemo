using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client service1Client = new Service1Client();
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.HelloWorld1());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.YbaoHelloWorld2());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.HelloWorld3());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            //Console.WriteLine(service1Client.HelloWorld4());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.HelloWorld5());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.HelloWorld6());
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            service1Client.HelloWorld7();
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Console.WriteLine(service1Client.HelloWorld8());
        }
    }
}
