using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lib
{
    //参照
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string HalloWorld();
    }
    
    //测试Name属性
    [ServiceContract(Name ="TestName")]
    public interface IService2
    {
        [OperationContract]
        string HalloWorld2();
    }

    //测试Namespace属性
    [ServiceContract(Namespace = "Ybao")]
    public interface ITestNameNamespace
    {
        //IService2 和 IService1 两个契约中拥有一个同名操作 ，一个服务同时实现这两个契约 代码逻辑上 不会出错，但WSDL生成出错！
        //使用Namespace设置独立的名称，将会在独立的WSDL生成该契约的映射，两个WSDL互不影响，默认大的WSDL 将会调用该WSDL
        [OperationContract]
        string HalloWorld();
    }
    //测试ConfigurationName属性
    //用于查找应用程序配置文件中的服务元素的名称。默认值是服务实现类的名称,对自定义宿主的操作没影响
    [ServiceContract(ConfigurationName = "YbaoConfig")]
    public interface ITestConfigurationName
    {
        [OperationContract]
        string HalloWorld3();
    }

    //测试CallbackContract属性
    //可用于显示上传进度
    [ServiceContract(CallbackContract = typeof(IHelloCallbackContract))]
    public interface ITestCallbackContract
    {
        [OperationContract]
        string HalloWorld4();
    }
    
    //测试SessionMode属性
    //该协议两个方法的实现中，输出服务实例的哈希值一样，与其他协议不同，且其他协议中的方法相互也不一样
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface ITestSessionMode
    {
        [OperationContract]
        string HalloWorld5();

        [OperationContract]
        string HalloWorld6();
    }

    //测试ProtectionLevel属性
    [ServiceContract(ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public interface ITestProtectionLevel
    {
        [OperationContract]
        string HalloWorld7();
    }


    //测试没有INoOperationContract
    //会报错...
    //[ServiceContract]
    //public interface INoOperationContract
    //{
    //}
}
