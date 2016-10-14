using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Shipping.FixedOrByWeight.Models
{
    public class ShippingByWeightListModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugins.Shipping.FixedOrByWeight.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }

        public bool Enabled { get; set; }
    }
}