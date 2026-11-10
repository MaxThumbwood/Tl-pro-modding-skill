using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A7C RID: 2684
	[Token(Token = "0x2000A7C")]
	public class WhipTagEffect_Constellation : WhipTagEffect
	{
		// Token: 0x0600557E RID: 21886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x829C10", Offset = "0x829C10", VA = "0x829C10", Slot = "11")]
		public override void OnTaggedHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00027768 File Offset: 0x00025968
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x829C4C", Offset = "0x829C4C", VA = "0x829C4C", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x829C70", Offset = "0x829C70", VA = "0x829C70")]
		public WhipTagEffect_Constellation()
		{
		}
	}
}
