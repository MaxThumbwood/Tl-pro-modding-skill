import { ModSystem } from './../../TL/ModSystem.js';
import { CraftingState } from './../../Crafting.js';

export class StorageWorldSystem extends ModSystem {
    OnWorldLoad() {
        CraftingState.loadWorldData();
    }

    PreSaveAndQuit() {
        CraftingState.saveWorldData();
    }

    OnWorldUnload() {
        CraftingState.clearWorldData();
    }
}
