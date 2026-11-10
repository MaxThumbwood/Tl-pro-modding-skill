import { ModSystem } from './../TL/ModSystem.js';
import { ModLoader } from './../TL/Core/ModLoader.js';
import { RegisterItems } from './RegisterItems.js';
import { StorageWorldSystem } from './../Content/Systems/StorageWorldSystem.js';

export function RegisterAll() {
    ModSystem.register(ModLoader);
    ModSystem.register(StorageWorldSystem);
    RegisterItems();
}
