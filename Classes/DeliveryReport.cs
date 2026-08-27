using System;
using RouteOOP3.Interfaces;

namespace RouteOOP3.Classes
{
    public static class DeliveryReport
    {
            // print tracking status
        public static void PrintShipment(
            ITrackable shipment)
        {
            Console.WriteLine(
                shipment.GetTrackingStatus()
            );
        }


        // print insurance cost

        public static void PrintInsurance(
            IInsurable shipment)
        {
            Console.WriteLine(
                $"Insurance Cost : " +
                $"{shipment.CalculateInsurance()} EGP"
            );
        }
    }
}