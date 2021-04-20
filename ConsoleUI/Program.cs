
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProductDal = new EfProductDal();

            foreach (var product in efProductDal.GetAll())
            {
                Console.WriteLine(product.Name);
            }
        }

        

       
    }
}
