using InternetStore.Domain.Entities;
using InternetStore.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace InternetStore.Domain.Repositories.EntityFramework
{
    public class EFTextFieldRepository : ITextFieldRepository
    {
        private readonly AppDbContext context;

        public EFTextFieldRepository(AppDbContext context)
        {
            this.context = context;
        }

        

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }

        public void SaveTextField(TextField entity)
        {
            context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
        }

        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField(){Id = id});
            context.SaveChanges();
        }
    }
}
