using System;
using RouteOOP3.Interfaces;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    
    public class StandardShipment
        : Shipment, ITrackable, IInsurable
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


        // implement estmated cost

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }


        // implement Printshipment

        public override void PrintShipment()
        {
            Console.WriteLine("standard shipment");

            Console.WriteLine(
                $"Tracking Code : {TrackingCode}"
            );

            Console.WriteLine(
                $"Description : {Description}"
            );

            Console.WriteLine(
                $"Estimated Cost : {EstimatedCost} EGP"
            );
        }


        // implement itrackable

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }


        // implement iinsurable

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}