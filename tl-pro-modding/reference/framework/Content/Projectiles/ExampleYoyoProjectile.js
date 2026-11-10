import { Terraria } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';

export class ExampleYoyoProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Terraria.ID.ProjectileID.Sets.YoyosLifeTimeMultiplier[this.Type] = 3.5;
        Terraria.ID.ProjectileID.Sets.YoyosMaximumRange[this.Type] = 300;
        Terraria.ID.ProjectileID.Sets.YoyosTopSpeed[this.Type] = 13;
    }
    
    SetDefaults() {
        this.Projectile.extraUpdates = 0;
        this.Projectile.width = 16;
        this.Projectile.height = 16;
        this.Projectile.aiStyle = Terraria.ID.ProjAIStyleID.Yoyo;
        this.Projectile.friendly = true;
        this.Projectile.penetrate = -1;
        this.Projectile.melee = true;
        this.Projectile.drawLayer = 7;
    }
}