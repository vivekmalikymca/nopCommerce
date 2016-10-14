using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Shipping.FixedOrByWeight
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Shipping.FixedOrByWeight.SaveGeneralSettings",
                 "Plugins/FixedOrByWeight/SaveGeneralSettings",
                 new { controller = "FixedOrByWeight", action = "SaveGeneralSettings", },
                 new[] { "Nop.Plugin.Shipping.FixedOrByWeight.Controllers" }
            );

            routes.MapRoute("Plugin.Shipping.FixedOrByWeight.AddPopup",
                 "Plugins/FixedOrByWeight/AddPopup",
                 new { controller = "FixedOrByWeight", action = "AddPopup" },
                 new[] { "Nop.Plugin.Shipping.FixedOrByWeight.Controllers" }
            );
            routes.MapRoute("Plugin.Shipping.FixedOrByWeight.EditPopup",
                 "Plugins/FixedOrByWeight/EditPopup",
                 new { controller = "FixedOrByWeight", action = "EditPopup" },
                 new[] { "Nop.Plugin.Shipping.FixedOrByWeight.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
