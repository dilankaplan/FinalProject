using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{//SOLID
    //Open Close Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //IoC
            //NewMethod();
        }

        private static void NewMethod()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
       

        private static void ProductTest()
        {
            
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetail();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
