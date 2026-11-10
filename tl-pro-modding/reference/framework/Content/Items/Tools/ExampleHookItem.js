import { Terraria } from './../../../TL/ModImports.js';
import { ModItem } from './../../../TL/ModItem.js';
import { ModProjectile } from './../../../TL/ModProjectile.js';

export class ExampleHookItem extends ModItem {
    constructor() {
        super();
        this.Texture = 'Items/Tools/' + this.constructor.name;
    }
    
    SetDefaults() {
        this.CloneDefaults(Terraria.ID.ItemID.AmethystHook);
        
        this.Item.shootSpeed = 18; // This defines how quickly the hook is shot.
        this.Item.shoot = ModProjectile.getTypeByName('ExampleHookProjectile');
    }
    
    ModifyTooltipLines() {
        const hookTip = Terraria.Localization.Language.GetText('CommonItemTooltip.Hook').Value;
        this.TooltipLines = [
            hookTip.replace('{InputTrigger_Grapple}', '[ct:13]')
        ];
    }
}