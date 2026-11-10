import { ModInterfaceLayer } from './InterfaceSystem/ModInterfaceLayer.js';
import { ModInterface } from './InterfaceSystem/ModInterface.js';
import { VanillaInterfaceLayers } from './InterfaceSystem/VanillaInterfaceLayers.js';

// Registered in 'InterfaceSystem/RegisterAll.js'
export class ExampleInterfaceLayer extends ModInterfaceLayer {
    constructor() {
        super();
    }
    
    SetupLayerList(list) {
        /*
         - This inserts this layer in the position of ResourceBars layer
         - All layers from this position onward will be moved to the front
         - For example, when inserting d in the position of b: [a, b, c] -> [a, d, b, c] 
        */
        list.Insert(VanillaInterfaceLayers.ResourceBars, this.Value);
    }
    
    SetupContent() {
        // Initialize static data
        this.ExampleInterface = ModInterface.getByName('ExampleInterface');
    }
    
    Draw() {
        // Here you draw all the interfaces for this layer
        this.ExampleInterface.Draw();
    }
}