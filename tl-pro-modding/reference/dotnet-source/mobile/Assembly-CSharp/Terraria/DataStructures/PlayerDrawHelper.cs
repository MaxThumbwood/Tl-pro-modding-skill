using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public class PlayerDrawHelper
	{
		// Token: 0x06004379 RID: 17273 RVA: 0x000207A8 File Offset: 0x0001E9A8
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x54DA24", Offset = "0x54DA24", VA = "0x54DA24")]
		public static int PackShader(int localShaderIndex, PlayerDrawHelper.ShaderConfiguration shaderType)
		{
			return 0;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x54DA30", Offset = "0x54DA30", VA = "0x54DA30")]
		public static void UnpackShader(int packedShaderIndex, out int localShaderIndex, out PlayerDrawHelper.ShaderConfiguration shaderType)
		{
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000207C0 File Offset: 0x0001E9C0
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x54DA58", Offset = "0x54DA58", VA = "0x54DA58")]
		public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd, ref EffectPass effectPass)
		{
			return default(bool);
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000207D8 File Offset: 0x0001E9D8
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x54E9B0", Offset = "0x54E9B0", VA = "0x54E9B0")]
		public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd)
		{
			return default(bool);
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x54F8E0", Offset = "0x54F8E0", VA = "0x54F8E0")]
		public PlayerDrawHelper()
		{
		}

		// Token: 0x04008ABF RID: 35519
		[Token(Token = "0x4008ABF")]
		[FieldOffset(Offset = "0x0")]
		public static Color DISPLAY_DOLL_DEFAULT_SKIN_COLOR;

		// Token: 0x02000785 RID: 1925
		[Token(Token = "0x2000785")]
		public enum ShaderConfiguration
		{
			// Token: 0x04008AC1 RID: 35521
			[Token(Token = "0x4008AC1")]
			ArmorShader,
			// Token: 0x04008AC2 RID: 35522
			[Token(Token = "0x4008AC2")]
			HairShader,
			// Token: 0x04008AC3 RID: 35523
			[Token(Token = "0x4008AC3")]
			TileShader,
			// Token: 0x04008AC4 RID: 35524
			[Token(Token = "0x4008AC4")]
			TilePaintID,
			// Token: 0x04008AC5 RID: 35525
			[Token(Token = "0x4008AC5")]
			Misc
		}
	}
}
