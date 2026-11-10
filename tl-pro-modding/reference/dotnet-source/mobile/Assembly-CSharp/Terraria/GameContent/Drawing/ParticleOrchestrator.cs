using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	public class ParticleOrchestrator
	{
		// Token: 0x06005F6B RID: 24427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0x9F5EE0", Offset = "0x9F5EE0", VA = "0x9F5EE0")]
		public static void RequestParticleSpawn(bool clientOnly, ParticleOrchestraType type, ParticleOrchestraSettings settings, [Optional] int? overrideInvokingPlayerIndex)
		{
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0x9F799C", Offset = "0x9F799C", VA = "0x9F799C")]
		public static void BroadcastParticleSpawn(ParticleOrchestraType type, [Optional] ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0x9F7B30", Offset = "0x9F7B30", VA = "0x9F7B30")]
		public static void BroadcastOrRequestParticleSpawn(ParticleOrchestraType type, [Optional] ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0x9F7CF8", Offset = "0x9F7CF8", VA = "0x9F7CF8")]
		private static IPooledParticle GetNewFadingParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x9F7D6C", Offset = "0x9F7D6C", VA = "0x9F7D6C")]
		private static FadingPlayerShaderParticle GetNewFadingPlayerShaderParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x9F7DE0", Offset = "0x9F7DE0", VA = "0x9F7DE0")]
		private static LittleFlyingCritterParticle GetNewPooFlyParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x9F7E54", Offset = "0x9F7E54", VA = "0x9F7E54")]
		private static LittleFlyingCritterParticle GetNewNatureFlyParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x9F7EC8", Offset = "0x9F7EC8", VA = "0x9F7EC8")]
		private static ItemTransferParticle GetNewItemTransferParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0x9F7F3C", Offset = "0x9F7F3C", VA = "0x9F7F3C")]
		private static FlameParticle GetNewFlameParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0x9F7FB0", Offset = "0x9F7FB0", VA = "0x9F7FB0")]
		private static FakeFishParticle GetNewFakeFishParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x9F8024", Offset = "0x9F8024", VA = "0x9F8024")]
		private static RandomizedFrameParticle GetNewRandomizedFrameParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0x9F8098", Offset = "0x9F8098", VA = "0x9F8098")]
		private static PrettySparkleParticle GetNewPrettySparkleParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0x9F810C", Offset = "0x9F810C", VA = "0x9F810C")]
		private static GasParticle GetNewGasParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0x9F8180", Offset = "0x9F8180", VA = "0x9F8180")]
		private static BloodyExplosionParticle GetNewBloodyExplosionParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x9F81F4", Offset = "0x9F81F4", VA = "0x9F81F4")]
		private static ShockIconParticle GetNewShockIconParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x9F8268", Offset = "0x9F8268", VA = "0x9F8268")]
		private static ItemTransferParticle GetNewItemTransferParticle_ScreenSpace(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0x9F82DC", Offset = "0x9F82DC", VA = "0x9F82DC")]
		private static StormLightningParticle GetNewStormLightningParticle(ParticlePool pool)
		{
			return null;
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0x9F60E8", Offset = "0x9F60E8", VA = "0x9F60E8")]
		public static void SpawnParticlesDirect(ParticleOrchestraType type, ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0xA21CF8", Offset = "0xA21CF8", VA = "0xA21CF8")]
		private static void Spawn_ArmletOfRuinRecharge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0xA21980", Offset = "0xA21980", VA = "0xA21980")]
		private static void Spawn_PyroclasticStoneRecharge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0xA215C8", Offset = "0xA215C8", VA = "0xA215C8")]
		private static void Spawn_SnappingStoneRecharge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0xA1E750", Offset = "0xA1E750", VA = "0xA1E750")]
		private static void Spawn_HarpyCharm(ParticleOrchestraSettings settings, int itemID = 6166)
		{
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0xA1DFE0", Offset = "0xA1DFE0", VA = "0xA1DFE0")]
		private static void Spawn_SnappingStone(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0xA1F6A4", Offset = "0xA1F6A4", VA = "0xA1F6A4")]
		private static void Spawn_SnappingStoneMelee(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0xA206D8", Offset = "0xA206D8", VA = "0xA206D8")]
		private static void Spawn_SnappingStoneSummon(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0xA1D0A0", Offset = "0xA1D0A0", VA = "0xA1D0A0")]
		private static void Spawn_PaladinsHammerShockwave(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0xA1CBA8", Offset = "0xA1CBA8", VA = "0xA1CBA8")]
		private static void Spawn_InScreenDungeonSpawn(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0xA1C84C", Offset = "0xA1C84C", VA = "0xA1C84C")]
		private static void Spawn_HeroicisSetSpawnSound(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0xA1BB6C", Offset = "0xA1BB6C", VA = "0xA1BB6C")]
		private static void Spawn_PaladinsShieldHit(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0xA1B128", Offset = "0xA1B128", VA = "0xA1B128")]
		private static void Spawn_StormLightningWindup(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0xA181B4", Offset = "0xA181B4", VA = "0xA181B4")]
		private static void Spawn_StormLightning(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0xA220E4", Offset = "0xA220E4", VA = "0xA220E4")]
		public static void SpawnLightningExplosionDust(Vector2 position, Color customColor)
		{
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0xA1A044", Offset = "0xA1A044", VA = "0xA1A044")]
		private static void Spawn_ArcLightning(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0xA17A48", Offset = "0xA17A48", VA = "0xA17A48")]
		private static void Spawn_NatureFly(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0xA17450", Offset = "0xA17450", VA = "0xA17450")]
		private static void Spawn_LakeSparkle(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0xA171F0", Offset = "0xA171F0", VA = "0xA171F0")]
		private static void Spawn_FakeFish(ParticleOrchestraSettings settings, bool jumping = false)
		{
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0xA23254", Offset = "0xA23254", VA = "0xA23254")]
		public static void MagnetFakeFish(Projectile proj, int searchedItemType)
		{
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0xA23AB0", Offset = "0xA23AB0", VA = "0xA23AB0")]
		public static void PingFakeFish(Projectile proj, int searchedItemType)
		{
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0xA23F5C", Offset = "0xA23F5C", VA = "0xA23F5C")]
		public static void PushAwayFakeFish(Projectile proj, int searchedItemType)
		{
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0xA24408", Offset = "0xA24408", VA = "0xA24408")]
		public static void RepelAt(Vector2 position, float radius, bool wet)
		{
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0xA167A8", Offset = "0xA167A8", VA = "0xA167A8")]
		private static void Spawn_RainbowBoulder4(ParticleOrchestraSettings settings, bool pet = false)
		{
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0xA14560", Offset = "0xA14560", VA = "0xA14560")]
		private static void Spawn_RainbowBoulder1(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0xA15148", Offset = "0xA15148", VA = "0xA15148")]
		private static void Spawn_RainbowBoulder2(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0xA15654", Offset = "0xA15654", VA = "0xA15654")]
		private static void Spawn_RainbowBoulder3(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0xA13260", Offset = "0xA13260", VA = "0xA13260")]
		private static void Spawn_MoonLordWhip(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0xA11AE0", Offset = "0xA11AE0", VA = "0xA11AE0")]
		private static void Spawn_DeadCellsBarrelExplosion(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0xA10518", Offset = "0xA10518", VA = "0xA10518")]
		private static void Spawn_DeadCellsFlint(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0xA13EF8", Offset = "0xA13EF8", VA = "0xA13EF8")]
		private static void Spawn_MoonLordWhipEye(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0xA0FC9C", Offset = "0xA0FC9C", VA = "0xA0FC9C")]
		private static void Spawn_DeadCellsHeadEffect(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0xA0FB34", Offset = "0xA0FB34", VA = "0xA0FB34")]
		private static void Spawn_UFOLaser(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0xA17D78", Offset = "0xA17D78", VA = "0xA17D78")]
		private static void Spawn_MagnetSphereBolt(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0xA17EE0", Offset = "0xA17EE0", VA = "0xA17EE0")]
		private static void Spawn_HeatRay(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0xA18048", Offset = "0xA18048", VA = "0xA18048")]
		private static void Spawn_Shadowbeam(ParticleOrchestraSettings settings, bool hostile = true)
		{
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0xA246B0", Offset = "0xA246B0", VA = "0xA246B0")]
		private static void SpawnHelper_SpawnInLine(ParticleOrchestraSettings settings, [Optional] Action<Vector2, Vector2> effectsPerStep)
		{
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0xA2493C", Offset = "0xA2493C", VA = "0xA2493C")]
		private static void SpawnHelper_SpawnSingleLineDust(int dustId, Vector2 dustPos, [Optional] Color color)
		{
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0xA0ED54", Offset = "0xA0ED54", VA = "0xA0ED54")]
		private static void Spawn_ShadowOrbExplosion(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0xA0C3F4", Offset = "0xA0C3F4", VA = "0xA0C3F4")]
		private static void Spawn_DeadCellsDownDashExplosion(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0xA0A768", Offset = "0xA0A768", VA = "0xA0A768")]
		private static void Spawn_ShimmerTownNPCSend(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0xA09D80", Offset = "0xA09D80", VA = "0xA09D80")]
		private static void Spawn_ShimmerTownNPC(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xA09B4C", Offset = "0xA09B4C", VA = "0xA09B4C")]
		private static void Spawn_PooFly(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0xA09364", Offset = "0xA09364", VA = "0xA09364")]
		private static void Spawn_Digestion(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0xA08F98", Offset = "0xA08F98", VA = "0xA08F98")]
		private static void Spawn_ShimmerBlock(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0xA088C0", Offset = "0xA088C0", VA = "0xA088C0")]
		private static void Spawn_LoadOutChange(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0xA08798", Offset = "0xA08798", VA = "0xA08798")]
		private static void Spawn_TownSlimeTransform(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0xA0ADE8", Offset = "0xA0ADE8", VA = "0xA0ADE8")]
		private static void Spawn_DeadCellsMushroomBoiExplosion(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0xA12FB8", Offset = "0xA12FB8", VA = "0xA12FB8")]
		private static void Spawn_DeadCellsMushroomBoiTargetFound(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0xA0DB20", Offset = "0xA0DB20", VA = "0xA0DB20")]
		private static void Spawn_DeadCellsBarnacleShotFiring(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0xA251CC", Offset = "0xA251CC", VA = "0xA251CC")]
		private static void ElderSlimeEffect(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0xA24B44", Offset = "0xA24B44", VA = "0xA24B44")]
		private static void NerdySlimeEffect(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0xA24E00", Offset = "0xA24E00", VA = "0xA24E00")]
		private static void CopperSlimeEffect(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0xA07B40", Offset = "0xA07B40", VA = "0xA07B40")]
		private static void Spawn_ShimmerArrow(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xA07584", Offset = "0xA07584", VA = "0xA07584")]
		private static void Spawn_ItemTransfer(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xA06278", Offset = "0xA06278", VA = "0xA06278")]
		private static void Spawn_PetExchange(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0xA034FC", Offset = "0xA034FC", VA = "0xA034FC")]
		private static void Spawn_TerraBlade(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0xA04450", Offset = "0xA04450", VA = "0xA04450")]
		private static void Spawn_Excalibur(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0xA0660C", Offset = "0xA0660C", VA = "0xA0660C")]
		private static void Spawn_SlapHand(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0xA066A0", Offset = "0xA066A0", VA = "0xA066A0")]
		private static void Spawn_WaffleIron(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0xA14498", Offset = "0xA14498", VA = "0xA14498")]
		private static void Spawn_PlayerVoiceOverrideSound(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0xA067C8", Offset = "0xA067C8", VA = "0xA067C8")]
		private static void Spawn_ClassyCane(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0xA06734", Offset = "0xA06734", VA = "0xA06734")]
		private static void Spawn_FlyMeal(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0xA06C30", Offset = "0xA06C30", VA = "0xA06C30")]
		private static void Spawn_VampireOnFire(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0xA06CC4", Offset = "0xA06CC4", VA = "0xA06CC4")]
		private static void Spawn_GasTrap(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0xA04EC0", Offset = "0xA04EC0", VA = "0xA04EC0")]
		private static void Spawn_TrueExcalibur(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0xA0315C", Offset = "0xA0315C", VA = "0xA0315C")]
		private static void Spawn_BestReforge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0xA0287C", Offset = "0xA0287C", VA = "0xA0287C")]
		private static void Spawn_LeafCrystalPassive(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0xA02D10", Offset = "0xA02D10", VA = "0xA02D10")]
		private static void Spawn_LeafCrystalShot(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0xA01D20", Offset = "0xA01D20", VA = "0xA01D20")]
		private static void Spawn_TrueNightsEdge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0xA00F60", Offset = "0xA00F60", VA = "0xA00F60")]
		private static void Spawn_NightsEdge(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0xA01978", Offset = "0xA01978", VA = "0xA01978")]
		private static void Spawn_SilverBulletSparkle(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0xA002E8", Offset = "0xA002E8", VA = "0xA002E8")]
		private static void Spawn_PaladinsHammer(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x9FF474", Offset = "0x9FF474", VA = "0x9FF474")]
		private static void Spawn_PrincessWeapon(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x9FE78C", Offset = "0x9FE78C", VA = "0x9FE78C")]
		private static void Spawn_StardustPunch(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x9FD114", Offset = "0x9FD114", VA = "0x9FD114")]
		private static void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x9FDE40", Offset = "0x9FDE40", VA = "0x9FDE40")]
		private static void Spawn_BlackLightningSmall(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x9FC85C", Offset = "0x9FC85C", VA = "0x9FC85C")]
		private static void Spawn_BlackLightningHit(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0xA1C910", Offset = "0xA1C910", VA = "0xA1C910")]
		private static void Spawn_BlueLightningSmallLong(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0xA0E334", Offset = "0xA0E334", VA = "0xA0E334")]
		private static void Spawn_LightningSmall(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x9FA00C", Offset = "0x9FA00C", VA = "0x9FA00C")]
		private static void Spawn_StellarTune(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x9FACE8", Offset = "0x9FACE8", VA = "0x9FACE8")]
		private static void Spawn_FormatC(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x9FA654", Offset = "0x9FA654", VA = "0x9FA654")]
		private static void Spawn_CattivaHit(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x9F8350", Offset = "0x9F8350", VA = "0x9F8350")]
		private static void Spawn_Chlorophyte(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x9F8760", Offset = "0x9F8760", VA = "0x9F8760")]
		private static void Spawn_Keybrand(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x9F9824", Offset = "0x9F9824", VA = "0x9F9824")]
		private static void Spawn_FlameWaders(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x9FC074", Offset = "0x9FC074", VA = "0x9FC074")]
		private static void Spawn_WallOfFleshGoatMountFlames(ParticleOrchestraSettings settings)
		{
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0xA257E4", Offset = "0xA257E4", VA = "0xA257E4")]
		public ParticleOrchestrator()
		{
		}

		// Token: 0x04009EB6 RID: 40630
		[Token(Token = "0x4009EB6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static ParticlePoolType<FadingParticle> _poolFading;

		// Token: 0x04009EB7 RID: 40631
		[Token(Token = "0x4009EB7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static ParticlePoolType<FadingPlayerShaderParticle> _poolFadingPlayerShader;

		// Token: 0x04009EB8 RID: 40632
		[Token(Token = "0x4009EB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ParticlePoolType<FlameParticle> _poolFlame;

		// Token: 0x04009EB9 RID: 40633
		[Token(Token = "0x4009EB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static ParticlePoolType<RandomizedFrameParticle> _poolRandomizedFrame;

		// Token: 0x04009EBA RID: 40634
		[Token(Token = "0x4009EBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ParticlePoolType<PrettySparkleParticle> _poolPrettySparkle;

		// Token: 0x04009EBB RID: 40635
		[Token(Token = "0x4009EBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static ParticlePoolType<ItemTransferParticle> _poolItemTransfer;

		// Token: 0x04009EBC RID: 40636
		[Token(Token = "0x4009EBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static ParticlePoolType<LittleFlyingCritterParticle> _poolFlies;

		// Token: 0x04009EBD RID: 40637
		[Token(Token = "0x4009EBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static ParticlePoolType<LittleFlyingCritterParticle> _natureFlies;

		// Token: 0x04009EBE RID: 40638
		[Token(Token = "0x4009EBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static ParticlePoolType<GasParticle> _poolGas;

		// Token: 0x04009EBF RID: 40639
		[Token(Token = "0x4009EBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static ParticlePoolType<BloodyExplosionParticle> _poolBloodyExplosion;

		// Token: 0x04009EC0 RID: 40640
		[Token(Token = "0x4009EC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static ParticlePoolType<ShockIconParticle> _poolShockIcon;

		// Token: 0x04009EC1 RID: 40641
		[Token(Token = "0x4009EC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static ParticlePoolType<FakeFishParticle> _fakeFish;

		// Token: 0x04009EC2 RID: 40642
		[Token(Token = "0x4009EC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static ParticlePoolType<ItemTransferParticle> ScreenItemParticles;

		// Token: 0x04009EC3 RID: 40643
		[Token(Token = "0x4009EC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static ParticlePoolType<StormLightningParticle> StormLightningParticles;

		// Token: 0x04009EC4 RID: 40644
		[Token(Token = "0x4009EC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static ParticleOrchestrator.QuickRandom internalRand;

		// Token: 0x04009EC5 RID: 40645
		[Token(Token = "0x4009EC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static SlotId[] _mushBoiExplosionSounds;

		// Token: 0x02000C99 RID: 3225
		[Token(Token = "0x2000C99")]
		public class QuickRandom
		{
			// Token: 0x06005FD5 RID: 24533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FD5")]
			[Address(RVA = "0xA8EEC4", Offset = "0xA8EEC4", VA = "0xA8EEC4")]
			public QuickRandom()
			{
			}

			// Token: 0x06005FD6 RID: 24534 RVA: 0x0002C328 File Offset: 0x0002A528
			[Token(Token = "0x6005FD6")]
			[Address(RVA = "0xA8EFEC", Offset = "0xA8EFEC", VA = "0xA8EFEC")]
			public float NextFloat()
			{
				return 0f;
			}

			// Token: 0x06005FD7 RID: 24535 RVA: 0x0002C340 File Offset: 0x0002A540
			[Token(Token = "0x6005FD7")]
			[Address(RVA = "0xA8F034", Offset = "0xA8F034", VA = "0xA8F034")]
			public int Next(int start, int end)
			{
				return 0;
			}

			// Token: 0x06005FD8 RID: 24536 RVA: 0x0002C358 File Offset: 0x0002A558
			[Token(Token = "0x6005FD8")]
			[Address(RVA = "0xA8F0B4", Offset = "0xA8F0B4", VA = "0xA8F0B4")]
			public int Next(int count)
			{
				return 0;
			}

			// Token: 0x04009EC6 RID: 40646
			[Token(Token = "0x4009EC6")]
			private const int TableSize = 2000;

			// Token: 0x04009EC7 RID: 40647
			[Token(Token = "0x4009EC7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int nextIndex;

			// Token: 0x04009EC8 RID: 40648
			[Token(Token = "0x4009EC8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private float[] floatTable;
		}

		// Token: 0x02000C9A RID: 3226
		[Token(Token = "0x2000C9A")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06005FD9 RID: 24537 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FD9")]
			[Address(RVA = "0xA8F128", Offset = "0xA8F128", VA = "0xA8F128")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x06005FDA RID: 24538 RVA: 0x0002C370 File Offset: 0x0002A570
			[Token(Token = "0x6005FDA")]
			[Address(RVA = "0xA8F130", Offset = "0xA8F130", VA = "0xA8F130")]
			internal float <MagnetFakeFish>b__0(FakeFishParticle x)
			{
				return 0f;
			}

			// Token: 0x06005FDB RID: 24539 RVA: 0x0002C388 File Offset: 0x0002A588
			[Token(Token = "0x6005FDB")]
			[Address(RVA = "0xA8F1F0", Offset = "0xA8F1F0", VA = "0xA8F1F0")]
			internal float <MagnetFakeFish>b__1(FakeFishParticle x)
			{
				return 0f;
			}

			// Token: 0x04009EC9 RID: 40649
			[Token(Token = "0x4009EC9")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Projectile proj;
		}

		// Token: 0x02000C9B RID: 3227
		[Token(Token = "0x2000C9B")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06005FDC RID: 24540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FDC")]
			[Address(RVA = "0xA8F2B0", Offset = "0xA8F2B0", VA = "0xA8F2B0")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x06005FDD RID: 24541 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
			[Token(Token = "0x6005FDD")]
			[Address(RVA = "0xA8F2B8", Offset = "0xA8F2B8", VA = "0xA8F2B8")]
			internal float <PingFakeFish>b__0(FakeFishParticle x)
			{
				return 0f;
			}

			// Token: 0x04009ECA RID: 40650
			[Token(Token = "0x4009ECA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Projectile proj;
		}

		// Token: 0x02000C9C RID: 3228
		[Token(Token = "0x2000C9C")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06005FDE RID: 24542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FDE")]
			[Address(RVA = "0xA8F378", Offset = "0xA8F378", VA = "0xA8F378")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x06005FDF RID: 24543 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
			[Token(Token = "0x6005FDF")]
			[Address(RVA = "0xA8F380", Offset = "0xA8F380", VA = "0xA8F380")]
			internal float <PushAwayFakeFish>b__0(FakeFishParticle x)
			{
				return 0f;
			}

			// Token: 0x04009ECB RID: 40651
			[Token(Token = "0x4009ECB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Projectile proj;
		}

		// Token: 0x02000C9D RID: 3229
		[Token(Token = "0x2000C9D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005FE1 RID: 24545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE1")]
			[Address(RVA = "0xA8F4B4", Offset = "0xA8F4B4", VA = "0xA8F4B4")]
			public <>c()
			{
			}

			// Token: 0x06005FE2 RID: 24546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE2")]
			[Address(RVA = "0xA8F4BC", Offset = "0xA8F4BC", VA = "0xA8F4BC")]
			internal void <Spawn_UFOLaser>b__65_0(Vector2 dustPos, Vector2 velocity)
			{
			}

			// Token: 0x06005FE3 RID: 24547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE3")]
			[Address(RVA = "0xA8F708", Offset = "0xA8F708", VA = "0xA8F708")]
			internal void <Spawn_MagnetSphereBolt>b__66_0(Vector2 dustPos, Vector2 velocity)
			{
			}

			// Token: 0x06005FE4 RID: 24548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE4")]
			[Address(RVA = "0xA8F8A8", Offset = "0xA8F8A8", VA = "0xA8F8A8")]
			internal void <Spawn_HeatRay>b__67_0(Vector2 dustPos, Vector2 velocity)
			{
			}

			// Token: 0x04009ECC RID: 40652
			[Token(Token = "0x4009ECC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly ParticleOrchestrator.<>c <>9;

			// Token: 0x04009ECD RID: 40653
			[Token(Token = "0x4009ECD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Action<Vector2, Vector2> <>9__65_0;

			// Token: 0x04009ECE RID: 40654
			[Token(Token = "0x4009ECE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<Vector2, Vector2> <>9__66_0;

			// Token: 0x04009ECF RID: 40655
			[Token(Token = "0x4009ECF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static Action<Vector2, Vector2> <>9__67_0;
		}

		// Token: 0x02000C9E RID: 3230
		[Token(Token = "0x2000C9E")]
		private sealed class <>c__DisplayClass68_0
		{
			// Token: 0x06005FE5 RID: 24549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE5")]
			[Address(RVA = "0xA8FA48", Offset = "0xA8FA48", VA = "0xA8FA48")]
			public <>c__DisplayClass68_0()
			{
			}

			// Token: 0x06005FE6 RID: 24550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005FE6")]
			[Address(RVA = "0xA8FA50", Offset = "0xA8FA50", VA = "0xA8FA50")]
			internal void <Spawn_Shadowbeam>b__0(Vector2 dustPos, Vector2 velocity)
			{
			}

			// Token: 0x04009ED0 RID: 40656
			[Token(Token = "0x4009ED0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float velocityScalar;
		}
	}
}
