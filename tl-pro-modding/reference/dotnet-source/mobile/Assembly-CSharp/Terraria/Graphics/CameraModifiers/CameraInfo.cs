using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x020008F3 RID: 2291
	[Token(Token = "0x20008F3")]
	public struct CameraInfo
	{
		// Token: 0x06004D05 RID: 19717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x71C1F4", Offset = "0x71C1F4", VA = "0x71C1F4")]
		public CameraInfo(Vector2 position)
		{
		}

		// Token: 0x040091F6 RID: 37366
		[Token(Token = "0x40091F6")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 CameraPosition;

		// Token: 0x040091F7 RID: 37367
		[Token(Token = "0x40091F7")]
		[FieldOffset(Offset = "0x8")]
		public Vector2 OriginalCameraCenter;

		// Token: 0x040091F8 RID: 37368
		[Token(Token = "0x40091F8")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 OriginalCameraPosition;
	}
}
