using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000D24 RID: 3364
	[Token(Token = "0x2000D24")]
	public class ScreenObstruction
	{
		// Token: 0x060063E5 RID: 25573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0xB0A1CC", Offset = "0xB0A1CC", VA = "0xB0A1CC")]
		public static void Update(SceneState sceneState, SceneMetrics metrics)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0xB0A464", Offset = "0xB0A464", VA = "0xB0A464")]
		public static void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xB0AE28", Offset = "0xB0AE28", VA = "0xB0AE28")]
		public ScreenObstruction()
		{
		}

		// Token: 0x0400A0F1 RID: 41201
		[Token(Token = "0x400A0F1")]
		[FieldOffset(Offset = "0x0")]
		public static float lastSpeed;

		// Token: 0x0400A0F2 RID: 41202
		[Token(Token = "0x400A0F2")]
		[FieldOffset(Offset = "0x4")]
		public static float screenObstruction;
	}
}
