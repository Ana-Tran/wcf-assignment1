using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MenuOptions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool PrimeNumber(int num);

        [OperationContract]
        int SumOfDigits(int num);

        [OperationContract]
        string ReverseString (string str);

        [OperationContract]
        string PrintHTMLTAGs(string tag, int data);

        [OperationContract]
        string SortNumbers(string sort, string data);
    }   
}
