import { ModPrefix } from './../../TL/ModPrefix.js';
import { PrefixCategory } from './../../TL/PrefixCategory.js';

export class ExamplePrefix extends ModPrefix {
    constructor() {
        super();
    }
    
    get Category() {
        return PrefixCategory.Melee;
    }
    
    // stats = { damage, knockBack, speed, size, shootSpeed, mana, crit, tagDamage, armorPenetration };
    SetStats(stats) {
        stats.damage += 0.2;     // +20% damage
        stats.size += 0.1;       // +10% size
        stats.crit += 8;         //  +8% crit
        stats.knockBack += 0.05; //  +5% knockBack
    }
}