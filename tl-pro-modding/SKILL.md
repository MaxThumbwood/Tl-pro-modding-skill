---
name: tl-pro-modding
description: Create, edit, or debug mods for TL Pro (a Terraria mobile/console modding framework that uses JavaScript instead of C#). Use this whenever the user wants to build a TL Pro mod, add an item/NPC/projectile/buff/boss/UI to a TL Pro mod, fix a TL Pro runtime error ("Can't cast js value", "not iterable", "Indexed properties are not supported for NativeObject", "SetDefaults failed"), understand the TL Pro API (ModItem, ModNPC, ModProjectile, ModBuff, ModPlayer, GlobalNPC, etc.), or asks about modding Terraria mobile/console. This skill bundles the actual TL Pro framework source, a full real-world mod (Thorium-FM) for pattern reference, and decompiled Terraria C# source (mobile + PC) as ground truth — always consult these via the commands below rather than guessing API names from general Terraria/tModLoader knowledge, since TL Pro's JS API differs from tModLoader's C# API in field names, method signatures, and available hooks.
---

# TL Pro Modding

TL Pro mods are plain JavaScript (ES modules) that get loaded by a native
engine wrapped around the Terraria mobile/console (Il2Cpp) build. There is
no compiler and no type system to catch mistakes — a wrong field name,
wrong cast, or bracket-indexing a native array throws a **runtime error
that reaches the player**, not a build error. The single most important
rule of this skill:

> **Never guess a field, method, class, or ID name. Verify it by grepping
> the bundled reference material first.** Every example below tells you
> exactly which command to run before writing the equivalent code.

TL Pro's JS API is its own framework inspired by tModLoader's C# API, not
a 1:1 port. Method names, signatures and available hooks frequently
differ (see `reference/framework/` for the real, current surface). Do not
answer from memory of tModLoader's C# modding docs.

## What's bundled, and when to open it

```
reference/
  framework/            (Example Mod v1.7.2) TL Pro's actual loader + API classes (this IS the "framework
                         docs" — there is no other documentation). Also doubles as
                         TL Pro's official ExampleMod: every content type has a
                         working example here.
  mods/
    thorium-fm/          A large, real, released mod. Best source for non-trivial
                         patterns: bosses, minions, custom UI, world gen, biomes.
    magic-storage-lite/  A mod built around a custom UI system (ModInterface,
                         ModButton, ModSlider) — the reference for UI/interface work.
    example-interface/   A minimal custom-UI-layer example, simpler than
                         magic-storage-lite, good first read for UI hooks.
  dotnet-source/
    mobile/              Decompiled Terraria mobile/console C# source, one file per
                         class — ground truth for what fields/methods/IDs actually
                         exist and their real C# types.
    pc/                  Decompiled Terraria PC C# source. Use when mobile/pc behavior
                         might differ, or a class/field isn't found under mobile/.
```

Load order for any task:
1. Skim this file (you're doing that now).
2. Grep `reference/framework/` for the TL Pro class/hook you need (§3–§9 tell you where).
3. Grep `reference/mods/` for a real mod already doing something similar — copy the *pattern*, never paste the literal code verbatim into a different mod.
4. Grep `reference/dotnet-source/mobile/` (then `pc/` if not found) to confirm any raw Terraria field/method/ID name and its actual C# type before using it in JS.

## 1. Mod folder structure

```
Settings.json           # mod pack manifest: title, authors, version, description (see §2)
Icon.png                # mod icon shown in the mod browser
Authors/                # author avatar images referenced from Settings.json
Modified/
  1.json                # { "id": "<uuid>" } — the mod's unique slot id (any UUID)
  1.mod/                # the actual mod code — folder name can be numeric or a mod-name
                         # (e.g. "MagicStorageLite.mod"); it must match the Settings.json entry
    main.js              # entry point: RegisterAll() + SystemLoader.OnModLoad()
    Register/*.js        # one file per content type, each exports Register<Type>()
    Content/<Category>/  # the actual item/projectile/buff/NPC/etc. classes
    Textures/<Category>/ # PNGs; path mirrors Content/<Category>/<ClassName>.png
    Localization/<locale>.json   # REQUIRED per locale present — see §6
```

A `Modified/` folder can hold more than one mod slot; `1.json`/`1.mod` is
just the first. See `reference/mods/magic-storage-lite/` for a named
(non-numeric) `.mod` folder example.

## 2. `Settings.json` (mod pack manifest)

```json
{
    "packStructureVersion": 34,
    "title": "My Mod",
    "guid": "<uuid>",
    "descriptionEnglish": "<h3>Info</h3>What the mod does.",
    "authors": [
        { "name": "YourName", "file": "Icon.png", "icon_height": 70, "color": "#37d8ff" }
    ],
    "version": 1
}
```
`guid` and the `Modified/1.json` `id` are both UUIDs but are independent —
generate fresh ones for a new mod, don't reuse an example's.

## 3. Registration — exact order matters

`main.js`:
```js
import { RegisterAll } from './Register/RegisterAll.js';
import { SystemLoader } from './TL/Loaders/SystemLoader.js';

RegisterAll();
SystemLoader.OnModLoad();
```

`Register/RegisterAll.js` calls each `Register<Type>()` in a **fixed
order** (copy this order for new mods — verify against
`reference/framework/Register/RegisterAll.js` if TL Pro has updated it):

```
ModSystem.register(ModLoader)   // the mod's own main system, registered first
RegisterSystems()
RegisterBackgrounds()  // 1
RegisterBiomes()       // 2
RegisterBuffs()        // 3
RegisterNPCs()         // 4
RegisterProjectiles()  // 5
RegisterPrefixes()     // 6
RegisterItems()        // 7
RegisterClouds()       // 8
RegisterMenus()        // 9
RegisterSubworlds()    // 10
RegisterHairs()        // 11
RegisterMounts()       // 12
RegisterAchievements() // 13
RegisterCommands()     // 14
RegisterEmotes()       // 15
RegisterGlobal()       // last
```
This ordering is why `getTypeByName('SomeBuff')` called from an Item's
`SetDefaults` works — Buffs register before Items. If you add a new
cross-type reference, check that the referenced type's `Register*()` call
comes earlier in this list.

Each `Register<Type>.js` just imports every content class and calls the
type's `.register()`:
```js
import { ModItem } from './../TL/ModItem.js';
import { MyThing } from './../Content/Items/MyThing.js';

export function RegisterItems() {
    ModItem.register(MyThing);
}
```

## 4. Content classes: the base pattern

```js
import { Terraria } from '../../TL/ModImports.js';
import { ModItem } from '../../TL/ModItem.js';   // or ModProjectile, ModBuff, ModNPC, GlobalNPC...

export class MyThing extends ModItem {
    constructor() {
        super();
        this.Texture = 'Items/' + this.constructor.name; // must match Textures/ path
    }
    SetDefaults() {
        this.Item.damage = 10; // `this.Item` / `this.Projectile` / `this.NPC` is pre-bound — don't take it as a parameter
    }
}
```
- The loader calls a mod-defined content class's `SetDefaults()` with **no argument** — use `this.Item`/`this.Projectile`/`this.NPC` (pre-bound by the base class), not a parameter. The `Global*` variants (`GlobalItem`, `GlobalNPC`, ...) are different: their `SetDefaults(item)` **does** receive the entity as a parameter, since one `GlobalX` instance hooks every item/NPC/etc. of that type rather than owning one. Check `TL/Loaders/<Type>Loader.js` for the exact call site if unsure which applies.
- `Texture` is derived from the class name by convention — rename the class and the PNG together, or set `Texture` explicitly.
- Cross-references between content types use `getTypeByName('ClassName')` (a string, not an import) — e.g. `ModProjectile.getTypeByName('MyProjectile')` inside an item's `SetDefaults`. Only resolves if the referenced type's `Register*()` ran earlier (§3).
- Before inventing a new content class, **grep `reference/framework/Content/` and `reference/mods/thorium-fm/Content/` for something similar first.** Every content type (weapon styles, minions, sentries, whips, bosses, mounts, hairs, biomes, custom-currency items, quest fish, etc.) already has a working example in one of these two trees.

Each TL Pro base class (`reference/framework/TL/Mod*.js`) documents its
own full hook surface better than any prose summary could — **open the
specific base class file for the content type you're adding** before
writing hooks you assume exist. As of this writing the base classes are:
`ModItem`, `ModProjectile`, `ModNPC`, `ModBuff`, `ModPlayer`, `ModSystem`,
`ModRecipe`, `ModBiome`, `ModBackgrounds`, `ModCloud`, `ModMount`,
`ModHair`, `ModAchievement`, `ModCommand`, `ModPrefix`, `ModEmoteBubble`,
`ModMenu`, `ModGore`, `Subworld`, plus the `Global*` variants
(`GlobalItem`, `GlobalNPC`, `GlobalProjectile`, `GlobalTile`) for
hooking *all* instances of vanilla + modded content of a type rather than
defining one new piece of content.

## 5. Native arrays need wrapper classes, not bracket indexing

`Terraria.Main.projectile`, `Terraria.Main.npc`, `Terraria.Main.player`
are fixed-size C# arrays exposed through reflection — **not** JS-iterable:
```js
// WRONG — throws "X is not iterable"
for (const p of Terraria.Main.projectile) { ... }

// RIGHT
for (let i = 0; i < Terraria.Main.maxProjectiles; i++) {
    const p = Terraria.Main.projectile[i];
    if (!p) continue;
    // ...
}
```
`npc.ai` / `proj.ai` (the `float[4]` AI slots) go further — even indexed
bracket access throws `Indexed properties are not supported for
NativeObject`. Use the framework's wrapper class:
```js
import { ProjAI } from '../../TL/ProjAI.js';
const ai = new ProjAI(proj, false); // false = proj.ai, true = proj.localAI
ai[0] = ai[0] + 1;
```
`grep -rn "new ProjAI(" reference/mods/thorium-fm/` for real usage (160+
call sites) before assuming a constructor signature or array size.
There is no equivalent NPC AI wrapper bundled here as of this writing —
`grep -rn "class.*NPCAI\|NPC.*ai\[" reference/framework/TL/` to check
whether one has been added before assuming `npc.ai` needs the same
treatment as `proj.ai`.

## 6. Localization is not optional

An unregistered item shows literally as `ItemName.YourClassName` in-game
with no tooltip. Every locale file **present in the mod** needs every
relevant key — missing keys don't fall back to English per-key, only a
whole missing locale *file* falls back:
```json
{
  "ItemName": { "MyThing": "Display Name" },
  "ItemTooltip": { "MyThing": "Line one\nLine two" },
  "BuffName": { "MyBuff": "Buff Display Name" },
  "BuffDescription": { "MyBuff": "What it does" },
  "ProjectileName": { "MyProjectile": "..." },
  "NPCName": { "MyNPC": "..." }
}
```
Key = class name, exactly. `\n` for multi-line tooltips. See
`reference/framework/Localization/en-US.json` for the full key set
(it also covers `ChatCommand`, `Prefix`, `EmojiName`, `CustomCurrency`,
`AnglerQuest`, `ArmorSetBonus`, `Bestiary`, `TownNPCMood`, `Achievements`).

## 7. Movement/AI-affecting effects (freeze, stun, knockback-immunity, etc.)

Order of operations each tick, and why it matters:
1. `GlobalNPC.PreAI(npc)` runs **before** `NPC.AI()`. Returning `false`
   **skips AI entirely** — the only way to stop an NPC from
   attacking/shooting, not just moving.
2. `NPC.AI()` runs (if not skipped) — vanilla movement/attack logic.
3. Position integration happens.
4. `GlobalNPC.PostAI(npc)` runs after — useful as a safety-net revert
   (`npc.position = npc.oldPosition`), but **too late** to stop an attack
   that already fired.
5. `ModBuff.UpdateNPC()` runs from a separate buff-bookkeeping pass —
   **not guaranteed** to run before position integration. Use it only for
   simple continuous effects (DOT), not a hard freeze.

For a true "can't move or act" effect: implement `GlobalNPC.PreAI`
returning `false` + zeroing velocity, not a buff's `UpdateNPC`.
Reference: `reference/mods/thorium-fm/Content/Global/NPCs/UpdateNPCBuff.js`.

## 8. Full-screen draw effects (tints/filters) — check the hook is active first

The framework only installs some native hooks conditionally — see
`reference/framework/TL/Hooks/Main.js`, the `HookList` object, e.g.:
```js
DrawInterface_29_SettingsButton: (info) => info.is64Bits,
```
`Camera.Fade()` (`reference/framework/TL/Modules/Camera.js`) depends on
`FadeController.Update()`, wired up only through that conditionally
installed hook — on a build where the condition is false, `Camera.Fade()`
silently no-ops with **no error**. Before relying on any engine-level
visual effect, grep the relevant `TL/Hooks/*.js` file's `HookList` for
the gating condition and confirm it isn't restricted to a build/platform
you can't guarantee.

## 9. Verifying anything before using it

Before writing `Terraria.X.Y` or `npc.someField`, confirm it's real and
check its declared C# type (fields typed as a real array, e.g. `float[]
ai`, or a struct, e.g. `LegacySoundStyle`/`Color`, **cannot** be assigned
a raw JS number/object — see the error table in §10):
```bash
grep -rn "someField" reference/dotnet-source/mobile/
grep -rln "class SomeID" reference/dotnet-source/mobile/
# if not found, or to check PC-specific behavior:
grep -rn "someField" reference/dotnet-source/pc/
```
Before inventing a technique, grep the bundled mods for one that already
does something similar:
```bash
grep -rln "UpdateNPC\|PreAI\|Camera.Fade" reference/mods/thorium-fm/Content/
```
Copy the *pattern*, not literal code — these are examples of correct API
usage, not something to paste verbatim into an unrelated mod.

## 10. Common runtime errors and their real cause

| Error | Cause | Fix |
|---|---|---|
| `X is not iterable` | `for...of` on a native array | indexed loop, §5 |
| `Indexed properties are not supported for NativeObject` | bracket-indexing `ai[]` directly | use `ProjAI`/equivalent wrapper, §5 |
| `Can't cast js value "N" to C# LegacySoundStyle` | assigned a raw int (e.g. `SoundID.MenuTick`, which IS an int) to `Item.UseSound` | only assign fields whose dump type is `LegacySoundStyle`, not `int` — check the dump |
| `SetDefaults failed for item <X>` | any thrown error inside `SetDefaults` | read the wrapped `error:` message, it names the real field |
| `ItemName.YourClassName` shown in-game | missing localization entry | §6 |
| Visual effect does nothing, no error | hook gated off for this build (§8) | check `HookList` condition |

Before assigning any `SoundID`-like constant, check its declared type:
```bash
awk '/class SoundID /,/^}/' reference/dotnet-source/mobile/Assembly-CSharp/Terraria/ID/SoundID.cs | grep MyConst
# public const int MenuTick = 12;              <- int, NOT assignable to a LegacySoundStyle field
# public static LegacySoundStyle Item29;        <- OK
```
Mobile source nests as `dotnet-source/mobile/Assembly-CSharp/<Namespace>/<Class>.cs`;
PC source nests as `dotnet-source/pc/<Namespace>/<Class>.cs` (no `Assembly-CSharp`
prefix). When unsure, skip guessing the path and run
`find reference/dotnet-source -iname "<ClassName>.cs"` first.

## 11. Verified-real API surface (spot-checked — expand as needed, don't treat as exhaustive)

- `npc.velocity`, `npc.position`, `npc.oldPosition` (Vector2) — `Entity` base class
- `npc.ai` / `proj.ai` (`float[4]`) — index only via wrapper, §5
- `npc.boss`, `npc.friendly`, `npc.dontTakeDamage`, `npc.immortal` (bool)
- `npc.FindBuffIndex(int type)`, `npc.AddBuff(type, time, quiet)`
- `player.channel` — only meaningful for channeled-style weapons, not `useStyle: Shoot`
- `player.whoAmI`, `player.active`, `player.Center`, `player.MountedCenter`, `player.direction`, `player.gravDir`
- `Main.maxNPCs`, `Main.maxProjectiles`, `Main.myPlayer`
- `Main.debuff[]`, `Main.pvpBuff[]`, `Main.buffNoSave[]`, `Main.buffNoTimeDisplay[]` (bool arrays, indexed by buff type)
- `Terraria.ID.ItemID.*`, `Terraria.ID.TileID.*`, `Terraria.ID.SoundID.*` (mixed `int` and `LegacySoundStyle` — check each)
- `Terraria.Projectile['int NewProjectile(IEntitySource, Vector2, Vector2, int, int, float, int, float, float, float, NewProjectileModifier)']` — reflection-string call signature for spawning projectiles; see `reference/framework/Content/Items/Weapons/Melee/ExampleSwingingEnergySword.js` for a full real call site including argument order
- Reflection-string calls in general (`obj['ReturnType MethodName(ArgType, ...)'](...)`) are how TL Pro calls C# overloads that can't be resolved by name alone — grep `reference/mods/thorium-fm/` for more examples of this pattern before guessing a signature string

## 11a. Signature changes in TL Pro 1.7.2 (Terraria 1.4.5.8.1)

`reference/framework/` is the Example Mod **v1.7.2** and uses the signatures
below. The bundled mods under `reference/mods/` (Thorium-FM, example-interface,
magic-storage-lite) were written against the older API and still use the old
forms. Copy their *patterns*, but write new calls with the v1.7.2 signatures:

| Call | Old | New (v1.7.2) |
|---|---|---|
| `Main.NewText` (byte R,G,B overload) | `'void NewText(string newText, byte R, byte G, byte B)'` | `'void NewText(string newText, byte R, byte G, byte B, bool onlyCurrentPlayer)'`, pass `false` to keep the old behaviour |
| `Item.NewItem` | last param `bool noGrabDelay` | last param `NewItemOwnership ownership`, pass `null` |
| `player.RotatedRelativePoint` | `(pos, reverseRotation, addGfxOffY)` | extra 4th arg, pass `0` |
| `Projectile.FillWhipControlPoints` | `(proj, list, player, bool)` | extra 5th arg, pass `0` |
| `npc.StrikeNPC` | 7 args, two bool flags between `crit` and `owner` | 6 args: `(damage, knockback, direction, crit, false, owner)` |
| `item.TurnToAir` | `TurnToAir(true)` | `TurnToAir()` |
| `ItemSlot.CanEquipBothAccessories` | `(acc1, acc2)` | `(acc1, acc2, bool vanity)` |
| `Player.ApplyNPCOnHitEffects` | `int npcIndex` param | `NPC npc` param |
| `Main.UpdateTime_SpawnTownNPCs` | `(bool forceUpdate)` | no params |
| `NPCHappiness.AddHappinessReportText` | `(key)` | `(self, key)` |
| `ItemSacrifices._sacrificeCountByItemPersistentId` | `.Add(...)` | `.TryAdd(...)` |
| `Item.GetAlpha` hook target | `Terraria.WorldItem` | `Terraria.Item` |

Other 1.7.2 notes:
- `UpdateLifeRegen` on `ModNPC` / `GlobalNPC` is marked `@deprecated`, and its `UpdateNPC_BuffApplyDOTs` hook is commented out in `TL/Hooks/NPC.js`, so don't rely on it.
- `ExampleSoul` no longer uses the `Lighting.AddLight` / `Vector3.Multiply` glow code (commented out).
- `Textures/` now ships inside the framework folder with the Example Mod's textures.
- `ProcessMood` (town NPC shop pricing) now defers to the original for non-mod NPC types above the vanilla ID range.
- When unsure, re-verify the exact signature in `reference/dotnet-source/` (§9) since the dump is the ground truth.

## 12. Custom UI / interfaces

TL Pro has its own interface-layer system (`ModInterface`,
`ModInterfaceLayer`, `ModButton`, `ModSlider`, `VanillaInterfaceLayers`,
`ModHooks`) layered on top of Terraria's vanilla UI draw-layer list rather
than replacing it. Don't invent a UI approach — read, in this order:
1. `reference/mods/example-interface/` — smallest working custom interface layer.
2. `reference/mods/magic-storage-lite/InterfaceSystem/` — a complete UI system (buttons, sliders, crafting panel) built on the same primitives, for anything beyond a minimal layer.

## 13. Workflow checklist for any new feature

1. Grep `reference/dotnet-source/` for every field/method/ID you're about to use. No exceptions.
2. Grep `reference/framework/` and `reference/mods/` for an existing example doing something similar; match its pattern.
3. Write the class, following §4.
4. Register it (§3) and add localization (§6).
5. Mentally re-trace each new line against §5/§8/§9/§10 before calling it done.
6. If a runtime error comes back, read the *message*, not just the stack trace shape — it usually names the exact bad field/cast (§10 table).

## Credits

The bundled reference material originates from the TL Pro community:
TL Pro's ExampleMod (credits TModLoader; authors GST378 and Animatak_,
laser-beam code base by Cainam, 1.4.5 decompile by Potato, NPC dialogue
source by Alissa, OreRunner code by Zayah), Thorium-FM, and Magic Storage
Lite. There is no official connection between this skill and the
TModLoader or TL Pro teams.
