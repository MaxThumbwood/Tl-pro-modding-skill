import { Terraria } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';

export class ExampleSentryShot extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        // It is important that projectiles shot by sentries are in this set to properly work with effects that are triggered by sentry attacks.
        Terraria.ID.ProjectileID.Sets.SentryShot[this.Type] = true;
    }
    
    SetDefaults() {
        this.Projectile.width = this.Projectile.height = 16;
        this.Projectile.friendly = true;
        this.Projectile.timeLeft = 600;
    }
}