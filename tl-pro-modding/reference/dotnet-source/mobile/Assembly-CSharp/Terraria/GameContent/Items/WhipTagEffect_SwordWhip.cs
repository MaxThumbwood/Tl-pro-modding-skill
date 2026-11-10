using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A7A RID: 2682
	[Token(Token = "0x2000A7A")]
	public class WhipTagEffect_SwordWhip : WhipTagEffect
	{
		// Token: 0x06005576 RID: 21878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005576")]
		[Address(RVA = "0x8295A4", Offset = "0x8295A4", VA = "0x8295A4", Slot = "10")]
		public override void ModifyProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x00027738 File Offset: 0x00025938
		[Token(Token = "0x6005577")]
		[Address(RVA = "0x829714", Offset = "0x829714", VA = "0x829714", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005578")]
		[Address(RVA = "0x8295B0", Offset = "0x8295B0", VA = "0x8295B0")]
		public static void MegaSlash(NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005579")]
		[Address(RVA = "0x82971C", Offset = "0x82971C", VA = "0x82971C")]
		public WhipTagEffect_SwordWhip()
		{
		}
	}
}
