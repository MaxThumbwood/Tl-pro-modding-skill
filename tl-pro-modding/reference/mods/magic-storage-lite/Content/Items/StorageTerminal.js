import { Terraria } from './../../TL/ModImports.js';
import { ModItem } from './../../TL/ModItem.js';
import { StorageState } from './../../State.js';

export class StorageTerminal extends ModItem {
    constructor() {
        super();
        this.Texture = 'Items/' + this.constructor.name;
    }

    SetDefaults() {
        this.Item.width = 48;
        this.Item.height = 48;
        this.Item.maxStack = 1;
        this.Item.useStyle = Terraria.ID.ItemUseStyleID.HoldUp;
        this.Item.useAnimation = 20;
        this.Item.useTime = 20;
        this.Item.noMelee = true;
        this.Item.autoReuse = false;
        this.Item.value = Terraria.Item.buyPrice(0, 1, 0, 0);
        this.Item.rare = Terraria.ID.ItemRarityID.Blue;
    }

    PostSetupContent() {
        StorageState.terminalItemType = this.Type;
    }

    CanUseItem(item, player) {
        return !!player && player.whoAmI === Terraria.Main.myPlayer;
    }

    UseItem(item, player) {
        StorageState.toggleUI();
        return true;
    }

    AddRecipes() {
        this.CreateRecipe()
            // Any wood type: the base ingredient defines the amount and the group
            // allows all vanilla wood variants accepted by Terraria.
            .AddIngredient(Terraria.ID.ItemID.Wood, 10)
            .AddRecipeGroup('Wood')

            // Any basic iron bar: accepts both Iron Bars and Lead Bars.
            .AddIngredient(Terraria.ID.ItemID.IronBar, 20)
            .AddRecipeGroup('IronBar')

            .AddIngredient(Terraria.ID.ItemID.Gel, 5)
            .AddTile(Terraria.ID.TileID.WorkBenches)
            .Register();
    }
}
