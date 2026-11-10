using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	// Token: 0x020008F8 RID: 2296
	[Token(Token = "0x20008F8")]
	public interface ILightingEngine
	{
		// Token: 0x06004D2A RID: 19754
		[Token(Token = "0x6004D2A")]
		void Rebuild();

		// Token: 0x06004D2B RID: 19755
		[Token(Token = "0x6004D2B")]
		void AddLight(int x, int y, float r, float g, float b);

		// Token: 0x06004D2C RID: 19756
		[Token(Token = "0x6004D2C")]
		void ProcessArea(Rectangle area);

		// Token: 0x06004D2D RID: 19757
		[Token(Token = "0x6004D2D")]
		Vector3 GetColor(int x, int y);

		// Token: 0x06004D2E RID: 19758
		[Token(Token = "0x6004D2E")]
		void Clear();

		// Token: 0x06004D2F RID: 19759
		[Token(Token = "0x6004D2F")]
		LightMap GetLightMap(out Rectangle lightMapRegion);

		// Token: 0x06004D30 RID: 19760
		[Token(Token = "0x6004D30")]
		Rectangle GetScanRegion();
	}
}
