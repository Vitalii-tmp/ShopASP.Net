using InternetStore.Domain.Entities;

namespace InternetStore.Domain.Repositories.Abstract
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField  entity);
        void DeleteTextField(Guid id);
    }
}
