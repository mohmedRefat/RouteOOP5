using RouteOOP5.Structs;

namespace RouteOOP5.Classes
{
    public class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;


        public string DestinationCountry
        {
            get { return destinationCountry; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }


        public decimal CustomsFee
        {
            get { return customsFee; }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }


        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee
                    + (Weight * 5)
                    + CustomsFee;
            }
        }
    }
}