import { ModInterface } from './ModInterface.js';
import { Draw } from './Utilities/Draw.js';

const Main = new NativeClass('Terraria', 'Main');
const SoundEngine = new NativeClass('Terraria.Audio', 'SoundEngine');
const Color = new NativeClass('Microsoft.Xna.Framework.Graphics', 'Color');
const Rectangle = new NativeClass('Microsoft.Xna.Framework', 'Rectangle');

export class ModButton {
    static Buttons = [];
    static ClickedButtons = [];
    
    static get Time() {
        return ModInterface.Time;
    }
    
    constructor() {
        this.Area = Rectangle.new();
        this.Initialize();
        ModButton.Buttons.push(this);
    }
    
    Hovered = false;
    Pressed = false;
    Clicked = false;
    
    ClickedTime = 10;
    LastClicked = 0;
    
    Initialize() {
        
    }
    
    Clear() {
        this.Hovered = this.Pressed = this.Clicked = false;
        this.LastClicked = 0;
    }
    
    GetColor() {
        return Color.White;
    }
    
    GetIconTexture() {
        return null;
    }
    
    GetTexture() {
        return null;
    }
    
    OnMouseOver() {
        
    }
    
    OnMouseOut() {
        
    }
    
    WhileHovered() {
        
    }
    
    ClickSound() {
        return 12;
    }
    
    OnClick() {
        
    }
    
    Draw(rect) {
        const texture = this.GetTexture();
        if (texture) {
            const color = this.GetColor();
            Draw.Rectangle(texture, rect, color);
            const icon = this.GetIconTexture();
            if (icon) Draw.Rectangle(icon, rect, color);
        }
    }
    
    static Clear() {
        this.ClickedButtons = [];
        for (const button of this.Buttons) {
            button.Clear();
        }
    }
    
    static Update() {
        this.UpdateClickedButtons();
    }
    
    static UpdateButton(button, rect) {
        const wasHovered = button.Hovered;
        button.Hovered = !button.Clicked && rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
        if (button.Hovered) {
            if (!wasHovered) button.OnMouseOver();
            button.WhileHovered();
        } else if (wasHovered) {
            button.OnMouseOut();
        }
        
        if (Main.mouseLeft && Main.mouseLeftRelease && !button.Pressed && !button.Clicked && button.Hovered) {
            button.Pressed = true;
        }
        else if (Main.mouseLeftRelease && button.Pressed) {
            button.Pressed = false;
            if (button.Hovered) ModButton.OnClick(button);
        }
    }
    
    static UpdateClickedButtons() {
        const clicked = [];
        for (let i = 0; i < this.ClickedButtons.length; i++) {
            const b = this.ClickedButtons[i];
            if (ModButton.Time - b.LastClicked >= b.ClickedTime) {
                b.Clicked = false;
                continue;
            }
            clicked.push(b);
        }
        this.ClickedButtons = clicked;
    }
    
    static OnClick(button, time) {
        const soundId = button.ClickSound();
        if (soundId !== null) {
            SoundEngine['void PlaySound(int type, Vector2 position, int style, float pitchOffset)'](soundId, Main.LocalPlayer.Center, 1, 0);
        }
        
        button.OnClick();
        
        button.Pressed = false;
        button.Clicked = true;
        button.LastClicked = ModButton.Time;
        ModButton.ClickedButtons.push(button);
    }
}