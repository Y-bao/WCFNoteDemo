using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lib
{
    [ServiceContract(Namespace ="ybao", SessionMode= SessionMode.Required)]
    public interface IService1
    {
        //参照
        [OperationContract]
        string HelloWorld1();

        //测试Name属性
        [OperationContract(Name = "YbaoHelloWorld2")]
        string HelloWorld2();

        //
        [OperationContract(Action = "ybao/IService1/HelloWorld3")]
        string HelloWorld3();

        //
        [OperationContract(ReplyAction = "*",Action = "*")]
        string HelloWorld4();

        //
        [OperationContract(AsyncPattern=true)]
        IAsyncResult BeginHelloWorld5(AsyncCallback asyncCallback,Object obj);
        string EndHelloWorld5(IAsyncResult result);

        //
        [OperationContract(IsInitiating=true)]
        string HelloWorld6();

        //
        [OperationContract(IsOneWay=true)]
        void HelloWorld7();

        //
        [OperationContract(IsTerminating=true)]
        string HelloWorld8();
    }
}
