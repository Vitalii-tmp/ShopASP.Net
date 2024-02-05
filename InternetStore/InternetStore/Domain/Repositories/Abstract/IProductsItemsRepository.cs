using InternetStore.Domain.Entities;

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
