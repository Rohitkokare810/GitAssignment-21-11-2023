using System;

class Product
{
    // Fields
    public int pid;
    public string pname;
    public decimal pprice;

    // Methods
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Product ID: {pid}");
        Console.WriteLine($"Product Name: {pname}");
        Console.WriteLine($"Product Price: {pprice:C}");
    }

    public virtual void SetInformation(int id, string name, decimal price)
    {
        pid = id;
        pname = name;
        pprice = price;
    }
}

class HerbalProduct : Product
{
    // Additional fields for Herbal Product
    public string herbsUsed;
    public DateTime mfDate;
    public DateTime expDate;

    // Override methods to add details of Herbal Product fields
    public override void ShowDetails()
    {
        base.ShowDetails(); // Call the base class method
        Console.WriteLine($"Herbs Used: {herbsUsed}");
        Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
        Console.WriteLine($"Expiration Date: {expDate.ToShortDateString()}");
    }

    public override void SetInformation(int id, string name, decimal price)
    {
        base.SetInformation(id, name, price); // Call the base class method
        Console.Write("Enter Herbs Used: ");
        herbsUsed = Console.ReadLine();
        Console.Write("Enter Manufacturing Date (yyyy-mm-dd): ");
        mfDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter Expiration Date (yyyy-mm-dd): ");
        expDate = DateTime.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main()
    {
        // Create an object of HerbalProduct class
        HerbalProduct herbalProduct = new HerbalProduct();

        // Set information for the herbal product
        herbalProduct.SetInformation(1, "Herbal Shampoo", 15.99m);

        // Display details of the herbal product
        Console.WriteLine("\nHerbal Product Details:");
        herbalProduct.ShowDetails();

        Console.ReadLine(); // Keep the console window open
    }
}
