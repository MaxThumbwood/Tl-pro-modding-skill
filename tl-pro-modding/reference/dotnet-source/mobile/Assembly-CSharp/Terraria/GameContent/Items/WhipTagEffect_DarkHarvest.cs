using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	public class WhipTagEffect_DarkHarvest : WhipTagEffect
	{
		// Token: 0x0600556D RID: 21869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556D")]
		[Address(RVA = "0x828E24", Offset = "0x828E24", VA = "0x828E24", Slot = "11")]
		public override void OnTaggedHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556E")]
		[Address(RVA = "0x828E30", Offset = "0x828E30", VA = "0x828E30")]
		private void SpawnBlackLightning(Projectile projectile, NPC npcHit)
		{
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556F")]
		[Address(RVA = "0x8290F4", Offset = "0x8290F4", VA = "0x8290F4")]
		private static void EmitBlackLightningParticles(NPC targetNPC)
		{
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005570")]
		[Address(RVA = "0x8291B0", Offset = "0x8291B0", VA = "0x8291B0")]
		public WhipTagEffect_DarkHarvest()
		{
		}
	}
}
