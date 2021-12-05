using System;
using System.Linq;
using Company.Domain.Entities;

namespace Company.Domain.Repositories.Abstract
{
    // Интерфейс для взаимодействия со страницами
    public interface ITextFiledsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string CodeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
