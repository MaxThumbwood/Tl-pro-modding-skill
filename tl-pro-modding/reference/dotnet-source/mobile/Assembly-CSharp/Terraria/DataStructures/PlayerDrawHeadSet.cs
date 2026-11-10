using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class PlayerDrawHeadSet
	{
		// Token: 0x060043EA RID: 17386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x54F964", Offset = "0x54F964", VA = "0x54F964")]
		public void AddDrawData(ref DrawData data)
		{
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00020988 File Offset: 0x0001EB88
		[Token(Token = "0x17000832")]
		public Rectangle HairFrame
		{
			[Token(Token = "0x60043EB")]
			[Address(RVA = "0x54F9D8", Offset = "0x54F9D8", VA = "0x54F9D8")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x54F9F8", Offset = "0x54F9F8", VA = "0x54F9F8")]
		public void BoringSetup(Player drawPlayer2, DrawData[] drawData, List<int> dust, List<int> gore, float X, float Y, float Alpha, float Scale)
		{
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x550854", Offset = "0x550854", VA = "0x550854")]
		public PlayerDrawHeadSet()
		{
		}

		// Token: 0x04008B54 RID: 35668
		[Token(Token = "0x4008B54")]
		[FieldOffset(Offset = "0x8")]
		public int DrawDataCount;

		// Token: 0x04008B55 RID: 35669
		[Token(Token = "0x4008B55")]
		[FieldOffset(Offset = "0xC")]
		public DrawData[] DrawData;

		// Token: 0x04008B56 RID: 35670
		[Token(Token = "0x4008B56")]
		[FieldOffset(Offset = "0x10")]
		public List<int> Dust;

		// Token: 0x04008B57 RID: 35671
		[Token(Token = "0x4008B57")]
		[FieldOffset(Offset = "0x14")]
		public List<int> Gore;

		// Token: 0x04008B58 RID: 35672
		[Token(Token = "0x4008B58")]
		[FieldOffset(Offset = "0x18")]
		public Player drawPlayer;

		// Token: 0x04008B59 RID: 35673
		[Token(Token = "0x4008B59")]
		[FieldOffset(Offset = "0x1C")]
		public int cHead;

		// Token: 0x04008B5A RID: 35674
		[Token(Token = "0x4008B5A")]
		[FieldOffset(Offset = "0x20")]
		public int cFace;

		// Token: 0x04008B5B RID: 35675
		[Token(Token = "0x4008B5B")]
		[FieldOffset(Offset = "0x24")]
		public int cFaceHead;

		// Token: 0x04008B5C RID: 35676
		[Token(Token = "0x4008B5C")]
		[FieldOffset(Offset = "0x28")]
		public int cFaceFlower;

		// Token: 0x04008B5D RID: 35677
		[Token(Token = "0x4008B5D")]
		[FieldOffset(Offset = "0x2C")]
		public int cFaceMask;

		// Token: 0x04008B5E RID: 35678
		[Token(Token = "0x4008B5E")]
		[FieldOffset(Offset = "0x30")]
		public int cUnicornHorn;

		// Token: 0x04008B5F RID: 35679
		[Token(Token = "0x4008B5F")]
		[FieldOffset(Offset = "0x34")]
		public int cAngelHalo;

		// Token: 0x04008B60 RID: 35680
		[Token(Token = "0x4008B60")]
		[FieldOffset(Offset = "0x38")]
		public int cBeard;

		// Token: 0x04008B61 RID: 35681
		[Token(Token = "0x4008B61")]
		[FieldOffset(Offset = "0x3C")]
		public int skinVar;

		// Token: 0x04008B62 RID: 35682
		[Token(Token = "0x4008B62")]
		[FieldOffset(Offset = "0x40")]
		public int hairShaderPacked;

		// Token: 0x04008B63 RID: 35683
		[Token(Token = "0x4008B63")]
		[FieldOffset(Offset = "0x44")]
		public int skinDyePacked;

		// Token: 0x04008B64 RID: 35684
		[Token(Token = "0x4008B64")]
		[FieldOffset(Offset = "0x48")]
		public float scale;

		// Token: 0x04008B65 RID: 35685
		[Token(Token = "0x4008B65")]
		[FieldOffset(Offset = "0x4C")]
		public Color colorEyeWhites;

		// Token: 0x04008B66 RID: 35686
		[Token(Token = "0x4008B66")]
		[FieldOffset(Offset = "0x50")]
		public Color colorEyes;

		// Token: 0x04008B67 RID: 35687
		[Token(Token = "0x4008B67")]
		[FieldOffset(Offset = "0x54")]
		public Color colorHair;

		// Token: 0x04008B68 RID: 35688
		[Token(Token = "0x4008B68")]
		[FieldOffset(Offset = "0x58")]
		public Color colorHead;

		// Token: 0x04008B69 RID: 35689
		[Token(Token = "0x4008B69")]
		[FieldOffset(Offset = "0x5C")]
		public Color colorArmorHead;

		// Token: 0x04008B6A RID: 35690
		[Token(Token = "0x4008B6A")]
		[FieldOffset(Offset = "0x60")]
		public Color colorDisplayDollSkin;

		// Token: 0x04008B6B RID: 35691
		[Token(Token = "0x4008B6B")]
		[FieldOffset(Offset = "0x64")]
		public SpriteEffects playerEffect;

		// Token: 0x04008B6C RID: 35692
		[Token(Token = "0x4008B6C")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 headVect;

		// Token: 0x04008B6D RID: 35693
		[Token(Token = "0x4008B6D")]
		[FieldOffset(Offset = "0x70")]
		public Rectangle bodyFrameMemory;

		// Token: 0x04008B6E RID: 35694
		[Token(Token = "0x4008B6E")]
		[FieldOffset(Offset = "0x80")]
		public bool fullHair;

		// Token: 0x04008B6F RID: 35695
		[Token(Token = "0x4008B6F")]
		[FieldOffset(Offset = "0x81")]
		public bool hatHair;

		// Token: 0x04008B70 RID: 35696
		[Token(Token = "0x4008B70")]
		[FieldOffset(Offset = "0x82")]
		public bool hideHair;

		// Token: 0x04008B71 RID: 35697
		[Token(Token = "0x4008B71")]
		[FieldOffset(Offset = "0x83")]
		public bool helmetIsTall;

		// Token: 0x04008B72 RID: 35698
		[Token(Token = "0x4008B72")]
		[FieldOffset(Offset = "0x84")]
		public bool helmetIsOverFullHair;

		// Token: 0x04008B73 RID: 35699
		[Token(Token = "0x4008B73")]
		[FieldOffset(Offset = "0x85")]
		public bool helmetIsNormal;

		// Token: 0x04008B74 RID: 35700
		[Token(Token = "0x4008B74")]
		[FieldOffset(Offset = "0x86")]
		public bool drawUnicornHorn;

		// Token: 0x04008B75 RID: 35701
		[Token(Token = "0x4008B75")]
		[FieldOffset(Offset = "0x87")]
		public bool drawAngelHalo;

		// Token: 0x04008B76 RID: 35702
		[Token(Token = "0x4008B76")]
		[FieldOffset(Offset = "0x88")]
		public Vector2 Position;

		// Token: 0x04008B77 RID: 35703
		[Token(Token = "0x4008B77")]
		[FieldOffset(Offset = "0x90")]
		public Vector2 hairOffset;

		// Token: 0x04008B78 RID: 35704
		[Token(Token = "0x4008B78")]
		[FieldOffset(Offset = "0x98")]
		public Vector2 helmetOffset;
	}
}
