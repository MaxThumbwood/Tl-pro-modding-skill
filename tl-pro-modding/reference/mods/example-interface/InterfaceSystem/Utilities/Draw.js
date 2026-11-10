const Main = new NativeClass('Terraria', 'Main');
const FontAssets = new NativeClass('Terraria.GameContent', 'FontAssets');
const Utils = new NativeClass('Terraria', 'Utils');

const Vector2 = new NativeClass('Microsoft.Xna.Framework', 'Vector2');
const Color = new NativeClass('Microsoft.Xna.Framework.Graphics', 'Color');
const Matrix = new NativeClass('Microsoft.Xna.Framework', 'Matrix');
const SpriteEffects = new NativeClass('Microsoft.Xna.Framework.Graphics', 'SpriteEffects');
const SpriteSortMode = new NativeClass('Microsoft.Xna.Framework.Graphics', 'SpriteSortMode');

const LayoutCalculator = new NativeClass('', 'LayoutCalculator');

export class Draw {
    static GetAnchoredPosition(AnchorControl, Anchor, Location) {
        return LayoutCalculator.GetAnchoredPosition(AnchorControl, Anchor, Location);
    }
    
    static DrawInvBG(rect, color) {
        Utils['void DrawInvBG(SpriteBatch sb, Rectangle R, Color c)'](Main.spriteBatch, rect, color);
    }
    
    static BuffTooltip(name, tooltip, x = -1, y = -1) {
        if (x === -1) x = Main.mouseX;
        if (y === -1) y = Main.mouseY;
        Main.instance['void MouseText_DrawBuffTooltip(string cursorText, string buffString, ref int X, ref int Y)'](name, tooltip, x, y);
    }
    
    static Rectangle(texture, rectangle, color) {
        Main.spriteBatch['void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)'
        ](texture, rectangle, color);
    }
    
    static RectangleFramed(texture, destRectangle, sourceRectangle = null, color) {
        Main.spriteBatch['void Draw(Texture2D texture, Rectangle destinationRectangle, Nullable`1 sourceRectangle, Color color)'
        ](texture, destRectangle, sourceRectangle, color);
    }
    
    static Image(texture, position, color) {
        Main.spriteBatch['void Draw(Texture2D texture, Vector2 position, Color color)'
        ](texture, position, color);
    }
    
    static ImageFramed(texture, position, sourceRectangle = null, color) {
        Main.spriteBatch['void Draw(Texture2D texture, Vector2 position, Nullable`1 sourceRectangle, Color color)'
        ](texture, position, sourceRectangle, color);
    }
    
    static Fonts = {
        MouseText: () => FontAssets.MouseText.Value,
        ItemStack: () => FontAssets.ItemStack.Value,
        DeathText: () => FontAssets.DeathText.Value,
        CombatText: (i) => FontAssets.CombatText[i].Value
    };
    
    static GetStringSize(font, text) {
        return font['Vector2 MeasureString(string text)'](text);
    }
    
    static String(font, text, position, color = Color.White, scale = 1.0) {
        Main.spriteBatch['void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)'
        ](font, text, position, color, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
    }
    
    static StringCentered(font, text, position, color = Color.White, scale = 1.0) {
        const size = this.GetStringSize(font, text);
        const origin = Vector2.Zero;
        origin.X = size.X * 0.5; origin.Y = size.Y * 0.5;
        Main.spriteBatch['void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)'
        ](font, text, position, color, 0, origin, scale, SpriteEffects.None, 0);
    }
    
    static BorderString(font, text, position, color = Color.White, scale = 1.0) {
        Utils['void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale)'
        ](Main.spriteBatch, font, text, position.X, position.Y, color, Color.Black, Vector2.Zero, scale);
    }
    
    static BorderStringCentered(font, text, position, color = Color.White, scale = 1.0) {
        const size = this.GetStringSize(font, text);
        const origin = Vector2.new();
        origin.X = size.X * 0.5; origin.Y = size.Y * 0.5;
        Utils['void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale)'
        ](Main.spriteBatch, font, text, position.X, position.Y, color, Color.Black, origin, scale);
    }
    
    static NewSpriteBatchForUI() {
        Main.spriteBatch['void End()']();
        Main.spriteBatch['void Begin(SpriteSortMode sortMode, BlendState blendState, SamplerState samplerState, DepthStencilState depthStencilState, RasterizerState rasterizerState, Effect effect, Nullable`1 transformMatrix, bool defferedBatch)'
        ](SpriteSortMode.Deferred, null, null, null, null, null, Matrix.Identity, true);
    }
}