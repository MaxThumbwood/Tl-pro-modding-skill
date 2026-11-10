import { Color, Rectangle } from './Utilities/Microsoft.js';
import { Draw } from './Utilities/Draw.js';

const Main = new NativeClass('Terraria', 'Main');

export class ModSlider {
    constructor(min = 0, max = 1, defaultValue) {
        this.MinValue = min;
        this.MaxValue = max;
        this.DefaultValue = this.OldValue = this.Value = defaultValue ?? min;
        this.Position = this.OldPosition = this.GetButtonPosition();
        this.Area = Rectangle.new();
        this.Initialize();
    }
    
    Initialize() {
        
    }
    
    GetBackTexture() {
        return null;
    }
    
    GetBackTextureColor() {
        return Color.White;
    }
    
    GetButtonTexture() {
        return null;
    }
    
    GetButtonTextureColor() {
        return Color.White;
    }
    
    GetButtonPosition() {
        return Math.max(0, Math.min(1, (this.Value - this.MinValue) / (this.MaxValue - this.MinValue)));
    }
    
    OnMouseOver() {
        
    }
    
    OnMouseOut() {
        
    }
    
    WhileHovered() {
        
    }
    
    OnClick() {
        
    }
    
    Draw(rect) {
        this.OldPosition = this.Position;
        this.Position = this.GetButtonPosition();
        Draw.Rectangle(this.GetBackTexture(), rect, this.GetBackTextureColor());
        const buttonTexture = this.GetButtonTexture();
        const buttonRect = Rectangle.new(rect.X + (rect.Width - buttonTexture.Width) * this.Position, rect.Y, buttonTexture.Width, buttonTexture.Height);
        Draw.Rectangle(buttonTexture, buttonRect, this.GetButtonTextureColor());
    }
    
    static UpdateSlider(slider, rect) {
        const wasHovered = slider.Hovered;
        slider.Hovered = rect['bool Contains(int x, int y)'](Main.mouseX, Main.mouseY);
    
        if (slider.Hovered) {
            if (!wasHovered) slider.OnMouseOver();
            slider.WhileHovered();
        } else if (wasHovered) {
            slider.OnMouseOut();
        }
    
        if (Main.mouseLeft && Main.mouseLeftRelease && slider.Hovered) {
            slider.Clicked = true;
        }
    
        if (slider.Clicked) {
            const t = Math.max(0, Math.min(1, (Main.mouseX - rect.X) / rect.Width));
            slider.OldValue = slider.Value;
            slider.Value = slider.MinValue + t * (slider.MaxValue - slider.MinValue);
            slider.OnClick();
            if (!Main.mouseLeft) {
                slider.Clicked = false;
            }
        }
    }
}