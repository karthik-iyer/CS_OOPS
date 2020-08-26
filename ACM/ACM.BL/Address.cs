namespace ACM.BL
{
    public class Address : EntityBase, ILog
    {
        public int AddressId { get; }
        public string StreetLine1 { get; set; }

        public string StreetLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string AddressType { get; set; }

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public override bool Validate()
        {
            return !string.IsNullOrWhiteSpace(StreetLine1) &&
                   !string.IsNullOrWhiteSpace(City)  &&
                   !string.IsNullOrWhiteSpace(State) &&
                   !string.IsNullOrWhiteSpace(PostalCode) &&
                   !string.IsNullOrWhiteSpace(Country) &&
                   !string.IsNullOrWhiteSpace(AddressType);
        }

        public string Log() => $" Status: {EntityState.ToString()} , {AddressType} : {StreetLine1} , {StreetLine2} , {City} , {State} - {PostalCode}, {Country}";
    }
}