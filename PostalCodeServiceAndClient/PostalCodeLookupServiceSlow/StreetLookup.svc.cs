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
