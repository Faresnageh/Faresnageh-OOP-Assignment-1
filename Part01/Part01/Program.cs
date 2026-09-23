using Assignment01_oop;

namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part01
            //OrderSystem system = new OrderSystem();
            //system.AddCustomer(new Customer(1, "Mona Ali", "mona@example.com", "Cairo", true));
            //system.AddCustomer(new Customer(2, "Omar Hassan", "omar@example.com", "Alexandria", false));
            //system.AddCustomer(new Customer(3, "Sara Nabil", "sara@example.com", "Giza", false));
            //system.AddProduct(new Product(101, "USB Cable", 50m, 100));
            //system.AddProduct(new Product(102, "Wireless Mouse", 250m, 40));
            //system.AddProduct(new Product(103, "Mechanical Keyboard", 1200m, 15));
            //system.AddProduct(new Product(104, "Laptop Stand", 400m, 25));
            //system.RunInteractiveMenu();


            // Part02
            //Room room = new Room(101, RoomType.Double, 500);
            //Guest guest = new Guest("Mohamed", "01000000000");
            //Reservation reservation = new Reservation(new DateOnly(2026, 9, 25), new DateOnly(2026, 9, 28), room);
            //guest.AddReservation(reservation);
            //Console.WriteLine($"Guest: {guest.FullName}");
            //Console.WriteLine($"Room: {room.Number}");
            //Console.WriteLine($"Status: {reservation.ReservationStatus}");
            //Console.WriteLine($"Total Cost: {reservation.TotalCost()}");
            //reservation.Confirm();
            //Console.WriteLine($"Status: {reservation.ReservationStatus}");
            //reservation.CheckIn();
            //Console.WriteLine($"Status: {reservation.ReservationStatus}");
            //reservation.CheckOut();
            //Console.WriteLine($"Status: {reservation.ReservationStatus}");
            //room.StartMaintenance();
            //Console.WriteLine($"Under Maintenance: {room.UnderMaintenance}");
            //room.EndMaintenance();
            //Console.WriteLine($"Under Maintenance: {room.UnderMaintenance}");



            // Part03
            //var billingAddress = new AddressBuilder("Omar Nasef", "Tanta", "Epypt").Build();
            //var shippingAddress = new AddressBuilder("Omar Nasef", "Tanta", "Epypt").WithZipCode("1232").Build();
            //var orderInfo = new OrderInfoBuilder("Visa","Epy",50.5m,100m).WithDiscountAmount(21m).Build();
            //var invoice = new InvoiceBuilder(1, "Fares", "$", 100m).WithBillingAddress(billingAddress).WithShippingAddress(shippingAddress).WithOrderInfo(orderInfo).Build();
        }
    }
}
