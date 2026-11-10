using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A7B RID: 2683
	[Token(Token = "0x2000A7B")]
	public class WhipTagEffect_ElectricEel : WhipTagEffect
	{
		// Token: 0x0600557A RID: 21882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557A")]
		[Address(RVA = "0x829738", Offset = "0x829738", VA = "0x829738", Slot = "10")]
		public override void ModifyProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00027750 File Offset: 0x00025950
		[Token(Token = "0x600557B")]
		[Address(RVA = "0x829BEC", Offset = "0x829BEC", VA = "0x829BEC", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557C")]
		[Address(RVA = "0x829748", Offset = "0x829748", VA = "0x829748")]
		public static void CreateLightningBlast(Player owner, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x0600557D RID: 21885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557D")]
		[Address(RVA = "0x829BF4", Offset = "0x829BF4", VA = "0x829BF4")]
		public WhipTagEffect_ElectricEel()
		{
		}
	}
}
