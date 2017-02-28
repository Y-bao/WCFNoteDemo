﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public interface IHelloCallbackContract
    {
        [OperationContract(IsOneWay = true)]
        void onTextCallback(string msg);
    }
}
