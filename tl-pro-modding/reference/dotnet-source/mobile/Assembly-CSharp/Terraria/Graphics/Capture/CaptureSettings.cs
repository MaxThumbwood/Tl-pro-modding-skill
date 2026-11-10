using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	public class CaptureSettings
	{
		// Token: 0x06004CFB RID: 19707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFB")]
		[Address(RVA = "0x713BE8", Offset = "0x713BE8", VA = "0x713BE8")]
		public CaptureSettings()
		{
		}

		// Token: 0x040091ED RID: 37357
		[Token(Token = "0x40091ED")]
		[FieldOffset(Offset = "0x8")]
		public Rectangle Area;

		// Token: 0x040091EE RID: 37358
		[Token(Token = "0x40091EE")]
		[FieldOffset(Offset = "0x18")]
		public bool UseScaling;

		// Token: 0x040091EF RID: 37359
		[Token(Token = "0x40091EF")]
		[FieldOffset(Offset = "0x1C")]
		public string OutputName;

		// Token: 0x040091F0 RID: 37360
		[Token(Token = "0x40091F0")]
		[FieldOffset(Offset = "0x20")]
		public bool CaptureEntities;

		// Token: 0x040091F1 RID: 37361
		[Token(Token = "0x40091F1")]
		[FieldOffset(Offset = "0x24")]
		public CaptureBiome Biome;

		// Token: 0x040091F2 RID: 37362
		[Token(Token = "0x40091F2")]
		[FieldOffset(Offset = "0x28")]
		public bool CaptureMech;

		// Token: 0x040091F3 RID: 37363
		[Token(Token = "0x40091F3")]
		[FieldOffset(Offset = "0x29")]
		public bool CaptureBackground;

		// Token: 0x040091F4 RID: 37364
		[Token(Token = "0x40091F4")]
		[FieldOffset(Offset = "0x2A")]
		public bool CameraSpaceEffects;
	}
}
