internal class Program
{
    private static void Main(string[] args)
    {
        //在集合中移除多個項目
        List<product> products = new List<product>();
        products.Add(new product() { productName = "apple" });
        products.Add(new product() { productName = "banana" });
        products.Add(new product() { productName = "orange" });

        products.Remove(new product() { productName="orange"});
        foreach (var item in products)
        {
            Console.WriteLine(item.productName);
        }

    }
}
class product
{
    public string? productName { get; set; }
}

