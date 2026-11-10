using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000424 RID: 1060
	[Token(Token = "0x2000424")]
	public abstract class Texture : GraphicsResource
	{
		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[Token(Token = "0x1700039D")]
		internal int SortingKey
		{
			[Token(Token = "0x6001D58")]
			[Address(RVA = "0xE90BB8", Offset = "0xE90BB8", VA = "0xE90BB8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x1700039E")]
		public SurfaceFormat Format
		{
			[Token(Token = "0x6001D59")]
			[Address(RVA = "0xE90BC0", Offset = "0xE90BC0", VA = "0xE90BC0")]
			get
			{
				return SurfaceFormat.Color;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x1700039F")]
		public int LevelCount
		{
			[Token(Token = "0x6001D5A")]
			[Address(RVA = "0xE90BC8", Offset = "0xE90BC8", VA = "0xE90BC8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0xE90BD0", Offset = "0xE90BD0", VA = "0xE90BD0")]
		internal static int CalculateMipLevels(int width, int height = 0, int depth = 0)
		{
			return 0;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0xE90C7C", Offset = "0xE90C7C", VA = "0xE90C7C")]
		internal static void GetSizeForLevel(int width, int height, int level, out int w, out int h)
		{
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0xE90CE4", Offset = "0xE90CE4", VA = "0xE90CE4")]
		internal static void GetSizeForLevel(int width, int height, int depth, int level, out int w, out int h, out int d)
		{
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0xE90D7C", Offset = "0xE90D7C", VA = "0xE90D7C")]
		internal int GetPitch(int width)
		{
			return 0;
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0xE90E00", Offset = "0xE90E00", VA = "0xE90E00", Slot = "4")]
		protected internal override void GraphicsDeviceResetting()
		{
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0xE90E04", Offset = "0xE90E04", VA = "0xE90E04")]
		protected Texture()
		{
		}

		// Token: 0x04003115 RID: 12565
		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0x18")]
		internal SurfaceFormat _format;

		// Token: 0x04003116 RID: 12566
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x1C")]
		internal int _levelCount;

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _sortingKey;

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x0")]
		private static int _lastSortingKey;
	}
}
