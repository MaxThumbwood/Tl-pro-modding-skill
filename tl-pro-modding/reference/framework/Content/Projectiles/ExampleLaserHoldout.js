import { Terraria, Modules } from '../../TL/ModImports.js';
import { ModProjectile } from '../../TL/ModProjectile.js';
import { ProjAI } from '../../TL/ProjAI.js';

const { Color, MathHelper, Vector2 } = Modules;
const NewProjectile = Terraria.Projectile['int NewProjectile(IEntitySource spawnSource, Vector2 position, Vector2 velocity, int Type, int Damage, float KnockBack, int Owner, float ai0, float ai1, float ai2, NewProjectileModifier modifer)'];

export class ExampleLaserHoldout extends ModProjectile {
    constructor() {
        super();
        this.Texture = 'Projectiles/' + this.constructor.name;
        this.HoldoutDistance = 30;
        this.ManaConsumptionRate = 5;
    }
    
    SetStaticDefaults() {
        Terraria.Main.projFrames[this.Type] = 5;
    }
    
    SetDefaults() {
        this.Projectile.width = 22;
        this.Projectile.height = 20;
        this.Projectile.alpha = 100;
        this.Projectile.friendly = true;
        this.Projectile.hostile = false;
        this.Projectile.penetrate = -1;
        this.Projectile.tileCollide = false;
    }
    
    PostSetupContent() {
        this.LaserType = ModProjectile.getTypeByName('ExampleLaserBeam');
    }
    
    GetAlpha(proj, color) {
        return Color.White;
    }
    
    AI(proj) {
        const ai = new ProjAI(proj);
        const player = Terraria.Main.player[proj.owner];
        let rrp = player.RotatedRelativePoint(player.MountedCenter, true, true, 0);
        
        ai[0] += 1;
        
        this.UpdateAnimation(proj);
        this.UpdatePlayerVisuals(proj, player, rrp);
        
        if (proj.owner === Terraria.Main.myPlayer) {
            this.UpdateAim(proj, rrp, player.HeldItem.shootSpeed);
            
            let manaIsAvailable = !this.ShouldConsumeMana(proj, ai) || player.CheckMana(player.HeldItem.mana, true, false);
            let stillInUse = player.channel && manaIsAvailable && !player.noItems && !player.CCed;
            
            if (stillInUse && ai[0] === 1) {
                this.ShootBeam(proj, player);
            } else if (!stillInUse) {
                proj.Kill();
            }
        }
        
        proj.timeLeft = 2;
    }
    
    UpdateAnimation(proj) {
        proj.frameCounter++;
        if (proj.frameCounter >= 3) {
            proj.frameCounter = 0;
            proj.frame++;
            if (proj.frame >= Terraria.Main.projFrames[this.Type]) {
                proj.frame = 0;
            }
        }
    }
    
    UpdatePlayerVisuals(proj, player, handPos) {
        proj.rotation = Vector2.ToRotation(proj.velocity) + MathHelper.PiOver2;
        proj.spriteDirection = proj.direction;
        proj.Center = Vector2.Add(player.MountedCenter, Vector2.Multiply(Vector2.Normalize(proj.velocity), this.HoldoutDistance));
        
        player.ChangeDir(proj.direction);
        player.heldProj = proj.whoAmI;
        proj.drawLayer = Terraria.ID.ProjectileDrawLayerID.HeldProj;
        player.itemTime = 2;
        player.itemAnimation = 2;
        
        player.itemRotation = Vector2.ToRotation(Vector2.Add(proj.velocity, proj.direction));
    }
    
    UpdateAim(proj, source, speed) {
        let aim = Vector2.Normalize(Vector2.Subtract(Terraria.Main.MouseWorld, source));
        if (Terraria.Utils.HasNaNs(aim)) {
            aim = Vector2.UnitY;
            aim.Y *= -1;
        }
        
        aim = Vector2.Normalize(Vector2.Lerp(Vector2.Normalize(proj.velocity), aim, 0.08));
        aim = Vector2.Multiply(aim, speed);
        
        if (aim.X !== proj.velocity.X && aim.Y !== proj.velocity.Y) {
            proj.netUpdate = true;
        }
        proj.velocity = aim;
    }
    
    ShouldConsumeMana(proj, ai) {
        let consume = ai[1] === 0;
        ai[1]++;
        if (ai[1] > this.ManaConsumptionRate) {
            ai[1] = 0;
        }
        return consume;
    }
    
    ShootBeam(proj, player) {
        const dir = Vector2.Normalize(proj.velocity);
        const tip = Vector2.Add(proj.Center, Vector2.Multiply(dir, this.HoldoutDistance));
        const idx = NewProjectile(
            player.GetProjectileSource_Item(player.HeldItem),
            tip, dir, this.LaserType,
            player.HeldItem.damage, proj.knockBack, proj.owner,
            proj.whoAmI, 0, 0, null
        );
        Terraria.Main.projectile[idx].scale = 0.05;
    }
}