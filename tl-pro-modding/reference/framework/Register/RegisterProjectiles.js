import { ModProjectile } from './../TL/ModProjectile.js';

import { ExampleBulletProjectile } from './../Content/Projectiles/ExampleBulletProjectile.js';
import { ExampleDrillProjectile } from './../Content/Projectiles/ExampleDrillProjectile.js';
import { ExampleYoyoProjectile } from './../Content/Projectiles/ExampleYoyoProjectile.js';
import { ExampleBobber } from './../Content/Projectiles/ExampleBobber.js';
import { ExamplePetProjectile } from './../Content/Pets/ExamplePet/ExamplePetProjectile.js';
import { ExampleLightPetProjectile } from './../Content/Pets/ExampleLightPet/ExampleLightPetProjectile.js';
import { ExampleAdvancedAnimatedProjectile } from './../Content/Projectiles/ExampleAdvancedAnimatedProjectile.js';
import { ExampleWhipProjectile } from './../Content/Projectiles/ExampleWhipProjectile.js';
import { ExampleMinion } from './../Content/Projectiles/ExampleMinion.js';
import { ExampleSentry } from './../Content/Projectiles/ExampleSentry.js';
import { ExampleSentryShot } from './../Content/Projectiles/ExampleSentryShot.js';
import { ExampleSwingingEnergySwordProjectile } from './../Content/Projectiles/ExampleSwingingEnergySwordProjectile.js';
import { ExampleSpearProjectile } from './../Content/Projectiles/ExampleSpearProjectile.js';
import { ExampleLaserHoldout } from './../Content/Projectiles/ExampleLaserHoldout.js';
import { ExampleLaserBeam } from './../Content/Projectiles/ExampleLaserBeam.js';
import { ExampleFlailProjectile } from './../Content/Projectiles/ExampleFlailProjectile.js';
import { ExampleGolfBallProjectile } from './../Content/Projectiles/ExampleGolfBallProjectile.js';
import { ExampleHookProjectile } from './../Content/Projectiles/ExampleHookProjectile.js';

export function RegisterProjectiles() {
    ModProjectile.register(ExampleBulletProjectile);
    ModProjectile.register(ExampleDrillProjectile);
    ModProjectile.register(ExampleYoyoProjectile);
    ModProjectile.register(ExampleBobber);
    ModProjectile.register(ExamplePetProjectile);
    ModProjectile.register(ExampleLightPetProjectile);
    ModProjectile.register(ExampleAdvancedAnimatedProjectile);
    ModProjectile.register(ExampleWhipProjectile);
    ModProjectile.register(ExampleMinion);
    ModProjectile.register(ExampleSentry);
    ModProjectile.register(ExampleSentryShot);
    ModProjectile.register(ExampleSwingingEnergySwordProjectile);
    ModProjectile.register(ExampleSpearProjectile);
    ModProjectile.register(ExampleLaserHoldout);
    ModProjectile.register(ExampleLaserBeam);
    ModProjectile.register(ExampleFlailProjectile);
    ModProjectile.register(ExampleGolfBallProjectile);
    ModProjectile.register(ExampleHookProjectile);
}