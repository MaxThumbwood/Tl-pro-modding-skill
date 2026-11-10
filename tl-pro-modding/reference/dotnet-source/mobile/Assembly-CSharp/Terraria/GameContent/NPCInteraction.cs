using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x020009A1 RID: 2465
	[Token(Token = "0x20009A1")]
	public abstract class NPCInteraction
	{
		// Token: 0x06005107 RID: 20743
		[Token(Token = "0x6005107")]
		public abstract bool Condition();

		// Token: 0x06005108 RID: 20744
		[Token(Token = "0x6005108")]
		public abstract string GetText();

		// Token: 0x06005109 RID: 20745
		[Token(Token = "0x6005109")]
		public abstract void Interact();

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00025AB8 File Offset: 0x00023CB8
		[Token(Token = "0x1700099C")]
		public virtual bool ShowExclamation
		{
			[Token(Token = "0x600510A")]
			[Address(RVA = "0x7775B4", Offset = "0x7775B4", VA = "0x7775B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00025AD0 File Offset: 0x00023CD0
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x7775BC", Offset = "0x7775BC", VA = "0x7775BC", Slot = "8")]
		public virtual bool TryAddCoins(ref Color chatColor, out int coinValue)
		{
			return default(bool);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099D")]
		public Player LocalPlayer
		{
			[Token(Token = "0x600510C")]
			[Address(RVA = "0x7775CC", Offset = "0x7775CC", VA = "0x7775CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600510D RID: 20749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700099E")]
		public NPC TalkNPC
		{
			[Token(Token = "0x600510D")]
			[Address(RVA = "0x77762C", Offset = "0x77762C", VA = "0x77762C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x00025AE8 File Offset: 0x00023CE8
		[Token(Token = "0x1700099F")]
		public int TalkNPCType
		{
			[Token(Token = "0x600510E")]
			[Address(RVA = "0x7776FC", Offset = "0x7776FC", VA = "0x7776FC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x777798", Offset = "0x777798", VA = "0x777798")]
		protected NPCInteraction()
		{
		}
	}
}
