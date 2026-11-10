import { ModBuff } from './../TL/ModBuff.js';

import { ExampleDefenseBuff } from './../Content/Buffs/ExampleDefenseBuff.js'; 
import { ExampleDefenseDebuff } from './../Content/Buffs/ExampleDefenseDebuff.js';
import { ExamplePetBuff } from './../Content/Pets/ExamplePet/ExamplePetBuff.js';
import { ExampleLightPetBuff } from './../Content/Pets/ExampleLightPet/ExampleLightPetBuff.js';
import { ExampleMinionBuff } from './../Content/Buffs/ExampleMinionBuff.js';
import { ExampleMinecartBuff } from './../Content/Buffs/ExampleMinecartBuff.js';
import { ExampleMountBuff } from './../Content/Buffs/ExampleMountBuff.js';

export function RegisterBuffs() {
    ModBuff.register(ExampleDefenseBuff);
    ModBuff.register(ExampleDefenseDebuff);
    ModBuff.register(ExamplePetBuff);
    ModBuff.register(ExampleLightPetBuff);
    ModBuff.register(ExampleMinionBuff);
    ModBuff.register(ExampleMinecartBuff);
    ModBuff.register(ExampleMountBuff);
}