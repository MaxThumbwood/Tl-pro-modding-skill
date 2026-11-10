using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A75 RID: 2677
	[Token(Token = "0x2000A75")]
	public class WhipTagEffect_Possession : WhipTagEffect
	{
		// Token: 0x06005565 RID: 21861 RVA: 0x000276D8 File Offset: 0x000258D8
		[Token(Token = "0x6005565")]
		[Address(RVA = "0x828364", Offset = "0x828364", VA = "0x828364", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005566")]
		[Address(RVA = "0x8283EC", Offset = "0x8283EC", VA = "0x8283EC")]
		public WhipTagEffect_Possession()
		{
		}
	}
}
