using InternetStore.Domain.Repositories.Abstract;

namespace InternetStore.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IProductsItemsRepository ProductsItems { get; set; }

        public DataManager(IProductsItemsRepository productsItemsRepository, ITextFieldsRepository textFieldsRepository)
        {
            TextFields = textFieldsRepository;
            ProductsItems = productsItemsRepository;
        }
    }
}
