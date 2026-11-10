using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Utilities;

namespace Terraria.DataStructures
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	public class TileDrawInfo
	{
		// Token: 0x0600448F RID: 17551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x55A080", Offset = "0x55A080", VA = "0x55A080")]
		public void StaticSetup()
		{
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x55A41C", Offset = "0x55A41C", VA = "0x55A41C")]
		public TileDrawInfo()
		{
		}

		// Token: 0x04008C0C RID: 35852
		[Token(Token = "0x4008C0C")]
		[FieldOffset(Offset = "0x8")]
		public SpriteBatch spriteBatch;

		// Token: 0x04008C0D RID: 35853
		[Token(Token = "0x4008C0D")]
		[FieldOffset(Offset = "0xC")]
		public SpriteBatch spriteBatch2;

		// Token: 0x04008C0E RID: 35854
		[Token(Token = "0x4008C0E")]
		[FieldOffset(Offset = "0x10")]
		public int tileIndex;

		// Token: 0x04008C0F RID: 35855
		[Token(Token = "0x4008C0F")]
		[FieldOffset(Offset = "0x14")]
		public uint tilePalIndex;

		// Token: 0x04008C10 RID: 35856
		[Token(Token = "0x4008C10")]
		[FieldOffset(Offset = "0x18")]
		public ushort typeCache;

		// Token: 0x04008C11 RID: 35857
		[Token(Token = "0x4008C11")]
		[FieldOffset(Offset = "0x1A")]
		public short tileSHeader;

		// Token: 0x04008C12 RID: 35858
		[Token(Token = "0x4008C12")]
		[FieldOffset(Offset = "0x1C")]
		public short tileFrameX;

		// Token: 0x04008C13 RID: 35859
		[Token(Token = "0x4008C13")]
		[FieldOffset(Offset = "0x1E")]
		public short tileFrameY;

		// Token: 0x04008C14 RID: 35860
		[Token(Token = "0x4008C14")]
		[FieldOffset(Offset = "0x20")]
		public unsafe uint* tileLookup;

		// Token: 0x04008C15 RID: 35861
		[Token(Token = "0x4008C15")]
		[FieldOffset(Offset = "0x24")]
		public unsafe ushort* tileTypeData;

		// Token: 0x04008C16 RID: 35862
		[Token(Token = "0x4008C16")]
		[FieldOffset(Offset = "0x28")]
		public unsafe short* tileTypeSHeader;

		// Token: 0x04008C17 RID: 35863
		[Token(Token = "0x4008C17")]
		[FieldOffset(Offset = "0x2C")]
		public unsafe byte* tileTypeLiquid;

		// Token: 0x04008C18 RID: 35864
		[Token(Token = "0x4008C18")]
		[FieldOffset(Offset = "0x30")]
		public unsafe byte* tileTypeBHeader;

		// Token: 0x04008C19 RID: 35865
		[Token(Token = "0x4008C19")]
		[FieldOffset(Offset = "0x34")]
		public unsafe byte* tileTypeBHeader3;

		// Token: 0x04008C1A RID: 35866
		[Token(Token = "0x4008C1A")]
		[FieldOffset(Offset = "0x38")]
		public unsafe ushort* tileTypeWall;

		// Token: 0x04008C1B RID: 35867
		[Token(Token = "0x4008C1B")]
		[FieldOffset(Offset = "0x3C")]
		public unsafe short* tileTypeFrameX;

		// Token: 0x04008C1C RID: 35868
		[Token(Token = "0x4008C1C")]
		[FieldOffset(Offset = "0x40")]
		public unsafe short* tileTypeFrameY;

		// Token: 0x04008C1D RID: 35869
		[Token(Token = "0x4008C1D")]
		[FieldOffset(Offset = "0x44")]
		public int lightMinX;

		// Token: 0x04008C1E RID: 35870
		[Token(Token = "0x4008C1E")]
		[FieldOffset(Offset = "0x48")]
		public int lightMinY;

		// Token: 0x04008C1F RID: 35871
		[Token(Token = "0x4008C1F")]
		[FieldOffset(Offset = "0x4C")]
		public int lightMaxX;

		// Token: 0x04008C20 RID: 35872
		[Token(Token = "0x4008C20")]
		[FieldOffset(Offset = "0x50")]
		public int lightMaxY;

		// Token: 0x04008C21 RID: 35873
		[Token(Token = "0x4008C21")]
		[FieldOffset(Offset = "0x54")]
		public unsafe Vector3* lightColors;

		// Token: 0x04008C22 RID: 35874
		[Token(Token = "0x4008C22")]
		[FieldOffset(Offset = "0x58")]
		public int lightMapHeight;

		// Token: 0x04008C23 RID: 35875
		[Token(Token = "0x4008C23")]
		[FieldOffset(Offset = "0x5C")]
		public float lightGlobal255;

		// Token: 0x04008C24 RID: 35876
		[Token(Token = "0x4008C24")]
		[FieldOffset(Offset = "0x60")]
		public EffectPass drawEffect;

		// Token: 0x04008C25 RID: 35877
		[Token(Token = "0x4008C25")]
		[FieldOffset(Offset = "0x64")]
		public Texture2D drawTexture;

		// Token: 0x04008C26 RID: 35878
		[Token(Token = "0x4008C26")]
		[FieldOffset(Offset = "0x68")]
		public Color tileLight;

		// Token: 0x04008C27 RID: 35879
		[Token(Token = "0x4008C27")]
		[FieldOffset(Offset = "0x6C")]
		public int tileTop;

		// Token: 0x04008C28 RID: 35880
		[Token(Token = "0x4008C28")]
		[FieldOffset(Offset = "0x70")]
		public int tileWidth;

		// Token: 0x04008C29 RID: 35881
		[Token(Token = "0x4008C29")]
		[FieldOffset(Offset = "0x74")]
		public int tileHeight;

		// Token: 0x04008C2A RID: 35882
		[Token(Token = "0x4008C2A")]
		[FieldOffset(Offset = "0x78")]
		public int halfBrickHeight;

		// Token: 0x04008C2B RID: 35883
		[Token(Token = "0x4008C2B")]
		[FieldOffset(Offset = "0x7C")]
		public int addFrY;

		// Token: 0x04008C2C RID: 35884
		[Token(Token = "0x4008C2C")]
		[FieldOffset(Offset = "0x80")]
		public int addFrX;

		// Token: 0x04008C2D RID: 35885
		[Token(Token = "0x4008C2D")]
		[FieldOffset(Offset = "0x84")]
		public SpriteEffects tileSpriteEffect;

		// Token: 0x04008C2E RID: 35886
		[Token(Token = "0x4008C2E")]
		[FieldOffset(Offset = "0x88")]
		public Texture2D glowTexture;

		// Token: 0x04008C2F RID: 35887
		[Token(Token = "0x4008C2F")]
		[FieldOffset(Offset = "0x8C")]
		public Rectangle glowSourceRect;

		// Token: 0x04008C30 RID: 35888
		[Token(Token = "0x4008C30")]
		[FieldOffset(Offset = "0x9C")]
		public Color glowColor;

		// Token: 0x04008C31 RID: 35889
		[Token(Token = "0x4008C31")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3[] colorSlices;

		// Token: 0x04008C32 RID: 35890
		[Token(Token = "0x4008C32")]
		[FieldOffset(Offset = "0xA4")]
		public Color finalColor;

		// Token: 0x04008C33 RID: 35891
		[Token(Token = "0x4008C33")]
		[FieldOffset(Offset = "0xA8")]
		public UnifiedRandom _rand;

		// Token: 0x04008C34 RID: 35892
		[Token(Token = "0x4008C34")]
		[FieldOffset(Offset = "0xAC")]
		public Dictionary<Point, int> _displayDollTileEntityPositions;

		// Token: 0x04008C35 RID: 35893
		[Token(Token = "0x4008C35")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<Point, int> _hatRackTileEntityPositions;

		// Token: 0x04008C36 RID: 35894
		[Token(Token = "0x4008C36")]
		[FieldOffset(Offset = "0xB4")]
		public Dictionary<Point, int> _trainingDummyTileEntityPositions;

		// Token: 0x04008C37 RID: 35895
		[Token(Token = "0x4008C37")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<Point, int> _itemFrameTileEntityPositions;

		// Token: 0x04008C38 RID: 35896
		[Token(Token = "0x4008C38")]
		[FieldOffset(Offset = "0xBC")]
		public Dictionary<Point, int> _deadCellsDisplayJarTileEntityPositions;

		// Token: 0x04008C39 RID: 35897
		[Token(Token = "0x4008C39")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<Point, int> _foodPlatterTileEntityPositions;

		// Token: 0x04008C3A RID: 35898
		[Token(Token = "0x4008C3A")]
		[FieldOffset(Offset = "0xC4")]
		public Dictionary<Point, int> _weaponRackTileEntityPositions;

		// Token: 0x04008C3B RID: 35899
		[Token(Token = "0x4008C3B")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<Point, int> _chestPositions;

		// Token: 0x04008C3C RID: 35900
		[Token(Token = "0x4008C3C")]
		[FieldOffset(Offset = "0x0")]
		private static bool Setup;

		// Token: 0x04008C3D RID: 35901
		[Token(Token = "0x4008C3D")]
		[FieldOffset(Offset = "0xCC")]
		public VertexColors tileColors;
	}
}
