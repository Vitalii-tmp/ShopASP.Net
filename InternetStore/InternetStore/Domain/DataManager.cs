using InternetStore.Domain.Repositories.Abstract;

namespace InternetStore.Domain
{
    public class DataManager
    {
        public ITextFieldRepository TextFields { get; set; }
        public IProductsItemRepository ProductsItems { get; set; }

        public DataManager(IProductsItemRepository productsItemsRepository, ITextFieldRepository textFieldsRepository)
        {
            TextFields = textFieldsRepository;
            ProductsItems = productsItemsRepository;
        }
    }
}
