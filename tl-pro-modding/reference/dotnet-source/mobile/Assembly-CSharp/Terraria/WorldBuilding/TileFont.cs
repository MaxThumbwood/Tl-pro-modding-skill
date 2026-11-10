using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	public class TileFont
	{
		// Token: 0x06003B32 RID: 15154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x1E0C318", Offset = "0x1E0C318", VA = "0x1E0C318")]
		public static void DrawString(Point start, string text, TileFont.DrawMode mode)
		{
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x1E0C480", Offset = "0x1E0C480", VA = "0x1E0C480")]
		private static void DrawChar(Point position, byte[] charData, TileFont.DrawMode mode)
		{
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x0001DD60 File Offset: 0x0001BF60
		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x1E0C778", Offset = "0x1E0C778", VA = "0x1E0C778")]
		public static Point MeasureString(string text)
		{
			return default(Point);
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x1E0C99C", Offset = "0x1E0C99C", VA = "0x1E0C99C")]
		public static void HLineLabel(Point start, int width, string text, TileFont.DrawMode mode, bool rightSideText = false)
		{
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x1E0CBE0", Offset = "0x1E0CBE0", VA = "0x1E0CBE0")]
		public static void VLineLabel(Point start, int height, string text, TileFont.DrawMode mode, bool bottomText = false)
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x1E0CE24", Offset = "0x1E0CE24", VA = "0x1E0CE24")]
		public TileFont()
		{
		}

		// Token: 0x04004700 RID: 18176
		[Token(Token = "0x4004700")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<char, byte[]> MicroFont;

		// Token: 0x020005BA RID: 1466
		[Token(Token = "0x20005BA")]
		public struct DrawMode
		{
			// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B39")]
			[Address(RVA = "0x1E0E5D0", Offset = "0x1E0E5D0", VA = "0x1E0E5D0")]
			public DrawMode(ushort foregroundTile)
			{
			}

			// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003B3A")]
			[Address(RVA = "0x1E0E5E4", Offset = "0x1E0E5E4", VA = "0x1E0E5E4")]
			public DrawMode(ushort foregroundTile, ushort backgroundTile)
			{
			}

			// Token: 0x04004701 RID: 18177
			[Token(Token = "0x4004701")]
			[FieldOffset(Offset = "0x0")]
			public readonly ushort ForegroundTile;

			// Token: 0x04004702 RID: 18178
			[Token(Token = "0x4004702")]
			[FieldOffset(Offset = "0x2")]
			public readonly ushort BackgroundTile;

			// Token: 0x04004703 RID: 18179
			[Token(Token = "0x4004703")]
			[FieldOffset(Offset = "0x4")]
			public readonly bool HasBackground;
		}
	}
}
