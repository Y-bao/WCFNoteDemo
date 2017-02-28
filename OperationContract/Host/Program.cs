using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Lib.Service1), new Uri("http://localhost:8733/WcfDemo/OperationContract/")))
            {
                WSDualHttpBinding binding = new WSDualHttpBinding();
                host.AddServiceEndpoint(typeof(Lib.IService1), binding, "IService1");
                host.Description.Behaviors.Add(new ServiceMetadataBehavior() { HttpGetEnabled = true });
                host.Opened += (sd, arg) => Console.WriteLine("服务已启动。");
                try
                {
                    host.Open();
                    while (true)
                    {
                        string key = Console.ReadLine();
                        if (string.Equals(key, "exit"))
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("服务出现错误，详情如下：");
                    Console.WriteLine(ex.Message);
                }
                host.Close();
            }
        }
    }
}
