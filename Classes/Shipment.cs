using System;
using RouteOOP5.Structs;
using RouteOOP5.Interfaces;

namespace RouteOOP5.Classes
{
    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;


        // Destination property
        // public read and write

        public DeliveryAddress Destination { get; set; }




        // Static field

        public static int TotalShipmentsCreated;


        // Static constructor

        static Shipment()
        {
            TotalShipmentsCreated = 0;

            Console.WriteLine(
                "Shipment System Initialized"
            );
        }


        // TrackingCode
        // read only from outside

        public string TrackingCode
        {
            get { return trackingCode; }
        }


        // Description
        // read and write validation

        public string Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }


        // Weight read and write and greater than 0

        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        // DeliveryFee
        // public getter and private setter  greater than 0

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }


        // EstimatedCost Every shipment calculate it owns cost


        public abstract decimal EstimatedCost
        {
            get;

        }


        public Shipment(
                   string trackingcode,
                   string description,
                   decimal weight,
                   decimal deliveryFee,
                   DeliveryAddress destination)
        {
            trackingCode = "Unknown";
            this.description = "Unknown";
            weight = 1;
            deliveryFee = 50;

            Destination = destination;


            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                this.trackingCode = trackingCode;
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }

            if (weight > 0)
            {
                Weight = weight;
            }

            if (deliveryFee > 0)
            {
                DeliveryFee = deliveryFee;
            }


            // increase shipment counter

            TotalShipmentsCreated++;
        }


        // Copy Shipment

        public Shipment CopyShipment()
        {
            Shipment copy =
                (Shipment)this.MemberwiseClone();

            return copy;
        }


        // Shallow Copy

        public Shipment ShallowCopy()
        {
            Shipment copy =
                (Shipment)this.MemberwiseClone();

            return copy;
        }


        // Deep Copy

        public Shipment DeepCopy()
        {
            Shipment copy =
                (Shipment)this.MemberwiseClone();


            copy.Destination =
                new DeliveryAddress(
                    Destination.Street,
                    Destination.City,
                    Destination.BuildingNumber
                );


            return copy;
        }


        // Static Method

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }






        // Update Delivery Fee

        public void UpdateDeliveryFee(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0)
            {
                deliveryFee = newDeliveryFee;
            }
        }





        // Print Shipment we use abstract for every shipment that has own info

        public abstract void PrintShipment();


    }
}