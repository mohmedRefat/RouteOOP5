using RouteOOP5.Structs;

namespace RouteOOP5.Classes
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }
    }
}