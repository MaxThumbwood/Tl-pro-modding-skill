using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x2000A77")]
	public class WhipTagEffect_Starcrash : WhipTagEffect
	{
		// Token: 0x0600556A RID: 21866 RVA: 0x00027708 File Offset: 0x00025908
		[Token(Token = "0x600556A")]
		[Address(RVA = "0x82898C", Offset = "0x82898C", VA = "0x82898C", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556B")]
		[Address(RVA = "0x8289B4", Offset = "0x8289B4", VA = "0x8289B4")]
		private void SpawnMeteorWhipMeteorOn(Projectile projectile, NPC targetNPC, int calcDamage)
		{
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556C")]
		[Address(RVA = "0x828E08", Offset = "0x828E08", VA = "0x828E08")]
		public WhipTagEffect_Starcrash()
		{
		}
	}
}
