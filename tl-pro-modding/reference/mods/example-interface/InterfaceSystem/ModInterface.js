import { ModButton } from './ModButton.js';
import { Vector2 } from './Utilities/Microsoft.js';

const Main = new NativeClass('Terraria', 'Main');
const GUIPanel = new NativeClass('', 'GUIPanel');
const PanelLayout = new NativeClass('', 'Panel_Layout');
const LayoutCalculator = new NativeClass('', 'LayoutCalculator');

export class ModInterface {
    constructor() {}
    
    SetupContent() {}
    
    CreateLayout(width = 0, height = 0) {
        const layout = PanelLayout.new();
        layout['void .ctor()']();
        layout.Location = Vector2.new(0, 0);
        layout.Size = Vector2.new(width, height);
        layout.Anchor = LayoutCalculator.AnchorType.TopLeft;
        return layout;
    }
    
    Recalculate(layout, rect) {
        layout.Size = Vector2.new(rect.Width, rect.Height);
        layout.Location = Vector2.new(rect.X + layout.Size.X * 0.5, rect.Y + layout.Size.Y * 0.5);
        GUIPanel['bool RegisterPickingRegion(Panel_Layout layout)'](layout);
    }
    
    Clear() {}
    
    Update() {}
    
    Draw() {}
    
    static Time = 0;
    
    static Interfaces = [];
    
    static register(_interface) {
        ModInterface.Interfaces.push(new _interface());
    }
    static getByName(name) {
        return this.Interfaces.find(i => i.constructor.name === name);
    }
    
    static SetupContent() {
        for (const _interface of this.Interfaces) {
            _interface.SetupContent();
        }
    }
    
    static Update() {
        ModInterface.Time++;
        ModButton.Update();
        for (const _interface of this.Interfaces) {
            _interface.Update();
        }
    }
    
    static Clear() {
        for (const _interface of this.Interfaces) {
            _interface.Clear();
        }
        ModInterface.Time = 0;
        ModButton.Clear();
    }
}