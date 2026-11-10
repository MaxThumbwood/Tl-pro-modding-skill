import { Terraria, Microsoft, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { Color, MathHelper, Rectangle, Vector2 } = Modules;
const { SpriteEffects } = Microsoft.Xna.Framework.Graphics;

const EntitySpriteDraw = Terraria.Main['void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float worthless)'];
const NewDust = Terraria.Dust['int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX, float SpeedY, int Alpha, Color newColor, float Scale)'];
const CheckSolidCollision = Terraria.Collision['bool SolidCollision(Vector2 Position, int Width, int Height)'];

const Vector3 = new NativeClass('Microsoft.Xna.Framework', 'Vector3');
const Multiply = Vector3['Vector3 Multiply(Vector3 value1, float scaleFactor)'];
const AddLight = Terraria.Lighting['void AddLight(Vector2 position, Vector3 rgb)'];

export class ExampleLaserBeam extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
        this.MaxLaserLength = 1000;
        this.HoldoutDistance = 10;
    }
    
    GetLaserColor(proj) {
        return Color.new(128, 200, 255);
    }
    GetDustColor(proj) {
        return this.GetLaserColor(proj);
    }
    GetLightColor(proj) {
        return this.GetLaserColor(proj);
    }
    GetLightIntensity(proj) {
        return 0.85 * Terraria.Main.essScale * proj.scale;
    }

    SetStaticDefaults() {
        Terraria.Main.projFrames[this.Type] = 3;
    }

    SetDefaults() {
        this.Projectile.width = this.Projectile.height = 10;
        this.Projectile.friendly = true;
        this.Projectile.hostile = false;
        this.Projectile.magic = true;
        this.Projectile.penetrate = -1; 
        this.Projectile.tileCollide = false;
        this.Projectile.extraUpdates = 0;
        this.Projectile.usesLocalNPCImmunity = true;
        this.Projectile.localNPCHitCooldown = 10; 
    }

    GetLaserEnd(startPos, rotation) {
        let dist = 0;
        let unitX = Math.cos(rotation);
        let unitY = Math.sin(rotation);
        let current = Vector2.new(startPos.X, startPos.Y);
        while (dist <= this.MaxLaserLength) {
            current.X = startPos.X + (unitX * dist);
            current.Y = startPos.Y + (unitY * dist);
            if (CheckSolidCollision(current, 1, 1)) {
                return dist;
            }
            dist += 16;
        }
        return this.MaxLaserLength;
    }

    AI(proj) {  
        const ai = new ProjAI(proj);  
        const player = Terraria.Main.player[proj.owner];  
        const holdout = Terraria.Main.projectile[ai[0]];  
          
        if (!holdout || !holdout.active) {  
            proj.Kill();  
            return;  
        }  
          
        proj.timeLeft = 2;  
        proj.rotation = holdout.rotation - MathHelper.PiOver2;  
        const dir = Vector2.new(Math.cos(proj.rotation), Math.sin(proj.rotation));  
        proj.Center = Vector2.Add(holdout.Center, Vector2.Multiply(dir, this.HoldoutDistance));  
        proj.velocity = Vector2.Zero;  
          
        proj.scale += 0.05;  
        if (proj.scale > 1.0) proj.scale = 1.0;  
          
        ai[1] = this.GetLaserEnd(proj.Center, proj.rotation);  
          
        if (proj.owner === Terraria.Main.myPlayer) {  
            const len = ai[1];  
            const cos = Math.cos(proj.rotation);  
            const sin = Math.sin(proj.rotation);  
            const dir = Vector2.new(cos, sin);  
            const start = proj.Center;  
            const end = Vector2.Add(start, Vector2.Multiply(dir, len));  
              
            // Damage NPCs  
            if (ai[2] % 5 === 0) this.DamageNPCs(proj, player, dir, len, start, end);  
            ai[2]++; // Timer  
              
            // Cast Lights  
            for (let i = 0; i <= len; i += 48) {  
                AddLight(Vector2.new(start.X + cos * i, start.Y + sin * i), Multiply(this.GetLightColor(proj).ToVector3(), this.GetLightIntensity(proj)));
            }  
              
            // Spawn Dust  
            if (Terraria.Main.netMode !== 2 && ai[1] < this.MaxLaserLength && ai[2] % 5 === 0) {
                const dustColor = this.GetDustColor(proj);
                const dustPos = Vector2.Subtract(end, 8);
                for (let i = 0; i < 16; i++) {  
                    const idx = NewDust(dustPos, 16, 16, 278, 0, 0, 100, dustColor, 1.0 * proj.scale);  
                    Terraria.Main.dust[idx].noGravity = true;
                }
            }
        }  
    }

    DamageNPCs(proj, player, dir, len, start, end) {
        const maxDistSq = (len + 50) * (len + 50);
        const line = Vector2.Subtract(end, start);
        const lineLenSq = line.X * line.X + line.Y * line.Y;
        for (let i = 0; i < 200; i++) {
            const target = Terraria.Main.npc[i];
            if (!target.active || target.friendly || target.dontTakeDamage) continue;
    
            const dx = target.position.X - start.X;
            const dy = target.position.Y - start.Y;
            if (dx * dx + dy * dy > maxDistSq) continue;
    
            const center = Vector2.new(target.position.X + target.width * 0.5, target.position.Y + target.height * 0.5);
            const radius = Math.max(target.width, target.height) * 0.5;
    
            let t = ((center.X - start.X) * line.X + (center.Y - start.Y) * line.Y) / lineLenSq;
            if (t < 0) t = 0;
            else if (t > 1) t = 1;
    
            const closest = Vector2.Add(start, Vector2.Multiply(line, t));
            const distX = center.X - closest.X;
            const distY = center.Y - closest.Y;
    
            if (distX * distX + distY * distY < (30 + radius) * (30 + radius)) {
                if (target.immune[proj.owner] === 0) {
                    this.DamageNPC(proj, player, target);
                    if (proj.usesLocalNPCImmunity) target.immune[proj.owner] = proj.localNPCHitCooldown;
                }
            }
        }
    }
    
    DamageNPC(proj, player, target) {
        const critChance = player.GetWeaponCrit(player.HeldItem);
        const crit = (Math.random() * 100) < critChance;
        const dmg = target.StrikeNPC(player.GetWeaponDamage(player.HeldItem), player.GetWeaponKnockback(player.HeldItem, proj.knockBack), proj.direction, crit, false, proj.owner);
        player.addDPS(dmg);
    }
    
    PreDraw(proj, lightColor) {
        const texture = Terraria.GameContent.TextureAssets.Projectile[this.Type].Value;
        const fh = texture.Height / 3;
        const len = proj.ai.val1;
        const rot = proj.rotation + MathHelper.PiOver2;
        const cos = Math.cos(proj.rotation);
        const sin = Math.sin(proj.rotation);
        const scale = Vector2.new(proj.scale, 1);
        const color = this.GetLaserColor(proj);
        const origin = Vector2.new(texture.Width * 0.5, fh);
        const effects = SpriteEffects.None;
        
        let x = proj.Center.X - Terraria.Main.screenPosition.X;
        let y = proj.Center.Y - Terraria.Main.screenPosition.Y;
        
        // End
        EntitySpriteDraw(
            texture, Vector2.new(x, y),
            Rectangle.new(0, fh * 2, texture.Width, fh),
            color, rot, origin, scale, effects, 0
        );
        
        x += cos * fh;
        y += sin * fh;
        
        // Body
        const bodyLen = len - fh * 2;
        if (bodyLen > 0) {
            const body = Rectangle.new(0, fh, texture.Width, fh);
            for (let i = 0; i < bodyLen; i += fh) {
                EntitySpriteDraw(texture, Vector2.new(x, y), body, color, rot, origin, scale, effects, 0);
                x += cos * fh;
                y += sin * fh;
            }
        }
        
        // Start
        EntitySpriteDraw(
            texture, Vector2.new(x, y),
            Rectangle.new(0, 0, texture.Width, fh),
            color, rot, origin, scale, effects, 0
        );
        
        return false;
    }
}
