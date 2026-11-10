using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D33 RID: 3379
	[Token(Token = "0x2000D33")]
	public class UIDust
	{
		// Token: 0x06006446 RID: 25670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006446")]
		[Address(RVA = "0xB23DF0", Offset = "0xB23DF0", VA = "0xB23DF0")]
		public void Clear()
		{
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006447")]
		[Address(RVA = "0xB23EC4", Offset = "0xB23EC4", VA = "0xB23EC4")]
		public Dust NewDustPerfect(Vector2 Position, int Type, [Optional] Vector2? Velocity, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006448")]
		[Address(RVA = "0xB24448", Offset = "0xB24448", VA = "0xB24448")]
		public Dust NewDustDirect(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006449")]
		[Address(RVA = "0xB23FD8", Offset = "0xB23FD8", VA = "0xB23FD8")]
		public Dust NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, [Optional] Color newColor, float Scale = 1f)
		{
			return null;
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644A")]
		[Address(RVA = "0xB245DC", Offset = "0xB245DC", VA = "0xB245DC")]
		public Dust CloneDust(int dustIndex)
		{
			return null;
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644B")]
		[Address(RVA = "0xB2460C", Offset = "0xB2460C", VA = "0xB2460C")]
		public Dust CloneDust(Dust rf)
		{
			return null;
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644C")]
		[Address(RVA = "0xB24808", Offset = "0xB24808", VA = "0xB24808")]
		public void QuickBox(Vector2 topLeft, Vector2 bottomRight, int divisions, Color color, Action<Dust> manipulator)
		{
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644D")]
		[Address(RVA = "0xB24B3C", Offset = "0xB24B3C", VA = "0xB24B3C")]
		public void QuickCircle(Vector2 center, float radius, int divisions, Color color, Action<Dust> manipulator)
		{
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644E")]
		[Address(RVA = "0xB24A04", Offset = "0xB24A04", VA = "0xB24A04")]
		public Dust QuickDust(Vector2 pos, Color color)
		{
			return null;
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600644F")]
		[Address(RVA = "0xB24D60", Offset = "0xB24D60", VA = "0xB24D60")]
		public Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
		{
			return null;
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006450")]
		[Address(RVA = "0xB24E58", Offset = "0xB24E58", VA = "0xB24E58")]
		public void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
		{
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006451")]
		[Address(RVA = "0xB24FC4", Offset = "0xB24FC4", VA = "0xB24FC4")]
		public void UpdateDust()
		{
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006452")]
		[Address(RVA = "0xB25280", Offset = "0xB25280", VA = "0xB25280")]
		internal void DrawDust()
		{
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006453")]
		[Address(RVA = "0xB25780", Offset = "0xB25780", VA = "0xB25780")]
		public UIDust()
		{
		}

		// Token: 0x0400A1C6 RID: 41414
		[Token(Token = "0x400A1C6")]
		public const int maxDust = 400;

		// Token: 0x0400A1C7 RID: 41415
		[Token(Token = "0x400A1C7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Dust[] dust;
	}
}
