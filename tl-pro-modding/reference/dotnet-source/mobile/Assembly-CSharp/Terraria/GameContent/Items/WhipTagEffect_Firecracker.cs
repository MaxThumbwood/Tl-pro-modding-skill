using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Items
{
	// Token: 0x02000A79 RID: 2681
	[Token(Token = "0x2000A79")]
	public class WhipTagEffect_Firecracker : WhipTagEffect
	{
		// Token: 0x06005571 RID: 21873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005571")]
		[Address(RVA = "0x8291CC", Offset = "0x8291CC", VA = "0x8291CC", Slot = "10")]
		public override void ModifyProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, ref TagDamageChanges changes)
		{
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x00027720 File Offset: 0x00025920
		[Token(Token = "0x6005572")]
		[Address(RVA = "0x829248", Offset = "0x829248", VA = "0x829248", Slot = "12")]
		public override bool OnProcHit(Player owner, Projectile optionalProjectile, NPC npcHit, int calcDamage)
		{
			return default(bool);
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005573")]
		[Address(RVA = "0x8292F0", Offset = "0x8292F0", VA = "0x8292F0")]
		private static void CreateExplosion(Projectile projectile, NPC npcHit, int procDamage)
		{
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005574")]
		[Address(RVA = "0x829530", Offset = "0x829530", VA = "0x829530")]
		public WhipTagEffect_Firecracker()
		{
		}

		// Token: 0x04009899 RID: 39065
		[Token(Token = "0x4009899")]
		[FieldOffset(Offset = "0x0")]
		private static float ProcDamageMultiplier;
	}
}
