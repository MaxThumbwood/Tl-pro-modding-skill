import { Terraria, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';

const { MathHelper, Vector2 } = Modules;

export class ExampleSpearProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    HoldoutRangeMin = 24;
    HoldoutRangeMax = 96;
    
    SetDefaults() {
        this.CloneDefaults(Terraria.ID.ProjectileID.Spear);
    }
    
    PreAI(proj) {
        const player = Terraria.Main.player[proj.owner];
        let duration = player.itemAnimationMax;
        
        player.heldProj = proj.whoAmI;
        
        if (proj.timeLeft > duration) {
            proj.timeLeft = duration;
        }
        
        proj.velocity = Vector2.Normalize(proj.velocity);
        
        let halfDuration = duration * 0.5;
        let progress;
        
        // Here 'progress' is set to a value that goes from 0.0 to 1.0 and back during the item use animation.
        if (proj.timeLeft < halfDuration) {
            progress = proj.timeLeft / halfDuration;
        } else {
            progress = (duration - proj.timeLeft) / halfDuration;
        }
        
        // Move the projectile from the HoldoutRangeMin to the HoldoutRangeMax and back, using SmoothStep for easing the movement
        proj.Center = Vector2.Add(player.MountedCenter, Vector2.SmoothStep(Vector2.Multiply(proj.velocity, this.HoldoutRangeMin), Vector2.Multiply(proj.velocity, this.HoldoutRangeMax), progress));
        
        // Apply proper rotation to the sprite.
        if (proj.spriteDirection == -1) {
            proj.rotation += MathHelper.ToRadians(45);
        } else {
            proj.rotation += MathHelper.ToRadians(135);
        }
        
        // Don't execute vanilla AI.
        return false;
    }
}