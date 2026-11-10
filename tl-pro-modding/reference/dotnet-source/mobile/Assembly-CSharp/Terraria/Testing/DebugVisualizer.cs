using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Testing
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	public class DebugVisualizer
	{
		// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C31")]
		[Address(RVA = "0x1E5638C", Offset = "0x1E5638C", VA = "0x1E5638C")]
		private DebugVisualizer(bool ui)
		{
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C32")]
		[Address(RVA = "0x1E5642C", Offset = "0x1E5642C", VA = "0x1E5642C")]
		public void Add([Optional] Action<SpriteBatch> draw, int lifetime = 1)
		{
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C33")]
		[Address(RVA = "0x1E5661C", Offset = "0x1E5661C", VA = "0x1E5661C")]
		public void AddLine(Vector2 start, Vector2 end, Color colorStart, [Optional] Color colorEnd, int lifetime = 1, float width = 1f)
		{
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C34")]
		[Address(RVA = "0x1E56834", Offset = "0x1E56834", VA = "0x1E56834")]
		public void AddLine(Point start, Point end, Color colorStart, [Optional] Color colorEnd, int lifetime = 1, float width = 1f)
		{
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C35")]
		[Address(RVA = "0x1E56920", Offset = "0x1E56920", VA = "0x1E56920")]
		public void AddRectangle(Rectangle rect, Color color, int lifetime = 1, float width = 1f)
		{
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C36")]
		[Address(RVA = "0x1E56A18", Offset = "0x1E56A18", VA = "0x1E56A18")]
		public void AddRectangle(Vector2 start, Vector2 end, Color colorStart, [Optional] Color colorEnd, int lifetime = 1, float width = 1f)
		{
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C37")]
		[Address(RVA = "0x1E56B6C", Offset = "0x1E56B6C", VA = "0x1E56B6C")]
		public void AddFilledRectangle(Rectangle rect, Color color, int lifetime = 1)
		{
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C38")]
		[Address(RVA = "0x1E56CB0", Offset = "0x1E56CB0", VA = "0x1E56CB0")]
		public static void PreUpdate()
		{
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C39")]
		[Address(RVA = "0x1E56DB0", Offset = "0x1E56DB0", VA = "0x1E56DB0")]
		public static void PreWorldUpdate()
		{
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x1E56E10", Offset = "0x1E56E10", VA = "0x1E56E10")]
		public static void PreDraw()
		{
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3B")]
		[Address(RVA = "0x1E56D10", Offset = "0x1E56D10", VA = "0x1E56D10")]
		private static void SetPhase(DebugVisualizer.UpdatePhase phase)
		{
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3C")]
		[Address(RVA = "0x1E56E70", Offset = "0x1E56E70", VA = "0x1E56E70")]
		public void Tick()
		{
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C3D")]
		[Address(RVA = "0x1E57050", Offset = "0x1E57050", VA = "0x1E57050")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C3E")]
		[Address(RVA = "0x1E576C4", Offset = "0x1E576C4", VA = "0x1E576C4")]
		public static IDisposable InPhase(DebugVisualizer.UpdatePhase phase)
		{
			return null;
		}

		// Token: 0x0400478A RID: 18314
		[Token(Token = "0x400478A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DebugVisualizer UI;

		// Token: 0x0400478B RID: 18315
		[Token(Token = "0x400478B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly DebugVisualizer World;

		// Token: 0x0400478C RID: 18316
		[Token(Token = "0x400478C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DebugVisualizer.UpdatePhase CurrentPhase;

		// Token: 0x0400478D RID: 18317
		[Token(Token = "0x400478D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly List<DebugVisualizer.DrawItem> items;

		// Token: 0x0400478E RID: 18318
		[Token(Token = "0x400478E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly bool _ui;

		// Token: 0x020005E5 RID: 1509
		[Token(Token = "0x20005E5")]
		public enum UpdatePhase
		{
			// Token: 0x04004790 RID: 18320
			[Token(Token = "0x4004790")]
			Update,
			// Token: 0x04004791 RID: 18321
			[Token(Token = "0x4004791")]
			UpdateInWorld,
			// Token: 0x04004792 RID: 18322
			[Token(Token = "0x4004792")]
			Draw
		}

		// Token: 0x020005E6 RID: 1510
		[Token(Token = "0x20005E6")]
		private class DrawItem
		{
			// Token: 0x06003C40 RID: 15424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C40")]
			[Address(RVA = "0x1E56594", Offset = "0x1E56594", VA = "0x1E56594")]
			public DrawItem(Action<SpriteBatch> draw, int lifetime)
			{
			}

			// Token: 0x04004793 RID: 18323
			[Token(Token = "0x4004793")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly DebugVisualizer.UpdatePhase Phase;

			// Token: 0x04004794 RID: 18324
			[Token(Token = "0x4004794")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public readonly Action<SpriteBatch> Draw;

			// Token: 0x04004795 RID: 18325
			[Token(Token = "0x4004795")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int TimeLeft;
		}

		// Token: 0x020005E7 RID: 1511
		[Token(Token = "0x20005E7")]
		private class PhaseOverrideHandle : FileAPI
		{
			// Token: 0x06003C41 RID: 15425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C41")]
			[Address(RVA = "0x1E57798", Offset = "0x1E57798", VA = "0x1E57798")]
			public PhaseOverrideHandle(DebugVisualizer.UpdatePhase phase)
			{
			}

			// Token: 0x06003C42 RID: 15426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C42")]
			[Address(RVA = "0x1E579A8", Offset = "0x1E579A8", VA = "0x1E579A8", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04004796 RID: 18326
			[Token(Token = "0x4004796")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly DebugVisualizer.UpdatePhase _prev;
		}

		// Token: 0x020005E8 RID: 1512
		[Token(Token = "0x20005E8")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003C43 RID: 15427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C43")]
			[Address(RVA = "0x1E5682C", Offset = "0x1E5682C", VA = "0x1E5682C")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06003C44 RID: 15428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x1E57A14", Offset = "0x1E57A14", VA = "0x1E57A14")]
			internal void <AddLine>b__0(SpriteBatch sb)
			{
			}

			// Token: 0x04004797 RID: 18327
			[Token(Token = "0x4004797")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector2 start;

			// Token: 0x04004798 RID: 18328
			[Token(Token = "0x4004798")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 end;

			// Token: 0x04004799 RID: 18329
			[Token(Token = "0x4004799")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Color colorStart;

			// Token: 0x0400479A RID: 18330
			[Token(Token = "0x400479A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Color colorEnd;

			// Token: 0x0400479B RID: 18331
			[Token(Token = "0x400479B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float width;
		}
	}
}
