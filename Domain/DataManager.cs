using Company.Domain.Repositories.Abstract;

namespace Company.Domain
{
    //
    // Класс-помощник для управления страницами и услугами
    //
    public class DataManager
    {
        public ITextFiledsRepository TextFileds { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFiledsRepository TextFileds, IServiceItemsRepository ServiceItems)
        {
            this.TextFileds = TextFileds;
            this.ServiceItems = ServiceItems;
        }
    }
}
