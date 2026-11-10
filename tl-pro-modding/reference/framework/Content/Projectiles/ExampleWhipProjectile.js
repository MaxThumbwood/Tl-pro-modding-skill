import { Terraria, Microsoft, Modules, System } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { SpriteEffects } = Microsoft.Xna.Framework.Graphics;
const { MathHelper, Vector2, Rectangle, Color } = Modules;
const GetLerpValue = Terraria.Utils['float GetLerpValue(float from, float to, float t, bool clamped)'];
const GetColor = Terraria.Lighting['Color GetColor(Point tileCoords, Color originalColor)'];

export class ExampleWhipProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Terraria.ID.ProjectileID.Sets.IsAWhip[this.Type] = true;
    }
    
    SetDefaults() {
        this.DefaultToWhip();
        this.ControlPoints = System.Collections.Generic.List.makeGeneric(Microsoft.Xna.Framework.Vector2).new();
        this.ControlPoints['void .ctor()']();
    }
    
    CachedValues = {
        // These two values are set to suit this projectile's sprite, but won't necessarily work for your own.
        Frame: Rectangle.new(0, 0, 10, 26), // The size of the Handle (measured in pixels)
        Origin: Vector2.new(5, 8) // Offset for where the player's hand will start measured from the top left of the image.
    };
    
    // This method draws a line between all points of the whip, in case there's empty space between the sprites.
    DrawLine(list) {
        if (!this.CachedValues.FishingLineTexture) {
            this.CachedValues.FishingLineTexture = Terraria.GameContent.TextureAssets.FishingLine.Value;
            this.CachedValues.FishingLineTextureFrame = Rectangle.new(0, 0, this.CachedValues.FishingLineTexture.Width, this.CachedValues.FishingLineTexture.Height);
            this.CachedValues.FishingLineTextureOrigin = Vector2.new(this.CachedValues.FishingLineTextureFrame.Width / 2, 2);
        }
        
        let texture = this.CachedValues.FishingLineTexture;
        let frame = this.CachedValues.FishingLineTextureFrame;
        let origin = this.CachedValues.FishingLineTextureOrigin;
        
        let pos = list[0];
        const length = list.length - 1;
        for (let i = 0; i < length; i++) {
            let element = list[i];
            let diff = Vector2.Subtract(list[i + 1], element);
            
            let rotation = Vector2.ToRotation(diff) - MathHelper.PiOver2;
            let color = Terraria.Lighting['Color GetColor(Point tileCoords, Color originalColor)'
            ](Vector2.ToTileCoordinates(element), Color.White);
            let scale = Vector2.UnitX;
            scale.Y = (diff.Length() + 2) / frame.Height;
            
            Terraria.Main['void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float worthless)'
            ](
                texture,
                Vector2.Subtract(pos, Terraria.Main.screenPosition),
                frame,
                color,
                rotation,
                origin,
                scale,
                SpriteEffects.None,
                0
            );
            
            pos = Vector2.Add(pos, diff);
        }
    }
    
    PreDraw(proj) {
        const player = Terraria.Main.player[proj.owner];
        
        let _list = this.ControlPoints;
        _list.Clear();
        Terraria.Projectile.FillWhipControlPoints(proj, _list, Terraria.Main.player[proj.owner], true, 0);
        let list = _list.ToArray();
        
        // Draw the line if there are empty spaces between the sprites.
        //this.DrawLine(list);
        
        let flip = proj.spriteDirection < 0 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
        let texture = Terraria.GameContent.TextureAssets.Projectile[this.Type].Value;
        
        let pos = list[0];
        let frame = this.CachedValues.Frame;
        let origin = this.CachedValues.Origin;
        
        const screenPosition = Terraria.Main.screenPosition;
        const length = list.length - 1;
        for (let i = 0; i < length; i++) {
            let scale = 1;
            
            // These statements determine what part of the spritesheet to draw for the current segment.
            if (i === length - 1) {
                // This is the head of the whip. You need to measure the sprite to figure out these values.
                frame.Y = 74;
                frame.Height = 18;
                let t = proj.ai.val0 / (player.itemAnimationMax * proj.MaxUpdates);
                scale = MathHelper.Lerp(0.5, 1.5, GetLerpValue(0.1, 0.7, t, true) * GetLerpValue(0.9, 0.7, t, true));
            } else if (i > 10) {
                // Third segment
                frame.Y = 58;
                frame.Height = 16;
            } else if (i > 5) {
                // Second Segment
                frame.Y = 42;
                frame.Height = 16;
            } else if (i > 0) {
                // First Segment
                frame.Y = 26;
                frame.Height = 16;
            }
            
            let element = list[i];
            let diff = Vector2.Subtract(list[i + 1], element);
            let rotation = Vector2.ToRotation(diff) - MathHelper.PiOver2;
            
            let color = GetColor(Vector2.ToTileCoordinates(element), Color.White);
            
            Terraria.Main['void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float worthless)'
            ](
                texture,
                Vector2.Subtract(pos, screenPosition),
                frame,
                color,
                rotation,
                origin,
                scale,
                flip,
                0
            );
            
            pos = Vector2.Add(pos, diff);
        }
        
        return false;
    }
}