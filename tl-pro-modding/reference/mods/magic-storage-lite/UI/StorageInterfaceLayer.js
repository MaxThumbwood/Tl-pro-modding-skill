import { ModInterfaceLayer } from './../InterfaceSystem/ModInterfaceLayer.js';
import { ModInterface } from './../InterfaceSystem/ModInterface.js';
import { VanillaInterfaceLayers } from './../InterfaceSystem/VanillaInterfaceLayers.js';
import { StorageState } from './../State.js';

export class StorageInterfaceLayer extends ModInterfaceLayer {
    SetupLayerList(list) {
        list.Insert(VanillaInterfaceLayers.MouseText, this.Value);
    }

    SetupContent() {
        this.Interface = ModInterface.getByName('StorageInterface');
    }

    Draw() {
        if (StorageState.uiOpen && this.Interface) this.Interface.Draw();
    }
}
