using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PostalCodeLookup
{
    [ServiceContract]
    public interface IStreetLookup
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "street/{postcode}",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        StreetData GetStreet(string postcode);
    }
}
