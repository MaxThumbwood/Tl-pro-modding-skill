import { Terraria, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';
import { ProjAI } from './../../TL/ProjAI.js';

const { Vector2 } = Modules;
const NewProjectile = Terraria.Projectile['int NewProjectile(IEntitySource spawnSource, Vector2 position, Vector2 velocity, int Type, int Damage, float KnockBack, int Owner, float ai0, float ai1, float ai2, NewProjectileModifier modifer)'];
const PlaySound = Terraria.Audio.SoundEngine['SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position, float pitchOffset, float volumeScale)'];

export class ExampleSentry extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetStaticDefaults() {
        Terraria.Main.projFrames[this.Type] = 4;
    }
    
    SetDefaults() {
        this.Projectile.width = 42;
        this.Projectile.height = 30;
        this.Projectile.sentry = true; // Sets the weapon as a sentry for sentry accessories to properly work.
        this.Projectile.timeLeft = Terraria.Projectile.SentryLifeTime; // Sentries last 10 minutes
        this.Projectile.ignoreWater = true;
        this.Projectile.netImportant = true;
        
        // This allows the projectile to collide with tiles
        this.Projectile.aiStyle = 8;
        this.Projectile.tileCollide = true;
    }
    
    // This is necessary if you use `aiStyle = 8` for sentinels with `tileCollide = true`
    PreAI(proj) {
        this.AI(proj);
        return false;
    }
    
    AI(proj) {
        // ai[0] - ShootTimer
        // ai[1] - target.whoAmI
        // localAI[0] - justSpawned
        const ShootFrequency = 60; // How long the sentry waits between shots.
        const TargetingRange = 50 * 16; // The sentry's targeting range, 50 tiles.
        const FireVelocity = 10; // The velocity the sentry's shot projectile will travel.
        
        const ai = new ProjAI(proj);
        const localAI = new ProjAI(proj, true);
        const player = Terraria.Main.player[proj.owner];
        
        // OnSpawn
        const justSpawned = localAI[0] === 0;
        if (justSpawned) {
            localAI[0] = 1;
            ai[0] = ShootFrequency * 1.5; // Delay the first shot slightly
            ai[1] = 200;
            
            // The sound that Frost Hydra, Spider Turret, and Houndius Shootius play when spawned. Optional.
            PlaySound(Terraria.ID.SoundID.Item46, proj.position, 0, 1);
            
            // Dust indicating the sentry spawned. Optional.
            const NewDustPerfect = Terraria.Dust.NewDustPerfect;
            const NextVector2CircularEdge = Terraria.Utils.NextVector2CircularEdge;
            const rand = Terraria.Main.rand;
            const dustPos = Vector2.Add(proj.Center, Vector2.new(6, 0));
            const dustId = Terraria.ID.DustID.BlueCrystalShard;
            for (let i = 0; i < 50; i++) {
                let speed = NextVector2CircularEdge(rand, 1, 1);
                let dust = NewDustPerfect(dustPos, dustId, Vector2.Multiply(speed, 4), 0, null, 1.5);
                dust.noGravity = true;
            }
        }
        
        // Check if it can shoot and reduce the timer
        let canShoot = false;
        if (ai[0] <= 0) {
            ai[0] = ShootFrequency;
            canShoot = true;
        } else ai[0]--;
        
        // When it reaches 0, shoot the projectile.
        if (canShoot) {
            const target = this.GetTarget(proj, player, ai[1], TargetingRange);
            if (target !== null) {
                // Save Target
                ai[1] = target.whoAmI;
                
                // Attack Sound
                PlaySound(Terraria.ID.SoundID.Item102, proj.Center, 0, 0.4);
                
                // Actually spawning the projectile only runs if the local player is the owner
                if (Terraria.Main.myPlayer === proj.owner) {
                    const shootDirection = Vector2.SafeNormalize(Vector2.Subtract(target.Center, proj.Center), Vector2.UnitX);
                    const shootVelocity = Vector2.Multiply(shootDirection, FireVelocity);
                    const type = ModProjectile.getTypeByName('ExampleSentryShot');
                    NewProjectile(
                        proj.GetProjectileSource_FromThis(),
                        Vector2.new(proj.Center.X - 4, proj.Center.Y),
                        shootVelocity,
                        type, proj.originalDamage, 3, proj.owner,
                        0, 0, 0, null
                    );
                }
            }
        }
        
        this.Visuals(proj);
    }
    
    GetTarget(proj, player, oldTarget, maxRange) {
        let target = null;
        
        // Player Target
        if (player.HasMinionAttackTargetNPC && oldTarget !== player.MinionAttackTargetNPC) {
            target = Terraria.Main.npc[player.MinionAttackTargetNPC];
            if (target.CanBeChasedBy(proj, false) && Vector2.Distance(proj.Center, target.Center) < maxRange * 1.5) {
                return target;
            }
        }
        
        // Old Target
        target = Terraria.Main.npc[oldTarget];
        if (target && target.active && target.CanBeChasedBy(proj, false)) {
            return target;
        }
        
        // New Target
        target = proj.FindTargetWithinRange(maxRange, true);
        if (target && target.active && target.CanBeChasedBy(proj, false)) {
            return target;
        }
        
        return null;
    }
    
    Visuals(proj) {
        proj.gfxOffY = 2;
        proj.rotation = 0;
    }
}