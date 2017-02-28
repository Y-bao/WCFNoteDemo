using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lib
{
    public class Service1 : IService1,IService2, ITestNameNamespace, ITestConfigurationName, ITestCallbackContract, ITestSessionMode,ITestProtectionLevel
    {
        public string HalloWorld()
        {
            if (OperationContext.Current.Channel.LocalAddress.ToString().IndexOf("IService1") >= 0)
            {
                Console.WriteLine("参照");
            }
            else {
                Console.WriteLine("测试Namespace属性");
            }
            return "HalloWorld";
        }

        public string HalloWorld2()
        {
            Console.WriteLine("测试Name属性");
            return "HalloWorld2";
        }

        public string HalloWorld3()
        {
            Console.WriteLine("测试ConfigurationName属性");
            return "HalloWorld3";
        }

        public string HalloWorld4()
        {
            Console.WriteLine("测试CallbackContract属性");
            IHelloCallbackContract callerProxy = OperationContext.Current.GetCallbackChannel<IHelloCallbackContract>();
            callerProxy.onTextCallback("CallBack");
            Console.WriteLine("当前实例的哈希值：{0}", this.GetHashCode().ToString("x"));
            return "HalloWorld4";
        }

        public string HalloWorld5()
        {
            Console.WriteLine("测试SessionMode属性");
            Console.WriteLine("当前实例的哈希值：{0}", this.GetHashCode().ToString("x"));
            return "HalloWorld5";
        }

        public string HalloWorld6()
        {
            Console.WriteLine("测试SessionMode属性");
            Console.WriteLine("当前实例的哈希值：{0}", this.GetHashCode().ToString("x"));
            return "HalloWorld6";
        }

        public string HalloWorld7()
        {
            Console.WriteLine("测试ProtectionLevel属性");
            Console.WriteLine("当前实例的哈希值：{0}", this.GetHashCode().ToString("x"));
            return "HalloWorld7";
        }

        public Service1()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("{0} - 服务被实例化。", DateTime.Now.ToLongTimeString());
        }
        // 在析构函数中也输出信息  
        ~Service1()
        {
            Console.WriteLine("{0} - 服务实例被释放。", DateTime.Now.ToLongTimeString());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
