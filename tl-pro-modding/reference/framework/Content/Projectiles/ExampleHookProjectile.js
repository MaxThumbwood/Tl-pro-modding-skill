import { Terraria, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { Main } = Terraria;
const { Color, MathHelper, Vector2 } = Modules;

const EntitySpriteDraw = Main['void EntitySpriteDraw(Texture2D texture, Vector2 position, Rectangle sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float worthless)'];
const GetColor = Terraria.Lighting['Color GetColor(int x, int y)'];

/**
 * Developer Notes
 * 1. The Mod Grapple Hooks is limited to only 3 active hooks at a time.
 * 2. You can change this down, as shown in this example, which only allows 2 active hooks at the same time.
 * 3. You can increase this using AIType, for example, the web shooter which allows up to 8 hooks, and then reduce it to 7, 6, etc.
 * 4. When using AIType, the `GrappleCanLatchOnTo()` method will not be called.
 * 5. If you are not using AIType, you will need to manually retract the hook in `AI()` as shown in this example.
 */
export class ExampleHookProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetDefaults() {
        this.CloneDefaults(Terraria.ID.ProjectileID.GemHookAmethyst); // Copies the attributes of the Amethyst hook's projectile.
        
        // Copies the AI from an existing hook
        //this.AIType = Terraria.ID.ProjectileID.SquirrelHook;
    }
    
    SetStaticDefaults() {
        this.ChainTexture = tl.texture.load('Textures/Projectiles/ExampleHookChain.png');
        this.GrappleRange = 300;
        this.NumGrappleHooks = 2;
    }
    
    AI(proj) {
        const ai = new ProjAI(proj);
        const owner = Main.player[proj.owner];
        
        if (owner.Distance(proj.Center) > this.GrappleRange) {
            ai[0] = 1; // retracting
        }
    }
    
    // Use this to remove the oldest hook.
    // Return a different type to fire another hook, for example Dual Hook / Lunar Hook.
    UseGrapple(player, type) {
        if (player.ownedProjectileCounts[type] >= this.NumGrappleHooks) {
            const projArr = Main.projectile;
            let oldestHook = null;
            for (let i = 0; i < 1000; i++) {
                const proj = projArr[i];
                if (proj && proj.active && proj.type === type && proj.owner === player.whoAmI && (!oldestHook || proj.timeLeft < oldestHook.timeLeft)) oldestHook = proj;
            }
            if (oldestHook) oldestHook.Kill();
        }
        return type;
    }
    
    // This method will not be called if you use AIType.
    GrappleCanLatchOnTo(proj, player, tile) {
        // By default, the hook returns null to apply the vanilla conditions for the given tile position (this tile position could be air or an actuated tile!)
        // If you want to return true here, make sure to check for !tile['bool actuator()']() (and Main.tileSolid[tile.type] and/or tile['bool active()']() if needed
        
        // We make this hook latch onto trees just like Squirrel Hook
        
        // Tree trunks cannot be actuated so we don't need to check for that here
        if (Terraria.ID.TileID.Sets.IsATreeTrunk[tile.type] || tile.type === Terraria.ID.TileID.PalmTree) {
            return true;
        }
        
        // In any other case, behave like a normal hook
        return null;
    }
    
    // Draws the grappling hook's chain.
    PreDraw(proj, lightColor) {
        const screenPos = Main.screenPosition;
        const player = Main.player[Main.myPlayer];
        const playerCenter = player.MountedCenter;
        let center = proj.Center;
        let directionToPlayer = Vector2.Subtract(playerCenter, center);
        let distanceToPlayer = directionToPlayer['float Length()']();
        const chainRotation = Vector2.ToRotation(directionToPlayer) - MathHelper.PiOver2;
        const origin = Vector2.new(this.ChainTexture.Width / 2, this.ChainTexture.Height / 2);
        
        while (distanceToPlayer > 20 && !Number.isNaN(distanceToPlayer)) {
            directionToPlayer = Vector2.Divide(directionToPlayer, distanceToPlayer); // get unit vector
            directionToPlayer = Vector2.Multiply(directionToPlayer, this.ChainTexture.Height); // multiply by chain link length
            center = Vector2.Add(center, directionToPlayer);
            directionToPlayer = Vector2.Subtract(playerCenter, center);
            distanceToPlayer = directionToPlayer['float Length()']();
            
            const drawColor = GetColor(center.X / 16, center.Y / 16);
            EntitySpriteDraw(
                this.ChainTexture,
                Vector2.Subtract(center, screenPos),
                null, drawColor, chainRotation, origin, 1.0, null, 0
            );
        }
        
        return true;
    }
}