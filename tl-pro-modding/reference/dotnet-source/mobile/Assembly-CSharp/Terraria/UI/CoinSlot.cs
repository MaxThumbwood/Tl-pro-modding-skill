using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI
{
	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	public class CoinSlot
	{
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FE")]
		private static CoinSlot.CoinEntry[] Savings
		{
			[Token(Token = "0x60048ED")]
			[Address(RVA = "0x5F5074", Offset = "0x5F5074", VA = "0x5F5074")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060048EE RID: 18670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008FF")]
		private static CoinSlot.CoinEntry[] ChestEntries
		{
			[Token(Token = "0x60048EE")]
			[Address(RVA = "0x5F50DC", Offset = "0x5F50DC", VA = "0x5F50DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060048EF RID: 18671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000900")]
		private static CoinSlot.CoinEntry[] InventoryEntries
		{
			[Token(Token = "0x60048EF")]
			[Address(RVA = "0x5F5144", Offset = "0x5F5144", VA = "0x5F5144")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060048F0 RID: 18672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000901")]
		private static Dictionary<int, CoinSlot.CoinEntryRef> Custom
		{
			[Token(Token = "0x60048F0")]
			[Address(RVA = "0x5F51AC", Offset = "0x5F51AC", VA = "0x5F51AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x5F5214", Offset = "0x5F5214", VA = "0x5F5214")]
		public static void UpdateSavings(int slot, int count, out CoinSlot.CoinDrawState drawState)
		{
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x5F5810", Offset = "0x5F5810", VA = "0x5F5810")]
		public static void UpdateCustom(int customCurrencyID, int count, out CoinSlot.CoinDrawState drawState)
		{
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x00022C38 File Offset: 0x00020E38
		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x5F5A48", Offset = "0x5F5A48", VA = "0x5F5A48")]
		public static float DrawItemCoin(SpriteBatch spriteBatch, Vector2 screenPositionForItemCenter, int coinType, int coinFrame, float scale, float sizeLimit, Color itemColor, float itemFade = 1f)
		{
			return 0f;
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x5F5E2C", Offset = "0x5F5E2C", VA = "0x5F5E2C")]
		public static void UpdateSlotAnims()
		{
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x5F0A34", Offset = "0x5F0A34", VA = "0x5F0A34")]
		public static void ForceSlotState(int slot, int context, Item item)
		{
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x5F6500", Offset = "0x5F6500", VA = "0x5F6500")]
		public static void UpdateDrawState(int slot, int context, Item item, out CoinSlot.CoinDrawState drawState)
		{
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x5F66F4", Offset = "0x5F66F4", VA = "0x5F66F4")]
		public CoinSlot()
		{
		}

		// Token: 0x04008EF9 RID: 36601
		[Token(Token = "0x4008EF9")]
		[FieldOffset(Offset = "0x0")]
		private static float[] FadeAnimKeys;

		// Token: 0x04008EFA RID: 36602
		[Token(Token = "0x4008EFA")]
		[FieldOffset(Offset = "0x4")]
		private static float[] TextAnimKeys;

		// Token: 0x04008EFB RID: 36603
		[Token(Token = "0x4008EFB")]
		[FieldOffset(Offset = "0x8")]
		private static float[] JumpAnimKeys;

		// Token: 0x04008EFC RID: 36604
		[Token(Token = "0x4008EFC")]
		[FieldOffset(Offset = "0xC")]
		private static int JumpApex;

		// Token: 0x04008EFD RID: 36605
		[Token(Token = "0x4008EFD")]
		[FieldOffset(Offset = "0x10")]
		private static int JumpTrigger_TextAnimRangeStart;

		// Token: 0x04008EFE RID: 36606
		[Token(Token = "0x4008EFE")]
		[FieldOffset(Offset = "0x14")]
		private static int JumpTrigger_TextAnimRangeEnd;

		// Token: 0x04008EFF RID: 36607
		[Token(Token = "0x4008EFF")]
		[FieldOffset(Offset = "0x18")]
		private static float ItemSlotCoinJumpScale;

		// Token: 0x04008F00 RID: 36608
		[Token(Token = "0x4008F00")]
		[FieldOffset(Offset = "0x1C")]
		private static float SavingsCoinJumpScale;

		// Token: 0x04008F01 RID: 36609
		[Token(Token = "0x4008F01")]
		[FieldOffset(Offset = "0x20")]
		private static int JumpAnimHoldTime;

		// Token: 0x04008F02 RID: 36610
		[Token(Token = "0x4008F02")]
		[FieldOffset(Offset = "0x24")]
		private static int SpinAnimRangeStart;

		// Token: 0x04008F03 RID: 36611
		[Token(Token = "0x4008F03")]
		[FieldOffset(Offset = "0x28")]
		private static int SpinAnimRangeEnd;

		// Token: 0x0200083B RID: 2107
		[Token(Token = "0x200083B")]
		public struct CoinEntry
		{
			// Token: 0x060048F9 RID: 18681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048F9")]
			[Address(RVA = "0x5F64E4", Offset = "0x5F64E4", VA = "0x5F64E4")]
			public void ForceState(int itemType, int itemStack)
			{
			}

			// Token: 0x060048FA RID: 18682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048FA")]
			[Address(RVA = "0x5F5308", Offset = "0x5F5308", VA = "0x5F5308")]
			public void UpdateState(int itemType, int itemStack, float jumpScale, out CoinSlot.CoinDrawState drawState)
			{
			}

			// Token: 0x060048FB RID: 18683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048FB")]
			[Address(RVA = "0x5F6300", Offset = "0x5F6300", VA = "0x5F6300")]
			public void UpdateAnim()
			{
			}

			// Token: 0x04008F04 RID: 36612
			[Token(Token = "0x4008F04")]
			[FieldOffset(Offset = "0x0")]
			public int Type;

			// Token: 0x04008F05 RID: 36613
			[Token(Token = "0x4008F05")]
			[FieldOffset(Offset = "0x4")]
			public int Stack;

			// Token: 0x04008F06 RID: 36614
			[Token(Token = "0x4008F06")]
			[FieldOffset(Offset = "0x8")]
			public int TextAnimFrame;

			// Token: 0x04008F07 RID: 36615
			[Token(Token = "0x4008F07")]
			[FieldOffset(Offset = "0xC")]
			public int JumpAnimFrame;

			// Token: 0x04008F08 RID: 36616
			[Token(Token = "0x4008F08")]
			[FieldOffset(Offset = "0x10")]
			public int SpinAnimFrame;

			// Token: 0x04008F09 RID: 36617
			[Token(Token = "0x4008F09")]
			[FieldOffset(Offset = "0x14")]
			public int DrawActive;

			// Token: 0x04008F0A RID: 36618
			[Token(Token = "0x4008F0A")]
			[FieldOffset(Offset = "0x18")]
			public int JumpAnimHold;

			// Token: 0x04008F0B RID: 36619
			[Token(Token = "0x4008F0B")]
			[FieldOffset(Offset = "0x1C")]
			public int FadeItemType;
		}

		// Token: 0x0200083C RID: 2108
		[Token(Token = "0x200083C")]
		public class CoinEntryRef
		{
			// Token: 0x060048FC RID: 18684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048FC")]
			[Address(RVA = "0x5F5A40", Offset = "0x5F5A40", VA = "0x5F5A40")]
			public CoinEntryRef()
			{
			}

			// Token: 0x04008F0C RID: 36620
			[Token(Token = "0x4008F0C")]
			[FieldOffset(Offset = "0x8")]
			public CoinSlot.CoinEntry val;
		}

		// Token: 0x0200083D RID: 2109
		[Token(Token = "0x200083D")]
		public struct CoinDrawState
		{
			// Token: 0x04008F0D RID: 36621
			[Token(Token = "0x4008F0D")]
			[FieldOffset(Offset = "0x0")]
			public int coinAnimFrame;

			// Token: 0x04008F0E RID: 36622
			[Token(Token = "0x4008F0E")]
			[FieldOffset(Offset = "0x4")]
			public float coinYOffset;

			// Token: 0x04008F0F RID: 36623
			[Token(Token = "0x4008F0F")]
			[FieldOffset(Offset = "0x8")]
			public float stackTextScale;

			// Token: 0x04008F10 RID: 36624
			[Token(Token = "0x4008F10")]
			[FieldOffset(Offset = "0xC")]
			public float stackTextDrawFadeOverload;

			// Token: 0x04008F11 RID: 36625
			[Token(Token = "0x4008F11")]
			[FieldOffset(Offset = "0x10")]
			public int fadeItem;

			// Token: 0x04008F12 RID: 36626
			[Token(Token = "0x4008F12")]
			[FieldOffset(Offset = "0x14")]
			public float fadeScale;
		}
	}
}
