using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Company.Domain.Entities;
using Company.Domain.Repositories.Abstract;

namespace Company.Domain.Repositories.EntityFramework
{
    // Реализация интерфейса
    public class EFTextFiledsRepository : ITextFiledsRepository
    {
        private readonly AppDbContext Context;
        public EFTextFiledsRepository(AppDbContext Context) =>
            this.Context = Context;

        public IQueryable<TextField> GetTextFields() =>
            Context.TextFields;
        public TextField GetTextFieldById(Guid id) =>
            Context.TextFields.FirstOrDefault((x) => x.Id == id);
        public TextField GetTextFieldByCodeWord(string CodeWord) =>
            Context.TextFields.FirstOrDefault((x) => x.CodeWord == CodeWord);
        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                Context.Entry(entity).State = EntityState.Added;
            else
                Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            Context.TextFields.Remove(new TextField()   { Id = id });
            Context.SaveChanges();
        }
    }
}
