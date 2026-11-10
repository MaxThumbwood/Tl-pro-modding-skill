import { ModNPC } from './../TL/ModNPC.js';

import { ExampleSlimeNPC } from './../Content/NPCs/ExampleSlimeNPC.js';
import { ExampleBoss } from './../Content/NPCs/ExampleBoss.js';
import { ExamplePerson } from './../Content/NPCs/ExamplePerson.js';

export function RegisterNPCs() {
    ModNPC.register(ExampleSlimeNPC);
    ModNPC.register(ExampleBoss);
    ModNPC.register(ExamplePerson);
}