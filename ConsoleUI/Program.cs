//SOLID 
//Open Closed Principle

//ProductTest();

//CategoryTest();

class Program
{
    static void Main(string[] args)
    {
        MyClass m1 = new MyClass();

        m1.Name = "Test";

        string m2 = "test2";

        m1.Name = m2;
        Console.WriteLine(m2);
    }
}
public class MyClass
{
    string a;
    public string A
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }

    }
    public string Name { get; set; }
}










//static void ProductTest()
//{                                                       //101
//    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

//    var result = productManager.GetProductDetails();

//    if (result.Success == true)
//    {
//        foreach (var product in result.Data)
//        {
//            Console.WriteLine(product.ProductName + "  ---  " + product.CategoryName);
//        }
//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }
//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//    foreach (var category in categoryManager.GetAll().Data)
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//}