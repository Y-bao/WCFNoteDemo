using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Lib.Service1), new Uri("http://localhost:8733/WcfDemo/ServiceContract/")))
            {
                WSDualHttpBinding binding = new WSDualHttpBinding();
                host.AddServiceEndpoint(typeof(Lib.IService1), binding, "IService1");
                host.AddServiceEndpoint(typeof(Lib.IService2), binding, "IService2");
                host.AddServiceEndpoint(typeof(Lib.ITestNameNamespace), binding, "ITestNameNamespace");
                host.AddServiceEndpoint(typeof(Lib.ITestConfigurationName), binding, "ITestConfigurationName");
                host.AddServiceEndpoint(typeof(Lib.ITestCallbackContract), binding, "ITestCallbackContract");
                host.AddServiceEndpoint(typeof(Lib.ITestSessionMode), binding, "ITestSessionMode");
                host.AddServiceEndpoint(typeof(Lib.ITestProtectionLevel), binding, "ITestProtectionLevel");
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
