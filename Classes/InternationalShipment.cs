using System;
using RouteOOP3.Interfaces;
using RouteOOP3.Structs;

namespace RouteOOP3.Classes
{
    public class InternationalShipment
        : Shipment, ITrackable, IInsurable
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


        // Constructor

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
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }
            else
            {
                DestinationCountry = "Unknown";
            }


            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }


                // implement estmated cost

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee
                    + (Weight * 5)
                    + CustomsFee;
            }
        }


        // implement PrintShipment

        public override void PrintShipment()
        {
            Console.WriteLine(
                "International Shipment"
            );

            Console.WriteLine(
                $"Tracking Code : {TrackingCode}"
            );

            Console.WriteLine(
                $"Destination Country : " +
                $"{DestinationCountry}"
            );

            Console.WriteLine(
                $"Estimated Cost : " +
                $"{EstimatedCost} EGP"
            );
        }


        // implement ITrackable

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }


        // implement IInsurable

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}