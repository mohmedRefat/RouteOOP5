using System;
using RouteOOP3.Interfaces;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class ExpressShipment
        : Shipment, ITrackable, IInsurable
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


        // Constructor

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
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }


        // implement estmated cost

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee
                    + (Weight * 5)
                    + ExtraFee;
            }
        }


        // implement Printshipment

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");

            Console.WriteLine(
                $"Tracking Code : {TrackingCode}"
            );

            Console.WriteLine(
                $"Extra Fee : {ExtraFee} EGP"
            );

            Console.WriteLine(
                $"Estimated Cost : {EstimatedCost} EGP"
            );
        }


        // implement itrackable

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }


        // implement IInsurable

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}