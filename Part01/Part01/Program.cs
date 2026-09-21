namespace Part01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderSystem system = new OrderSystem();

            system.AddCustomer(new Customer(1, "Mona Ali", "mona@example.com", "Cairo", true));
            system.AddCustomer(new Customer(2, "Omar Hassan", "omar@example.com", "Alexandria", false));
            system.AddCustomer(new Customer(3, "Sara Nabil", "sara@example.com", "Giza", false));

            system.AddProduct(new Product(101, "USB Cable", 50m, 100));
            system.AddProduct(new Product(102, "Wireless Mouse", 250m, 40));
            system.AddProduct(new Product(103, "Mechanical Keyboard", 1200m, 15));
            system.AddProduct(new Product(104, "Laptop Stand", 400m, 25));

            system.RunInteractiveMenu();
        }
    }
}
