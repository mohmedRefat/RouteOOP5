using RouteOOP5.Classes;

namespace RouteOOP5.Extensions
{
    public static class ShipmentExtensions
    {
        // shipment summary

        public static string GetSummary(
            this Shipment shipment)
        {
            return
                $"{shipment.TrackingCodeProperty} | " +
                $"{shipment.GetType().Name.Replace("Shipment", "")} | " +
                $"{shipment.Weight} KG | " +
                $"{shipment.GetTrackingStatus()}";
        }


        // check if shipment delieverd

        public static bool IsDelivered(
            this Shipment shipment)
        {
            return shipment.GetTrackingStatus()
                == "Delivered";
        }
    }
}