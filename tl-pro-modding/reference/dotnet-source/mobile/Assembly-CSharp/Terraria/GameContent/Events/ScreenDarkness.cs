using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D23 RID: 3363
	[Token(Token = "0x2000D23")]
	public class ScreenDarkness
	{
		// Token: 0x060063E0 RID: 25568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0xB0964C", Offset = "0xB0964C", VA = "0xB0964C")]
		public static void Update(SceneState sceneState, SceneMetrics metrics)
		{
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E1")]
		[Address(RVA = "0xB09C64", Offset = "0xB09C64", VA = "0xB09C64")]
		public static void DrawBack(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E2")]
		[Address(RVA = "0xB09EDC", Offset = "0xB09EDC", VA = "0xB09EDC")]
		public static void DrawFront(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E3")]
		[Address(RVA = "0xB0A148", Offset = "0xB0A148", VA = "0xB0A148")]
		public ScreenDarkness()
		{
		}

		// Token: 0x0400A0EF RID: 41199
		[Token(Token = "0x400A0EF")]
		[FieldOffset(Offset = "0x0")]
		public static float screenObstruction;

		// Token: 0x0400A0F0 RID: 41200
		[Token(Token = "0x400A0F0")]
		[FieldOffset(Offset = "0x4")]
		public static Color frontColor;
	}
}
