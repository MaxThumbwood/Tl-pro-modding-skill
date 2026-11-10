using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	public class HorizonHelper
	{
		// Token: 0x06005FE7 RID: 24551 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0xA8FBCC", Offset = "0xA8FBCC", VA = "0xA8FBCC")]
		public float GetSunVisibility(RenderTarget2D bigTarget, RenderTarget2D smallTarget)
		{
			return 0f;
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0xA900F8", Offset = "0xA900F8", VA = "0xA900F8")]
		public void DrawSunVisibility()
		{
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0xA90728", Offset = "0xA90728", VA = "0xA90728")]
		private float SampleObstruction(ref Rectangle bounds, ref Point centerTestPosition)
		{
			return 0f;
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0xA908BC", Offset = "0xA908BC", VA = "0xA908BC")]
		private static void Test_DrawSmallTarget(RenderTarget2D bigTarget, RenderTarget2D smallTarget)
		{
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0xA90AFC", Offset = "0xA90AFC", VA = "0xA90AFC")]
		public static void GetCelestialBodyColors(out Color sunColor, out Color moonColor)
		{
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x0002C400 File Offset: 0x0002A600
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0xA90BE0", Offset = "0xA90BE0", VA = "0xA90BE0")]
		private static Color GetMoonColor()
		{
			return default(Color);
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x0002C418 File Offset: 0x0002A618
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0xA90F08", Offset = "0xA90F08", VA = "0xA90F08")]
		public static float GetMoonStrength()
		{
			return 0f;
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0xA91018", Offset = "0xA91018", VA = "0xA91018")]
		public HorizonHelper()
		{
		}

		// Token: 0x04009ED1 RID: 40657
		[Token(Token = "0x4009ED1")]
		[FieldOffset(Offset = "0x8")]
		private Color[] _textureColors;

		// Token: 0x04009ED2 RID: 40658
		[Token(Token = "0x4009ED2")]
		[FieldOffset(Offset = "0x0")]
		private static Color[] MoonColors;
	}
}
