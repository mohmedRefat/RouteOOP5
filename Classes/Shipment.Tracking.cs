namespace RouteOOP5.Classes
{
    public abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";


        // get tracking status

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }


        // Update tracking status

        public void UpdateTrackingStatus(
            string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

                OnTrackingStatusChanged(
                    newStatus
                );
            }
        }


        // partial method

        partial void OnTrackingStatusChanged(
            string newStatus);


        // partial method implemention

        partial void OnTrackingStatusChanged(
            string newStatus)
        {
            Console.WriteLine(
                $"Tracking status changed to: {newStatus}"
            );
        }
    }
}