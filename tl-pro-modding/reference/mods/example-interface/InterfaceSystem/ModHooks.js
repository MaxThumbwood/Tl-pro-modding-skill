import { ModInterfaceLayer } from './ModInterfaceLayer.js';
import { ModInterface } from './ModInterface.js';

export class ModHooks {
    static Initialize() {
        const Main = new NativeClass('Terraria', 'Main');
        const LegacyGameInterfaceLayer = new NativeClass('Terraria.UI', 'LegacyGameInterfaceLayer');
        const WorldGen = new NativeClass('Terraria', 'WorldGen');
        
        // Initialization of registered interfaces and layers
        Main['void Initialize_AlmostEverything()'
        ].hook((original, self) => {
            original(self);
            ModInterfaceLayer.SetupContent();
            ModInterface.SetupContent();
        });
        
        // Optional, can be embedded in ModInterface.Draw()
        Main['void UpdateUIStates(GameTime gameTime)'
        ].hook((original, self, gameTime) => {
            original(self, gameTime);
            ModInterface.Update();
        });
        
        // Required to clear interface and button states when exiting the world
        WorldGen['void SaveAndQuit()'
        ].hook((original, self) => {
            ModInterface.Clear();
            original(self);
        });
        
        // Setup and Draw interface layers
        LegacyGameInterfaceLayer['bool DrawSelf()'
        ].hook((original, self) => {
            ModInterfaceLayer.SetupInterfaceLayers();
            if (ModInterfaceLayer.isModLayer(self.Name)) {
                ModInterfaceLayer.DrawLayer(self.Name);
                return true;
            }
            return original(self);
        });
    }
}