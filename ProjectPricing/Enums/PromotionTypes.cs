using System.ComponentModel;

namespace ProjectPricing.Enums
{
    public enum PromotionTypes
    {
        [Description("Buy2Get1Free")]
        Buy2Get1Free = 0,
        [Description("Buy2Get10Off")]
        Buy2Get10Off = 1,
        [Description("SeasonSale")]
        SeasonSale = 2,
    }
}
