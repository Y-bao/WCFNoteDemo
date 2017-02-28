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
            Console.WriteLine("");
            Console.WriteLine("**********************************参照*************************************");
            Service1Client client = new Service1Client();
            Console.WriteLine(client.HalloWorld());

            Console.WriteLine("");
            Console.WriteLine("******************************测试Name属性*********************************");
            TestNameClient testNameClient = new TestNameClient();
            Console.WriteLine(testNameClient.HalloWorld2());

            Console.WriteLine("");
            Console.WriteLine("***************************测试Namespace属性*******************************");
            TestNameNamespaceClient testNameNamespaceClient = new TestNameNamespaceClient();
            Console.WriteLine(testNameNamespaceClient.HalloWorld());

            Console.WriteLine("");
            Console.WriteLine("***********************测试ConfigurationName属性***************************");
            TestConfigurationNameClient testConfigurationNameClient = new TestConfigurationNameClient();
            Console.WriteLine(testConfigurationNameClient.HalloWorld3());

            Console.WriteLine("");
            Console.WriteLine("************************测试CallbackContract属性***************************");
            HelloCallback helloCallback = new HelloCallback();
            InstanceContext instanceContext = new InstanceContext(helloCallback);
            TestCallbackContractClient testCallbackContractClient = new TestCallbackContractClient(instanceContext);
            Console.WriteLine(testCallbackContractClient.HalloWorld4());

            Console.WriteLine("");
            Console.WriteLine("**************************测试SessionMode属性******************************");
            TestSessionModeClient testSessionModeClient = new TestSessionModeClient();
            Console.WriteLine(testSessionModeClient.HalloWorld5());
            Console.WriteLine(testSessionModeClient.HalloWorld6());

            Console.WriteLine("");
            Console.WriteLine("**************************测试ProtectionLevel属性******************************");
            TestProtectionLevelClient testProtectionLevelClient = new TestProtectionLevelClient();
            Console.WriteLine(testProtectionLevelClient.HalloWorld7());
        }

        class HelloCallback : ITestCallbackContractCallback
        {
            public void onTextCallback(string msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
