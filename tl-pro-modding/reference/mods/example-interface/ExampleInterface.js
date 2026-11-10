import { ModInterface } from './InterfaceSystem/ModInterface.js';
import { ModButton } from './InterfaceSystem/ModButton.js';
import { ModSlider } from './InterfaceSystem/ModSlider.js';
// Use the Draw and Microsoft modules in the 'InterfaceSystem/Utilities' folder to make it easier
import { Draw } from './InterfaceSystem/Utilities/Draw.js';
import { Color, Rectangle, Vector2 } from './InterfaceSystem/Utilities/Microsoft.js';

const Main = new NativeClass('Terraria', 'Main');
const NewText = Main['void NewText(string newText, byte R, byte G, byte B)'];

// Registered in 'InterfaceSystem/RegisterAll.js'
export class ExampleInterface extends ModInterface {
    constructor() {
        super();
    }
    
    SetupContent() {
        // First, let's configure the size and color of the panel.
        this.PanelWidth = 256;
        this.PanelHeight = 180;
        this.Panel = Rectangle.new(0, 0, this.PanelWidth, this.PanelHeight);
        this.PanelColor = Color.new(54, 70, 127, 180);
        this.Layout = this.CreateLayout(this.PanelWidth, this.PanelHeight);
        
        // Let's create a button for our interface.
        class Button extends ModButton {
            constructor() {
                super();
            }
            
            Initialize() {
                // Here we will initialize the textures of our button.
                this.BG = tl.texture.load('Textures/ButtonBG.png');
                this.BGHovered = tl.texture.load('Textures/ButtonBGHovered.png');
                this.BGClicked = tl.texture.load('Textures/ButtonBGClicked.png');
                this.Icon = tl.texture.load('Textures/ButtonIcon.png');
            }
            
            GetIconTexture() {
                // We're going to return the texture of this button's icon, it will be drawn over the button.
                return this.Icon;
            }
            
            GetTexture() {
                // Here we will restore the button's texture based on its state.
                if (this.Clicked) return this.BGClicked;
                if (this.Hovered) return this.BGHovered;
                return this.BG;
            }
            
            OnClick() {
                // Our button will send a message in the chat when clicked.
                NewText('Button Clicked!', 0, 255, 0);
            }
        }
        // Let's save and initialize our button in the interface
        this.Button = new Button();
        
        // Now we will create our slider.
        class Slider extends ModSlider {
            constructor(min, max, defaultValue) {
                super(min, max, defaultValue);
            }
            
            Initialize() {
                // Here we will initialize the textures of our slider
                this.SliderBack = tl.texture.load('Textures/SliderBack.png');
                this.SliderButton = tl.texture.load('Textures/SliderButton.png');
            }
            
            GetBackTexture() {
                return this.SliderBack;
            }
            
            GetButtonTexture() {
                return this.SliderButton;
            }
            
            OnClick() {
                // Let's limit the value of the slider to only integers.
                this.Value = Math.floor(this.Value);
                // We will send a message in the chat showing the slider's value whenever it is changed.
                if (this.OldValue !== this.Value) {
                    NewText(`Slider Clicked: ${this.Value}`, 255, 200, 0);
                }
            }
        }
        // Now we save the slider in the interface.
        // The slider will go from 0 to 10, starting at 5.
        this.Slider = new Slider(0, 10, 5);
    }
    
    Draw() {
        // Here we will design our interface, always starting with the panel.
        this.DrawPanel();
        // Now we can draw the button and the slider.
        this.DrawButton();
        this.DrawSlider();
        // And then the interface title.
        this.DrawTitle();
    }
    
    DrawPanel() {
        // Here we decide the position and size of the panel.
        // This centers the panel on the screen.
        this.Panel.X = (Main.screenWidth * 0.5) - this.PanelWidth * 0.5;
        this.Panel.Y = (Main.screenHeight * 0.5) - this.PanelHeight * 0.5;
        
        // Let's recalculate our layout based on the panel.
        // This calculates the interface area so the mouse will function correctly.
        this.Recalculate(this.Layout, this.Panel);
        
        // Now we'll draw the panel.
        Draw.DrawInvBG(this.Panel, this.PanelColor);
    }
    
    DrawButton() {
        const texture = this.Button.GetTexture();
        // We are calculating the button's position, it will be in the center of the panel.
        const rect = this.Button.Area;
        rect.X = (this.Panel.X + this.PanelWidth * 0.5) - texture.Width * 0.5;
        rect.Y = (this.Panel.Y + this.PanelHeight * 0.5) - texture.Height * 0.5;
        rect.Width = texture.Width;
        rect.Height = texture.Height;
        // First, we update the button states.
        ModButton.UpdateButton(this.Button, rect);
        // And then we draw the button.
        this.Button.Draw(rect);
    }
    
    DrawSlider() {
        const texture = this.Slider.GetBackTexture();
        // Let's calculate the slider's position by placing it below the button.
        const rect = this.Slider.Area;
        rect.X = (this.Panel.X + this.PanelWidth * 0.5) - texture.Width * 0.5;
        rect.Y = (this.Panel.Y + this.PanelHeight * 0.75) - texture.Height * 0.5;
        rect.Width = texture.Width;
        rect.Height = texture.Height;
        // First, we update the slider states.
        ModSlider.UpdateSlider(this.Slider, rect);
        // And then we draw the slider.
        this.Slider.Draw(rect);
    }
    
    DrawTitle() {
        const title = 'Example Interface';
        const font = Draw.Fonts.MouseText();
        const titlePos = Vector2.new(this.Panel.X + this.Panel.Width * 0.5, this.Panel.Y + this.Panel.Height * 0.2);
        const scale = 1.35;
        Draw.BorderStringCentered(font, title, titlePos, Color.White, scale);
    }
}