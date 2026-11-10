using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class WhipTagEffect_ViolentDisplayOfFlower : WhipTagEffect
	{
		// Token: 0x06005567 RID: 21863 RVA: 0x000276F0 File Offset: 0x000258F0
		[Token(Token = "0x6005567")]
		[Address(RVA = "0x828408", Offset = "0x828408", VA = "0x828408", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005568")]
		[Address(RVA = "0x82843C", Offset = "0x82843C", VA = "0x82843C")]
		private void SpawnFlowerExplosionOn(Projectile projectile, NPC targetNPC, int calcDamage)
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005569")]
		[Address(RVA = "0x828970", Offset = "0x828970", VA = "0x828970")]
		public WhipTagEffect_ViolentDisplayOfFlower()
		{
		}
	}
}
