using System;
using System.Linq;
using Company.Domain.Entities;

namespace Company.Domain.Repositories.Abstract
{
    // Интерфейс для взаимодействия с услугами
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
