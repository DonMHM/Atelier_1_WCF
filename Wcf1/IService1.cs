using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int WebAdd(int x, int y);
        [OperationContract] 
        int WebSoustraction(int x, int y);
        [OperationContract]
        int WebMultiply(int x, int y);
        [OperationContract]
        int WebDivision(int x, int y);

    }
}
