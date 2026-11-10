const Main = new NativeClass('Terraria', 'Main');
const InterfaceScaleType = new NativeClass('Terraria.UI', 'InterfaceScaleType');
const LegacyGameInterfaceLayer = new NativeClass('Terraria.UI', 'LegacyGameInterfaceLayer');
const Matrix = new NativeClass('Microsoft.Xna.Framework', 'Matrix');
const SpriteSortMode = new NativeClass('Microsoft.Xna.Framework.Graphics', 'SpriteSortMode');

export class ModInterfaceLayer {
    get Name() {
        return this.constructor.name;
    }
    get ScaleType() {
        return InterfaceScaleType.None;
    }
    
    constructor() {
        this.Value = this.CreateInstance();
    }
    
    CreateInstance() {
        const layer = LegacyGameInterfaceLayer.new();
        layer['void .ctor(string name, InterfaceScaleType scaleType)'](this.Name, this.ScaleType);
        return layer;
    }
    
    SetupLayerList(list) {
        const index = list.Count;
        list.Insert(index, this.Value);
    }
    
    SetupContent() {
        
    }
    
    Draw() {
        
    }
    
    static _needToSetupDrawInterfaceLayers = true;
    
    static Layers = [];
    static LayerNames = new Set();
    
    static getByName(name) {
        return this.Layers.find(l => l.Name === name) ?? null;
    }
    static isModLayer(name) {
        return this.LayerNames.has(name);
    }
    static register(layer) {
        const _layer = new layer();
        ModInterfaceLayer.Layers.push(_layer);
        ModInterfaceLayer.LayerNames.add(_layer.constructor.name);
    }
    
    static SetupInterfaceLayers() {
        if (ModInterfaceLayer._needToSetupDrawInterfaceLayers) {
            ModInterfaceLayer._needToSetupDrawInterfaceLayers = false;
            for (const _layer of ModInterfaceLayer.Layers) {
                _layer.SetupLayerList(Main.instance._gameInterfaceLayers);
            }
        }
    }
    
    static SetupContent() {
        for (const _layer of ModInterfaceLayer.Layers) {
            _layer.SetupContent();
        }
    }
    
    static DrawLayer(name) {
        const _layer = this.getByName(name);
        _layer.Draw();
    }
}