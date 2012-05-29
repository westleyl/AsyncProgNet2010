using System.ServiceModel;
using System.ServiceModel.Web;

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
