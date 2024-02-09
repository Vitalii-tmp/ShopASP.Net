using InternetStore.Domain.Repositories.Abstract;

namespace InternetStore.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IProductsItemsRepository ProductItems { get; set; }

        public DataManager(IProductsItemsRepository productItemsRepository, ITextFieldsRepository textFieldsRepository)
        {
            TextFields = textFieldsRepository;
            ProductItems = productItemsRepository;
        }
    }
}
