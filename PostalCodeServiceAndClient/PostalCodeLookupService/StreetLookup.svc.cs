using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PostalCodeLookup
{
    public class StreetLookup : IStreetLookup
    {
        public StreetData GetStreet(string postalCode)
        {
            return StreetData.FindPostalCode(postalCode);
        }
    }
}
