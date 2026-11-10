import { ModPlayer } from './../TL/ModPlayer.js';
import { GlobalNPC } from './../TL/GlobalNPC.js';
import { GlobalItem } from './../TL/GlobalItem.js';
import { GlobalLoot } from './../TL/GlobalLoot.js';
import { GlobalTile } from './../TL/GlobalTile.js';
import { GlobalHooks } from './../TL/GlobalHooks.js';
import { GlobalProjectile } from './../TL/GlobalProjectile.js';

import { gHooks } from './../Content/Global/gHooks.js';
import { gPlayer } from './../Content/Global/gPlayer.js';
import { ExampleDashPlayer } from './../Content/Global/ExampleDashPlayer.js';
import { ExampleLoot } from './../Content/Global/ExampleLoot.js';

export function RegisterGlobal() {
    GlobalHooks.register(gHooks);
    ModPlayer.register(gPlayer);
    ModPlayer.register(ExampleDashPlayer);
    GlobalLoot.register(ExampleLoot);
}