using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using System;
using System.Linq;

namespace Company.Service
{
    public class AdminAreaAuthorization : IControllerModelConvention
    {
        private readonly string Area;
        private readonly string Policy;
        public AdminAreaAuthorization(string Area, string Policy)
        {
            this.Area = Area;
            this.Policy = Policy;
        }
        public void Apply(ControllerModel Controller)
        {
            if (Controller.Attributes.Any(x =>
                    x is AreaAttribute && (x as AreaAttribute).RouteValue.Equals(Area, StringComparison.OrdinalIgnoreCase))
                || Controller.RouteValues.Any(x =>
                        x.Key.Equals("area", StringComparison.OrdinalIgnoreCase) && x.Value.Equals(Area, StringComparison.OrdinalIgnoreCase)))
            {
                Controller.Filters.Add(new AuthorizeFilter(Policy));
            }
        }
    }
}
