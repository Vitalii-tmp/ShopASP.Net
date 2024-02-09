using InternetStore.Domain.Entities;
using System;
using System.Linq;
namespace InternetStore.Domain.Repositories.Abstract
{
    public interface IProductsItemsRepository
    {
        IQueryable<ProductItem> GetProductItems();
        ProductItem GetProductItemById(Guid id);
        void SaveProductItem(ProductItem entity);
        void DeleteProductItem(Guid id);
    }
}
