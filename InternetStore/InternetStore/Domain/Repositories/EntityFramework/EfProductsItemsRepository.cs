using InternetStore.Domain.Entities;
using InternetStore.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.Domain.Repositories.EntityFramework
{
    public class EfProductsItemsRepository : IProductsItemsRepository
    {


        private readonly AppDbContext context;
        public EfProductsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ProductItem> GetProductItems()
        {
            return context.ProductItems;
        }

        public ProductItem GetProductItemById(Guid id)
        {
            return context.ProductItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveProductItem(ProductItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteProductItem(Guid id)
        {
            context.ProductItems.Remove(new ProductItem() { Id = id });
            context.SaveChanges();
        }
    }
}
