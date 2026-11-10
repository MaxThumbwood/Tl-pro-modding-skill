import { Terraria, Microsoft, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { SpriteEffects } = Microsoft.Xna.Framework.Graphics;
const { Color, Vector2, Rectangle } = Modules;

export class ExampleAdvancedAnimatedProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Terraria.Main.projFrames[this.Type] = 4
    }
    
    SetDefaults() {
        this.Projectile.width = 40;
        this.Projectile.height = 40;
        this.Projectile.friendly = true;
        this.Projectile.melee = true;
        this.Projectile.penetrate = -1;
        this.Projectile.ignoreWater = true;
        this.Projectile.tileCollide = false;
        this.Projectile.alpha = 255;
        this.Projectile.usesLocalNPCImmunity = true;
        this.Projectile.localNPCHitCooldown = -1;
    }
    
    GetAlpha(proj, color) {
        return Color.Multiply(Color.new(255, 255, 255, 0), proj.Opacity);
    }
    
    AI(proj) {
        const ai = new ProjAI(proj);
        ai[0]++
        
        this.FadeInAndOut(proj, ai);
        
        proj.velocity = Vector2.Multiply(proj.velocity, 0.98);
        
        if (++proj.frameCounter >= 5) {
            proj.frameCounter = 0;
            if (++proj.frame >= Terraria.Main.projFrames[this.Type]) {
                proj.frame = 0;
            }
        }
        
        if (ai[0] >= 60) proj.Kill();
        proj.direction = proj.spriteDirection = (proj.velocity.X > 0) ? 1 : -1;
        proj.rotation = Vector2.ToRotation(proj.velocity);
        
        if (proj.spriteDirection == -1) {
            proj.rotation += Math.PI;
        }
    }
    
    FadeInAndOut(proj, ai) {
        if (ai[0] <= 50) {
            proj.alpha -= 25;
            if (proj.alpha < 100) proj.alpha = 100;
            return;
        }
        
        proj.alpha += 25;
        if (proj.alpha > 255) proj.alpha = 255;
    }
    
    PreDraw(proj) {
        let spriteEffects = proj.spriteDirection == -1
        ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
        
        let texture = Terraria.GameContent.TextureAssets.Projectile[this.Type].Value;
        
        let frameHeight = texture.Height / Terraria.Main.projFrames[this.Type];
        let startY = frameHeight * proj.frame;
        let sourceRectangle = Rectangle.new(0, startY, texture.Width, frameHeight);
        let origin = Vector2.Multiply(
            Rectangle.Size(sourceRectangle),
            0.5
        );
        
        let offsetX = 20;
        origin.X = proj.spriteDirection == 1 ? sourceRectangle.Width - offsetX : offsetX;
        
        let lightingColor = Terraria.Lighting['Color GetColor(int x, int y)'](proj.position.X / 16, proj.position.Y / 16);
        let color = this.GetAlpha(proj, lightingColor);
        let position = Vector2.Add(
            Vector2.Subtract(
                proj.Center,
                Terraria.Main.screenPosition
            ),
            proj.gfxOffY
        );
        
        Terraria.Main['void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float worthless)'
        ](
            texture,
            position,
            sourceRectangle,
            color,
            proj.rotation,
            origin,
            proj.scale,
            spriteEffects,
            0
        );
        
        return false;
    }
}