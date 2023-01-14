ProductManager productManager = new ProductManager(new InMemoryProductDal());
foreach (var car in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);

}