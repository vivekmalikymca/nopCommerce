using Nop.Web.Framework;

namespace Nop.Plugin.Shipping.FixedOrByWeight.Models
{
    public class FixedRateModel
    {
        public int ShippingMethodId { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.ShippingMethod")]
        public string ShippingMethodName { get; set; }

        [NopResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}