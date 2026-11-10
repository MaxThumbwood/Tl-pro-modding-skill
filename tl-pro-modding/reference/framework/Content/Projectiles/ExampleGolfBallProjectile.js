import { Terraria } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';

export class ExampleGolfBallProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Terraria.ID.ProjectileID.Sets.IsAGolfBall[this.Type] = true; // Allows the projectile to be placed on the tee.
        Terraria.ID.ProjectileID.Sets.TrailingMode[this.Type] = 0; // Creates a trail behind the golf ball.
        Terraria.ID.ProjectileID.Sets.TrailCacheLength[this.Type] = 20; // Sets the length of the trail.
    }

    SetDefaults() {
        this.Projectile.netImportant = true; // Indicates that this projectile will be synced to a joining player (by default, any projectiles active before the player joins (besides pets) are not synced over).
        this.Projectile.width = 7; // The width of the projectile's hitbox.
        this.Projectile.height = 7; // The height of the projectile's hitbox.
        this.Projectile.friendly = true; // Setting this to anything other than true causes an index out of bounds error.
        this.Projectile.penetrate = -1; // Number of times the projectile can penetrate enemies. -1 sets it to infinite penetration.
        this.Projectile.aiStyle = Terraria.ID.ProjAIStyleID.GolfBall; // The aiStyle used by golf balls.
        this.Projectile.tileCollide = false; // Tile Collision is set to false, as it's handled in the AI.
    }
}