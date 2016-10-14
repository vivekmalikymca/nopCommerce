
using Nop.Core.Configuration;

namespace Nop.Plugin.Shipping.FixedOrByWeight
{
    public class ShippingByWeightSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }

        public bool Enabled { get; set; }
    }
}