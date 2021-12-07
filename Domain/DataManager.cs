using Company.Domain.Repositories.Abstract;

namespace Company.Domain
{
    //
    // Класс-помощник для управления страницами и услугами
    //
    public class DataManager
    {
        public ITextFiledsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFiledsRepository TextFields, IServiceItemsRepository ServiceItems)
        {
            this.TextFields = TextFields;
            this.ServiceItems = ServiceItems;
        }
    }
}
