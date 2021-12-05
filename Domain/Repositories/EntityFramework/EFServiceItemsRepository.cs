using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Company.Domain.Entities;
using Company.Domain.Repositories.Abstract;

namespace Company.Domain.Repositories.EntityFramework
{
    // Реализация интерфейса 
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext Context;
        public EFServiceItemsRepository(AppDbContext Context) =>
            this.Context = Context;
        public IQueryable<ServiceItem> GetServiceItems() =>
            Context.ServiceItems;
        public ServiceItem GetServiceItemById(Guid id) => 
            Context.ServiceItems.FirstOrDefault(x => x.Id == id);
        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity == default)
                Context.Entry(entity).State = EntityState.Added;
            else
                Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
        public void DeleteServiceItem(Guid id)
        {
            Context.ServiceItems.Remove(new ServiceItem() { Id = id });
            Context.SaveChanges();
        }
       
    }
}
