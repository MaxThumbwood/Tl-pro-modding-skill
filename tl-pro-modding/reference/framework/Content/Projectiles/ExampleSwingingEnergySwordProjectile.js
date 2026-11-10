import { Terraria, Microsoft, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { SpriteEffects } = Microsoft.Xna.Framework.Graphics;
const { Color, Effects, MathHelper, Vector2, Rectangle } = Modules;
const { Dust, Lighting, Main, Utils } = Terraria;
const { TextureAssets } = Terraria.GameContent;
const Frame = Utils['Rectangle Frame(Texture2D tex, int horizontalFrames, int verticalFrames, int frameX, int frameY, int sizeOffsetX, int sizeOffsetY)'];
const Remap = Utils['float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped)'];

export class ExampleSwingingEnergySwordProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Main.projFrames[this.Type] = 4;
    }
    
    SetDefaults() {
        this.Projectile.width = this.Projectile.height = 16;
        this.Projectile.melee = true;
        this.Projectile.aiStyle = 190;
        this.Projectile.friendly = true;
        this.Projectile.tileCollide = false;
        this.Projectile.ignoreWater = true;
        this.Projectile.usesLocalNPCImmunity = true
        this.Projectile.localNPCHitCooldown = -1;
        this.Projectile.ownerHitCheck = true;
        this.Projectile.ownerHitCheckDistance = 300;
        this.Projectile.usesOwnerMeleeHitCD = true;
        this.Projectile.penetrate = -1;
        this.Projectile.noEnchantmentVisuals = true;
    }
    
    AI(proj) {
        const ai = new ProjAI(proj);
        const localAI = new ProjAI(proj, true);
        
        const player = Main.player[proj.owner];
        localAI[0]++;
        
        let percentageOfLife = localAI[0] / ai[1];
        let scaleMulti = 0.8;
        let scaleAdder = 1.0;
        
        proj.Center = Vector2.Subtract(player.RotatedRelativePoint(player.MountedCenter, false, true, 0), proj.velocity);
        proj.scale = scaleAdder + percentageOfLife * scaleMulti;
        
        let offset = proj.rotation + Utils.NextFloatDirection(Main.rand) * (Math.PI / 2) * 0.7;
        let position = Vector2.Add(proj.Center, Vector2.Multiply(Utils.ToRotationVector2(offset), 84 * proj.scale));
        let velocity = Utils.ToRotationVector2(offset + ai[0] * (Math.PI / 2));
        
        if (Utils['float NextFloat(UnifiedRandom r)'](Main.rand) < proj.Opacity) {
            // Original Excalibur color: Color.Gold, Color.White
            const dustColor = Color.Lerp(Color.SkyBlue, Color.White, Utils['float NextFloat(UnifiedRandom r)'](Main.rand) * 0.3);
            let dust = Dust.NewDustPerfect(Vector2.Add(proj.Center, Vector2.Multiply(Utils.ToRotationVector2(offset), Utils['float NextFloat(UnifiedRandom r)'](Main.rand) * 80 * proj.scale + 20 * proj.scale)), 278, velocity, 50, dustColor, 0.8);
            dust.fadeIn = 0.4 + Utils['float NextFloat(UnifiedRandom r)'](Main.rand) * 0.15;
            dust.noGravity = true;
        }
        
        if (Utils['float NextFloat(UnifiedRandom r)'](Main.rand) * 1.5 < proj.Opacity) {
            // Original Excalibur color: Color.White
            const dustColor2 = Color.SkyBlue;
            let dust2 = Dust.NewDustPerfect(position, 278, Vector2.Multiply(velocity, 1.5), 100, Color.op_Multiply(dustColor2, proj.Opacity), proj.Opacity);
            dust2.noGravity = true;
        }
        
        // If the projectile is as old as the max animation time, kill the projectile.
        if (localAI[0] >= ai[1]) proj.Kill();
        // Set the scale of the projectile to the scale of the item.
        proj.scale *= ai[2];
    }
    
    OnHitNPC(proj, npc) {
        let particle = Terraria.GameContent.Drawing.ParticleOrchestrator._poolPrettySparkle.RequestParticle();
        particle.LocalPosition = Utils.NextVector2FromRectangle(Main.rand, npc.Hitbox);
        particle.Velocity = Vector2.Zero;
        particle.ColorTint =  Color.SkyBlue;
        particle.Scale = Vector2.One;
        particle.TimeToLive = 40;
        Terraria.Main.ParticleSystem_World_OverPlayers.Add(particle);
    }
    
    PreDraw(proj, lightColor) {
        this.DrawLikeExcalibur(
            proj,
            Color.new(60, 160, 180), // Back - Original Excalibur color: Color(180, 160, 60)
            Color.new(80, 255, 255), // Middle - Original Excalibur color: Color(255, 255, 80)
            Color.new(150, 240, 255) // Front - Original Excalibur color: Color(255, 240, 150)
        );
        return false;
    }
    
    DrawLikeExcalibur(proj, backDarkColor, middleMediumColor, frontLightColor) {
        const ai = new ProjAI(proj);
        const localAI = new ProjAI(proj, true);
        const Draw = Main.spriteBatch['void Draw(Texture2D texture, Vector2 position, Nullable`1 sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)'];
        const White = Color.White;
        let position = Vector2.Subtract(proj.Center, Main.screenPosition);
        let texture = TextureAssets.Projectile[this.Type].Value;
        let sourceRectangle = Frame(texture, 1, Main.projFrames[this.Type], 0, 0, 0, 0);
        let finalFrame = Frame(texture, 1, Main.projFrames[this.Type], 0, 3, 0, 0);
        let origin = Vector2.Multiply(Rectangle.Size(sourceRectangle), 0.5);
        let scale = proj.scale * 1.1;
        let spriteEffects = (!(ai[0] >= 0)) ? SpriteEffects.FlipVertically : SpriteEffects.None;
        let percentageOfLife = localAI[0] / ai[1];
        let lerpTime = Remap(percentageOfLife, 0, 0.5, 0, 1, true) * Remap(percentageOfLife, 0.5, 1, 1, 0, true);
        let lightingColor = Lighting['Color GetColor(Point tileCoords)'](Utils['Point ToTileCoordinates(Vector2 vec)'](proj.Center)).ToVector3().Length() / Math.sqrt(3.0);
        lightingColor = Remap(lightingColor, 0.2, 1, 0, 1, true);
        
        let whiteTimesLerpTime = Color.Multiply(White, lerpTime * 0.5);
        whiteTimesLerpTime.A = whiteTimesLerpTime.A * (1 - lightingColor);
        let faintLightingColor = Color.Multiply(whiteTimesLerpTime, lightingColor * 0.5);
        faintLightingColor.G *= lightingColor;
        faintLightingColor.B = faintLightingColor.R * (0.25 + lightingColor * 0.75);
        
        // Back part
        Draw(texture, position, sourceRectangle, Color.Multiply(backDarkColor, lightingColor * lerpTime), proj.rotation + ai[0] * MathHelper.PiOver4 * -1 * (1 - percentageOfLife), origin, scale, spriteEffects, 0);
        // Very faint part affected by the light color
        Draw(texture, position, sourceRectangle, Color.Multiply(faintLightingColor, 0.15), proj.rotation + ai[0] * 0.01, origin, scale, spriteEffects, 0);
        // Middle part
        Draw(texture, position, sourceRectangle, Color.Multiply(middleMediumColor, lightingColor * lerpTime * 0.3), proj.rotation, origin, scale, spriteEffects, 0);
        // Front part
        Draw(texture, position, sourceRectangle, Color.Multiply(frontLightColor, lightingColor * lerpTime * 0.5), proj.rotation, origin, scale * 0.975, spriteEffects, 0);
        // Thin top line (final frame)
        Draw(texture, position, finalFrame, Color.Multiply(White, 0.6 * lerpTime), proj.rotation + ai[0] * 0.01, origin, scale, spriteEffects, 0);
        // Thin middle line (final frame)
        Draw(texture, position, finalFrame, Color.Multiply(White, 0.6 * lerpTime), proj.rotation + ai[0] * -0.05, origin, scale * 0.8, spriteEffects, 0);
        // Thin bottom line (final frame)
        Draw(texture, position, finalFrame, Color.Multiply(White, 0.6 * lerpTime), proj.rotation + ai[0] * -0.1, origin, scale * 0.6, spriteEffects, 0);
        
        for (let i = 0; i < 8; i += 1) {
            const edgeRotation = proj.rotation + ai[0] * i * (MathHelper.Pi * -2) * 0.025 + Remap(percentageOfLife, 0, 1, 0, MathHelper.PiOver4, true) * ai[0];
            const drawPos = Vector2.Add(position, Vector2.Multiply(Vector2.ToRotationVector2(edgeRotation), (texture.Width * 0.5 - 6) * scale));
            this.DrawPrettyStarSparkle(proj.Opacity, SpriteEffects.None, drawPos, Color.Multiply(Color.new(255, 255, 255, 0), lerpTime * (i / 9)), middleMediumColor, percentageOfLife, 0, 0.5, 0.5, 1, edgeRotation, Vector2.Multiply(Vector2.new(0, Remap(percentageOfLife, 0, 1, 3, 0, true)), scale), Vector2.Multiply(Vector2.One, scale));
        }
        
        // This draws a large star sparkle at the front of the projectile.
        let edgeRot = proj.rotation + Remap(percentageOfLife, 0, 1, 0, MathHelper.PiOver4, true) * ai[0];
        let drawPos2 = Vector2.Add(position,Vector2.Multiply(Vector2.ToRotationVector2(edgeRot),(texture.Width * 0.5 - 4) * scale));
        this.DrawPrettyStarSparkle(proj.Opacity, SpriteEffects.None, drawPos2, Color.Multiply(Color.new(255, 255, 255, 0), lerpTime * 0.5), middleMediumColor, percentageOfLife, 0, 0.5, 0.5, 1, 0, Vector2.Multiply(Vector2.new(2, Remap(percentageOfLife, 0, 1, 4, 1, true)), scale), Vector2.Multiply(Vector2.One, scale));
    }
    
    DrawPrettyStarSparkle(opacity, dir, drawPos, drawColor, shineColor, flareCounter, fadeInStart, fadeInEnd, fadeOutStart, fadeOutEnd, rotation, scale, fatness) {
        const texture = TextureAssets.Extra[98].Value;
        const Draw = Main.spriteBatch['void Draw(Texture2D texture, Vector2 position, Nullable`1 sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)'];
        let bigColor = Color.Multiply(shineColor, opacity * 0.5);
        bigColor.A = 0;
        const origin = Vector2.new(texture.Width / 2, texture.Height / 2);
        let smallColor = Color.Multiply(drawColor, 0.5);
        const GetLerpValue = Utils['float GetLerpValue(float from, float to, float t, bool clamped)'];
        const lerpValue = GetLerpValue(fadeInStart, fadeInEnd, flareCounter, true) * GetLerpValue(fadeOutEnd, fadeOutStart, flareCounter, true);
        const scaleLeftRight = Vector2.Multiply(Vector2.new(fatness.X * 0.5, scale.X), lerpValue);
        const scaleUpDown = Vector2.Multiply(Vector2.new(fatness.Y * 0.5, scale.Y), lerpValue);
        bigColor = Color.Multiply(bigColor, lerpValue);
        smallColor = Color.Multiply(smallColor, lerpValue);
        Draw(texture, drawPos, null, bigColor, MathHelper.PiOver2 + rotation, origin, scaleLeftRight, dir, 0);
        Draw(texture, drawPos, null, bigColor, rotation, origin, scaleUpDown, dir, 0);
        Draw(texture, drawPos, null, smallColor, MathHelper.PiOver2 + rotation, origin, Vector2.Multiply(scaleLeftRight, 0.6), dir, 0);
        Draw(texture, drawPos, null, smallColor, rotation, origin, Vector2.Multiply(scaleUpDown, 0.6), dir, 0);
    }
}