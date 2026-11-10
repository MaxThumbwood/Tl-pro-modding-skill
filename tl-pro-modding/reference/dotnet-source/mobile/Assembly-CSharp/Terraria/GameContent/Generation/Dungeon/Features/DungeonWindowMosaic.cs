using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	public class DungeonWindowMosaic : DungeonWindow
	{
		// Token: 0x06005A2D RID: 23085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x8EDE60", Offset = "0x8EDE60", VA = "0x8EDE60")]
		public DungeonWindowMosaic(DungeonFeatureSettings settings)
		{
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x0002A420 File Offset: 0x00028620
		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x8EDE64", Offset = "0x8EDE64", VA = "0x8EDE64", Slot = "4")]
		public override bool GenerateFeature(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x0002A438 File Offset: 0x00028638
		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x8EDF64", Offset = "0x8EDF64", VA = "0x8EDF64")]
		public bool Window(DungeonData data, int placeX, int placeY, DungeonGenerationStyleData style, bool generating = false)
		{
			return default(bool);
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A30")]
		[Address(RVA = "0x8EE198", Offset = "0x8EE198", VA = "0x8EE198")]
		public void Window_Skeletron(int placeX, int placeY, ushort glassWallType, ushort edgeWallType, byte paint = 0)
		{
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x0002A450 File Offset: 0x00028650
		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x8F2FA0", Offset = "0x8F2FA0", VA = "0x8F2FA0")]
		private bool Skeletron_ValidSkullSpot(int x, int y, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x0002A468 File Offset: 0x00028668
		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x8F30BC", Offset = "0x8F30BC", VA = "0x8F30BC")]
		private bool Skeletron_ValidJawSpot(Tile tile, int glassWallType, int x, int y, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x8F0768", Offset = "0x8F0768", VA = "0x8F0768")]
		public void Window_MoonLord(int placeX, int placeY, ushort glassWallType, ushort edgeWallType, byte paint = 0)
		{
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x0002A480 File Offset: 0x00028680
		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x8F3210", Offset = "0x8F3210", VA = "0x8F3210")]
		private bool MoonLord_ValidSideEyeSpot(int x, int y, bool leftEye, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x0002A498 File Offset: 0x00028698
		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x8F32EC", Offset = "0x8F32EC", VA = "0x8F32EC")]
		private bool MoonLord_ValidMidEyeSpot(int x, int y, int width, int height)
		{
			return default(bool);
		}
	}
}
