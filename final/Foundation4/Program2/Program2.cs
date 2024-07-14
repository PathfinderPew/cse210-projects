class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Alice", "123 Main St");
        Order order = new Order(customer);
        
        Product product1 = new Product("Laptop", 999.99m);
        Product product2 = new Product("Mouse", 49.99m);
        
        order.AddProduct(product1);
        order.AddProduct(product2);
        
        order.DisplayOrder();
    }
}
