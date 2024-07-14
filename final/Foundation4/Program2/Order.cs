public class Order
{
    public Customer Customer { get; set; }
    private List<Product> Products { get; set; }
    public decimal TotalAmount { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
        TotalAmount = 0;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        TotalAmount += product.Price;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Customer: {Customer.Name}");
        Console.WriteLine($"Address: {Customer.Address}");
        Console.WriteLine("Products Ordered:");
        foreach (Product product in Products)
        {
            Console.WriteLine($"- {product.Name}: ${product.Price}");
        }
        Console.WriteLine($"Total Amount: ${TotalAmount}");
    }
}
