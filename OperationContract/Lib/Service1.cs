using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lib
{
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class Service1 : IService1
    {
        public string HelloWorld1()
        {
            Console.WriteLine("HelloWorld1");
            return "HelloWorld1";
        }

        public string HelloWorld2()
        {
            Console.WriteLine("HelloWorld2");
            return "HelloWorld2";
        }

        public string HelloWorld3()
        {
            Console.WriteLine("HelloWorld3");
            return "HelloWorld3";
        }

        public string HelloWorld4()
        {
            Console.WriteLine("HelloWorld4");
            return "HelloWorld4";
        }
        
        public IAsyncResult BeginHelloWorld5(AsyncCallback asyncCallback, Object obj)
        {
            Console.WriteLine("BeginHelloWorld5");
            return new CompletedAsyncResult<string>(QueryWeatherFromRemoteSite("HelloWorld5"));
        }

        static Task<string> QueryWeatherFromRemoteSite(string city)
        {
            return Task.FromResult(city);
        }
        public string EndHelloWorld5(IAsyncResult result)
        {
            Console.WriteLine("EndHelloWorld5");
            return result.AsyncState as string;
        }


        public string HelloWorld6()
        {
            Console.WriteLine("HelloWorld6");
            return "HelloWorld6";
        }

        public void HelloWorld7()
        {
            Console.WriteLine("HelloWorld7");
        }

        public string HelloWorld8()
        {
            Console.WriteLine("HelloWorld8");
            return "HelloWorld8";
        }


        //Type t = typeof(IService1);
        //System.Reflection.MemberInfo[] method = t.GetMember("HelloWorld3");
        //    if (method != null)
        //    {
        //        OperationContractAttribute operationContract = CustomAttributeExtensions.GetCustomAttribute<OperationContractAttribute>(method[0]);

        //Console.WriteLine(operationContract.Action);
        //        Console.WriteLine(operationContract.Name);
        //        Console.WriteLine(operationContract.ProtectionLevel);
        //        Console.WriteLine(operationContract.HasProtectionLevel);
        //        Console.WriteLine(operationContract.ReplyAction);
        //        Console.WriteLine(operationContract.AsyncPattern);
        //        Console.WriteLine(operationContract.IsTerminating);
        //        Console.WriteLine(operationContract.IsTerminating);
        //        Console.WriteLine(operationContract.IsOneWay);
        //    }


        class CompletedAsyncResult<T> : IAsyncResult
        {
            Task<T> task;
            ManualResetEvent waitHandle = new ManualResetEvent(false);

            public CompletedAsyncResult(Task<T> task)
            {
                this.task = task;
                task.ContinueWith(_ => waitHandle.Set());
            }

            #region IAsyncResult Members

            public object AsyncState { get { return task.Result; } }
            public WaitHandle AsyncWaitHandle { get { return waitHandle; } }
            public bool CompletedSynchronously { get { return true; } }
            public bool IsCompleted { get { return task.IsCompleted; } }

            #endregion          
        }
    }
}
