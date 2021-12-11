using Company.Domain;

using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace Company.Models.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;
        public HeaderViewComponent(DataManager dataManager) => this.dataManager = dataManager;
        public Task<IViewComponentResult> InvokeAsync() =>
            Task.FromResult((IViewComponentResult)View("Default", dataManager.ServiceItems.GetServiceItems()));
    }
}
