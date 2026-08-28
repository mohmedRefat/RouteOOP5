
/*
Q1

A
when we assign one object variable to another both variable refers to the same obj in the memory


B
No it doesn't  create a new object it copies the reference of the same obj



C
copying object : create a new object with it own data
coping reference : both variable point  to same object in memeory

*/


/*
Q2 

A
shallow copy :create new object but reference types inside it refer to the same object

B
Deep copy : create new object and create new seperate copies of the reference types indpendant 


C
what happens in shallow copy : reference type members   refer to the same object so any edit or modification 
will effect the original object

D
what happens in deep copy : reference type have their own seperate object  independant 
so it doest not affect the original object

E
deep copy is safer when we want to edit the copied object with change the orignal one

*/


/*
Q3 

A
static field belongs to class not the specific object
instance field belongs to each object  so every object has it own copy


B
static method is a method can be called without creating an object
,no it can not access the instance members because it belongs to specific object

C
static constructor is used to initalize statice members , it is executed auto before the class is  used for  the first time

D
static class : class that only contain static members , no we can't 
*/



/*
Q4 

A
extension method : method that allow u to add new method  to existing class or type without edit the original class

B
must use this keyword 

C
extension method must declared inside a static class

D
no becasue it can not directyle access private members because it is not a member of that class

*/


/*
Q5 

A

partial class : class that allows u to split one class into multiple files every part together represent the same class
B
to make code easier to read , organze maitainable


C
partial method : is a method the can be declared in one part of partaial class and implement in another part

D
compiler removers declaration and calls so it will not make a compile time error
*/








using RouteOOP5.Classes;
using RouteOOP5.Extensions;
using RouteOOP5.Structs;


class Program
{
    static void Main(string[] args)
    {
        // print sys title

        DeliveryUtilities.PrintSystemTitle();


        // get total before shipment

        Console.WriteLine(
            $"Total Shipments Created : " +
            $"{Shipment.GetTotalShipmentsCreated()}"
        );


        // create standard shipment

        Console.WriteLine(
            "creating shipments"
        );


        DeliveryAddress standardAddress =
            new DeliveryAddress(
                "Street One",
                "Cairo",
                10
            );


        StandardShipment standardShipment =
            new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                standardAddress
            );


        Console.WriteLine(
            "Standard Shipment Created"
        );


        // Create express shipment

        DeliveryAddress expressAddress =
            new DeliveryAddress(
                "Street Two",
                "Cairo",
                20
            );


        ExpressShipment expressShipment =
            new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2,
                60,
                expressAddress,
                30
            );


        expressShipment.UpdateTrackingStatus(
            "Out For Delivery"
        );


        Console.WriteLine(
            "Express Shipment Created"
        );


        // Create international shipment

        DeliveryAddress internationalAddress =
            new DeliveryAddress(
                "Street Three",
                "Cairo",
                30
            );


        InternationalShipment internationalShipment =
            new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                internationalAddress,
                "Germany",
                100
            );


        internationalShipment.UpdateTrackingStatus(
            "Delivered"
        );


        Console.WriteLine(
            "International Shipment Created"
        );


        // static coping

        Console.WriteLine(
            $"Total Shipments Created : " +
            $"{Shipment.GetTotalShipmentsCreated()}"
        );

        /*
            object coping
        */


        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Object Copying");

        DeliveryUtilities.PrintSeparator();


        Shipment shipment1 =
            standardShipment;


        Shipment shipment2 =
            shipment1;


        Console.WriteLine(
            $"Original Shipment : " +
            $"{shipment1.TrackingCodeProperty}"
        );


        Console.WriteLine(
            $"Assigned Shipment : " +
            $"{shipment2.TrackingCodeProperty}"
        );


        Console.WriteLine(
            $"Same Object : " +
            $"{ReferenceEquals(shipment1, shipment2)}"
        );

        /*
            shallow copy
        */

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("shallow copy");

        DeliveryUtilities.PrintSeparator();


        Shipment shallowShipment =
            standardShipment.ShallowCopy();


        Console.WriteLine(
            $"Original Shipment Address : " +
            $"{standardShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Copied Shipment Address : " +
            $"{shallowShipment.Destination.City}"
        );


        Console.WriteLine(
            "Changing copied shipment address..."
        );


        shallowShipment.Destination.City =
            "Giza";


        Console.WriteLine(
            $"Original Shipment Address : " +
            $"{standardShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Copied Shipment Address : " +
            $"{shallowShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Same DeliveryAddress Object : " +
            $"{ReferenceEquals(
                standardShipment.Destination,
                shallowShipment.Destination
            )}"
        );

        /*
        Deep copy
        */


        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Deep copy");

        DeliveryUtilities.PrintSeparator();


        // Change original back to Cairo

        standardShipment.Destination.City =
            "Cairo";


        Shipment deepShipment =
            standardShipment.DeepCopy();


        Console.WriteLine(
            $"Original Shipment Address : " +
            $"{standardShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Copied Shipment Address : " +
            $"{deepShipment.Destination.City}"
        );


        Console.WriteLine(
            "Changing copied shipment address..."
        );


        deepShipment.Destination.City =
            "Giza";


        Console.WriteLine(
            $"Original Shipment Address : " +
            $"{standardShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Copied Shipment Address : " +
            $"{deepShipment.Destination.City}"
        );


        Console.WriteLine(
            $"Same DeliveryAddress Object : " +
            $"{ReferenceEquals(
                standardShipment.Destination,
                deepShipment.Destination
            )}"
        );

        /*
        
        Extension method
        */

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Extension Methods");

        DeliveryUtilities.PrintSeparator();


        Console.WriteLine(
            standardShipment.GetSummary()
        );


        Console.WriteLine(
            expressShipment.GetSummary()
        );


        Console.WriteLine(
            internationalShipment.GetSummary()
        );


        Console.WriteLine(
            $"SH001 Is Delivered : " +
            $"{standardShipment.IsDelivered()}"
        );


        Console.WriteLine(
            $"SH003 Is Delivered : " +
            $"{internationalShipment.IsDelivered()}"
        );


        /*
            Tracking status
        */

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Tracking Status");

        DeliveryUtilities.PrintSeparator();


        standardShipment.UpdateTrackingStatus(
            "Out For Delivery"
        );

        /*
        Static utils
        */

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Static utils");

        DeliveryUtilities.PrintSeparator();


        Console.WriteLine("Delivery Center");


        Console.WriteLine(
            $"Total Shipments Created : " +
            $"{Shipment.GetTotalShipmentsCreated()}"
        );

        /*
        Partial method
        */

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Partial method");

        DeliveryUtilities.PrintSeparator();


        internationalShipment.UpdateTrackingStatus(
            "Delivered"
        );



        DeliveryUtilities.PrintSeparator();

        Console.WriteLine(
            "Assignment Completed"
        );

        DeliveryUtilities.PrintSeparator();
    }
}