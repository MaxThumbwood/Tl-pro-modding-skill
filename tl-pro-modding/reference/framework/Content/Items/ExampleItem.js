import { Terraria, Modules } from './../../TL/ModImports.js';
import { ModItem } from './../../TL/ModItem.js';
import { ModLocalization } from './../../TL/ModLocalization.js';

const { Color } = Modules;

// This system showcases registration of custom currencies, similar to the Defenders Medal.
// For usage, see Content/NPCs/ExamplePerson.js
export class ExampleCustomCurrency {
    // A static property where we store the ID of our currency.
    // This is what Item.shopSpecialCurrency will be set to to make a shop entry use our currency.
    static CurrencyId = null;
    
    // This call actually registers our custom currency.
    static Initialize({ coinItemId, currencyCap, currencyTextKey, currencyTextColor }) {
        const CustomCurrencyManager = new NativeClass('Terraria.GameContent.UI', 'CustomCurrencyManager');
        const CustomCurrencySingleCoin = new NativeClass('Terraria.GameContent.UI', 'CustomCurrencySingleCoin');
        
        const currency = CustomCurrencySingleCoin.new();
        currency['void .ctor(int coinItemID, long currencyCap)'](coinItemId, BigInt(currencyCap));
        currency.CurrencyTextKey = ModLocalization.Translate(currencyTextKey);
        currency.CurrencyTextColor = currencyTextColor;
        ExampleCustomCurrency.CurrencyId = CustomCurrencyManager.RegisterCurrency(currency);
    }
}

export class ExampleItem extends ModItem {
    constructor() {
        super();
        this.Texture = 'Items/' + this.constructor.name;
    }
    
    // We use PostSetupContent to be sure that items' types have been initialized and are accessible.
    PostSetupContent() {
        ExampleCustomCurrency.Initialize({
            // We assign ExampleItem as the item used for this currency, there is no "ExampleCustomCurrency" item.
            coinItemId: this.Type,
            // The cap is the max amount of held currency that will be counted and displayed.
            // Item prices in shops should not be higher than this value if you want them to be ever affordable.
            currencyCap: 999,
            // Localization string and color that are used for this currency's name.
            currencyTextKey: 'CustomCurrency.ExampleItemCurrency',
            currencyTextColor: Color.new(240, 100, 120) // Defense Medal color. Note that the custom color doesn't work.
        });
    }
    
    SetDefaults() {
        this.Item.maxStack = ModItem.CommonMaxStack;
        this.Item.value = Terraria.Item.buyPrice(0, 0, 1, 0);
    }
    
    AddRecipes() {
        this.CreateRecipe(999)
        .AddIngredient(Terraria.ID.ItemID.DirtBlock, 10)
        .AddTile(Terraria.ID.TileID.WorkBenches)
        .Register();
    }
}