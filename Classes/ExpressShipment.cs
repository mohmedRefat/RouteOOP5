using RouteOOP5.Structs;

namespace RouteOOP5.Classes
{
    public class ExpressShipment : Shipment
    {
        private decimal extraFee;


        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }


        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            ExtraFee = extraFee;
        }


        public override decimal EstimatedCost
        {
            get
            {
                return base.DeliveryFee
                    + (Weight * 5)
                    + ExtraFee;
            }
        }
    }
}