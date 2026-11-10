using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000BBC RID: 3004
	[Token(Token = "0x2000BBC")]
	public class SurfaceMap
	{
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		[Token(Token = "0x17000A1C")]
		public int Width
		{
			[Token(Token = "0x6005B33")]
			[Address(RVA = "0x971E00", Offset = "0x971E00", VA = "0x971E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B34")]
		[Address(RVA = "0x97CAC8", Offset = "0x97CAC8", VA = "0x97CAC8")]
		private SurfaceMap(short[] heights, int x)
		{
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06005B35 RID: 23349 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		[Token(Token = "0x17000A1D")]
		public short Item
		{
			[Token(Token = "0x6005B35")]
			[Address(RVA = "0x971E24", Offset = "0x971E24", VA = "0x971E24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B36")]
		[Address(RVA = "0x974C6C", Offset = "0x974C6C", VA = "0x974C6C")]
		public static SurfaceMap FromArea(int startX, int width)
		{
			return null;
		}

		// Token: 0x04009C13 RID: 39955
		[Token(Token = "0x4009C13")]
		[FieldOffset(Offset = "0x8")]
		public readonly double Average;

		// Token: 0x04009C14 RID: 39956
		[Token(Token = "0x4009C14")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Bottom;

		// Token: 0x04009C15 RID: 39957
		[Token(Token = "0x4009C15")]
		[FieldOffset(Offset = "0x14")]
		public readonly int Top;

		// Token: 0x04009C16 RID: 39958
		[Token(Token = "0x4009C16")]
		[FieldOffset(Offset = "0x18")]
		public readonly int X;

		// Token: 0x04009C17 RID: 39959
		[Token(Token = "0x4009C17")]
		[FieldOffset(Offset = "0x1C")]
		private readonly short[] _heights;
	}
}
