using System.Linq;
using SportsStore.Domain.Entities;


//abstract repository 
namespace SportsStore.Domain.Abstract
{
    public interface IProductRepository
    {

        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
