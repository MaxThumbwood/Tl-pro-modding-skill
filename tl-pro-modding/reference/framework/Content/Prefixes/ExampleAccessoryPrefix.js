import { ModPrefix } from './../../TL/ModPrefix.js';
import { PrefixCategory } from './../../TL/PrefixCategory.js';

/**
 * Currently, it doesn't support prefix lines in the accessory tooltip.
 */
export class ExampleAccessoryPrefix extends ModPrefix {
    constructor() {
        super();
    }
    
    get Category() {
        return PrefixCategory.Accessory;
    }
    
    // Accessories need this because they don't have stats to scale the item's value.
    // see the vanilla values:
    //   +4 = 1.2;
    //   +3 = 1.15;
    //   +2 = 1.1;
    //   +1 = 1.05;
    // This accessory grants +4 defense, so we will return 1.2.
    GetValueMultiplier() {
        return 1.2;
    }
    
    ApplyAccessoryEffects(player) {
        player.statDefense += 4;
    }
}