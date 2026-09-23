using System;
using System.Collections.Generic;
using System.Text;

namespace Part01
{
    public class OrderSystem
    {
        private readonly List<Customer> _customers = new();
        public IReadOnlyList<Customer> Customers => _customers;
        public void AddCustomer(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);
            if (_customers.Count >= 50)
                throw new InvalidOperationException("Customers cannot be greater than 50");
            foreach (var cus in _customers)
            {
                if (customer.Id == cus.Id)
                    throw new InvalidOperationException("Customer already exists");
            }
            _customers.Add(customer);
        }
        private readonly List<Product> _products = new();
        public IReadOnlyList<Product> Products => _products;
        public void AddProduct(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);
            if (_products.Count >= 50)
                throw new InvalidOperationException("Product cannot be greater than 50");
            foreach (var pro in _products)
            {
                if (pro.Id == product.Id)
                    throw new InvalidOperationException("Product already exists");
            }
            _products.Add(product);
        }
        private readonly List<Order> _orders = new();
        public IReadOnlyList<Order> Orders => _orders;
        public Customer? FindCustomerById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }
        public Product? FindProductById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }
        public Order? FindOrderById(int id)
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(id);
            foreach (var order in _orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }
        public void CreateOrder(int orderId, int customerId, DateOnly date)
        {
            Customer? customer = FindCustomerById(customerId);
            if (customer is null)
                throw new InvalidOperationException("Customer does not exist");
            if (FindOrderById(orderId) != null)
                throw new InvalidOperationException("Order id already exists");
            if (_orders.Count >= 100)
                throw new InvalidOperationException("Order cannot be greater than 100");
            _orders.Add(new Order(orderId, customer, date));
        }
        public void AddLineToOrder(int orderId, int productId, int quantity)
        {
            Order? order = FindOrderById(orderId);
            if (order is null)
                throw new InvalidOperationException("Order does not exist");
            Product? product = FindProductById(productId);
            if (product is null)
                throw new InvalidOperationException("Product does not exist");
            order.AddLine(product, quantity);
        }
        public void MarkOrderPaid(int orderId)
        {
            Order? order = FindOrderById(orderId);
            if (order is null)
            {
                throw new InvalidOperationException("Order does not exist");
            }
            order.MarkOrderPaid();
        }
        public decimal TotalSalesPaidOnly()
        {
            decimal total = 0;
            foreach (var order in _orders)
            {
                if (order.IsPaid)
                {
                    total += order.CalculateTotal();
                }
            }
            return total;
        }
        public void PrintCustomers()
        {
            foreach (var customer in _customers)
            {
                Console.WriteLine($"Name: {customer.Name}");
                Console.WriteLine($"Id: {customer.Id}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"City: {customer.City}");
                Console.WriteLine($"IsVip: {customer.IsVip}");
                Console.WriteLine();
            }
        }
        public void PrintProducts()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine($"ProductStock: {product.ProductStock}");
                Console.WriteLine();
            }
        }
        public void PrintOrder(int orderId)
        {
            Order? order = FindOrderById(orderId);
            if (order is null)
                throw new InvalidOperationException("Order does not exist");
            Console.WriteLine($"Order Id: {order.Id}");
            Console.WriteLine($"Date: {order.Date}");
            Console.WriteLine($"Customer: {order.Customer.Name}");
            Console.WriteLine($"IsPaid: {order.IsPaid}");
            Console.WriteLine("Order Lines:");
            foreach (var line in order.OrderLines)
            {
                Console.WriteLine($"Product: {line.Product.Name}");
                Console.WriteLine($"Quantity: {line.Quantity}");
                Console.WriteLine($"Unit Price: {line.UnitPrice}");
                Console.WriteLine($"Line Total: {line.LineTotal}");
                Console.WriteLine();
            }
            Console.WriteLine($"Order Total: {order.CalculateTotal()}");
        }
        public void PrintAllOrders()
        {
            foreach (var order in _orders)
            {
                PrintOrder(order.Id);
                Console.WriteLine();
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine("1) Print customers");
            Console.WriteLine("2) Print products");
            Console.WriteLine("3) Print all orders");
            Console.WriteLine("4) Print one order by id");
            Console.WriteLine("5) Create order");
            Console.WriteLine("6) Add line to order");
            Console.WriteLine("7) Mark order paid");
            Console.WriteLine("8) Show paid sales total");
            Console.WriteLine("0) Exit");
            Console.Write("Choice: ");
        }



        public void RunInteractiveMenu()
        {
            while (true)
            {
                PrintMenu();
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                try
                {
                    switch (choice)
                    {
                        case 1:
                            PrintCustomers();
                            break;

                        case 2:
                            PrintProducts();
                            break;

                        case 3:
                            PrintAllOrders();
                            break;

                        case 4:
                            Console.Write("Order Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int orderId))
                            {
                                Console.WriteLine("Invalid Order Id");
                                break;
                            }

                            PrintOrder(orderId);
                            break;

                        case 5:
                            Console.Write("Order Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int newOrderId))
                            {
                                Console.WriteLine("Invalid Order Id");
                                break;
                            }

                            Console.Write("Customer Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int customerId))
                            {
                                Console.WriteLine("Invalid Customer Id");
                                break;
                            }

                            Console.Write("Date: ");

                            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly date))
                            {
                                Console.WriteLine("Invalid Date");
                                break;
                            }

                            CreateOrder(newOrderId, customerId, date);
                            break;

                        case 6:
                            Console.Write("Order Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int lineOrderId))
                            {
                                Console.WriteLine("Invalid Order Id");
                                break;
                            }

                            Console.Write("Product Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int productId))
                            {
                                Console.WriteLine("Invalid Product Id");
                                break;
                            }

                            Console.Write("Quantity: ");

                            if (!int.TryParse(Console.ReadLine(), out int quantity))
                            {
                                Console.WriteLine("Invalid Quantity");
                                break;
                            }

                            AddLineToOrder(lineOrderId, productId, quantity);
                            break;

                        case 7:
                            Console.Write("Order Id: ");

                            if (!int.TryParse(Console.ReadLine(), out int paidOrderId))
                            {
                                Console.WriteLine("Invalid Order Id");
                                break;
                            }

                            MarkOrderPaid(paidOrderId);
                            break;

                        case 8:
                            Console.WriteLine($"Paid Sales Total: {TotalSalesPaidOnly()}");
                            break;

                        case 0:
                            Console.WriteLine("Bye");
                            return;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
