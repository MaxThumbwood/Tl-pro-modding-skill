import { Terraria, Modules } from './../../TL/ModImports.js';
import { ModProjectile } from './../../TL/ModProjectile.js';

const { Color, Rand, Vector2 } = Modules;
const PlaySound = (type, position) => Terraria.Audio.SoundEngine['SoundEffectInstance PlaySound(LegacySoundStyle type, Vector2 position, float pitchOffset, float volumeScale)'](type, position, 0, 1.0);

export class ExampleDrillProjectile extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
    }
    
    SetDefaults() {
        this.Projectile.width = 22;
        this.Projectile.height = 22;
        this.DefaultToDrillOrChainsaw();
        this.Projectile.aiStyle = -1;
    }
    
    AI(proj) {
        const player = Terraria.Main.player[proj.owner];
        proj.timeLeft = 60;
        
        // Animation code could go here if the projectile was animated. 
        
        // Plays a sound every 20 ticks. In aiStyle 20, soundDelay is set to 30 ticks.
        if (proj.soundDelay <= 0) {
            PlaySound(Terraria.ID.SoundID.Item22, proj.Center);
            proj.soundDelay = 20;
        }
        
        let playerCenter = player.RotatedRelativePoint(player.MountedCenter, false, true, 0);
        if (Terraria.Main.myPlayer === proj.owner) {
            // This code must only be ran on the client of the projectile owner
            if (player.channel) {
                let holdoutDistance = player.HeldItem.shootSpeed * proj.scale;
                let holdoutOffset = Vector2.Multiply(Vector2.Normalize(Vector2.Subtract(Terraria.Main.MouseWorld, playerCenter)), holdoutDistance);
                if (holdoutOffset.X != proj.velocity.X || holdoutOffset.Y != proj.velocity.Y) {
                    // This will sync the projectile, most importantly, the velocity.
                    proj.netUpdate = true;
                }
                
                // Projectile.velocity acts as a holdoutOffset for held projectiles.
                proj.velocity = holdoutOffset;
            } else {
                proj.Kill();
            }
        }
        
        if (proj.velocity.X > 0) player.ChangeDir(1);
        else if (proj.velocity.X < 0) player.ChangeDir(-1);
        
        proj.spriteDirection = proj.direction;
        player.ChangeDir(proj.direction); // Change the player's direction based on the projectile's own
        
        // We tell the player that the drill is the held projectile, so it will draw in their hand
        player.heldProj = proj.whoAmI;
        
        player.SetDummyItemTime(2); // Make sure the player's item time does not change while the projectile is out
        proj.Center = playerCenter; // Centers the projectile on the player. Projectile.velocity will be added to this in later Terraria code causing the projectile to be held away from the player at a set distance.
        proj.rotation = Vector2.ToRotation(proj.velocity) + Math.PI / 2;
        player.itemRotation = Vector2.ToRotation(Vector2.Multiply(proj.velocity, proj.direction));
        
        // Gives the drill a slight jiggle
        const v = proj.velocity;
        v.X *= 1 + Rand.Next(-3, 4) * 0.01;
        proj.velocity = v;
        
        // Spawning dust
        if (Rand.NextBool(10)) {
            let dust = Terraria.Dust.NewDustDirect(Vector2.Add(proj.position, Vector2.Multiply(proj.velocity, Rand.Next(6, 10) * 0.15)), proj.width, proj.height, Terraria.ID.DustID.Smoke, 0, 0, 100, Color.White, 1);
            dust.position = Vector2.new(dust.position.X - 4, dust.position.Y);
            dust.noGravity = true;
            dust.velocity = Vector2.new(dust.velocity.X * 0.5, dust.velocity.Y - Rand.Next(3, 8) * 0.1);
        }
    }
}