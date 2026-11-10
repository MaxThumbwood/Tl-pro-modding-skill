using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D39 RID: 3385
	[Token(Token = "0x2000D39")]
	public class WiresUI
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x0002DF48 File Offset: 0x0002C148
		[Token(Token = "0x17000AC7")]
		public static bool Open
		{
			[Token(Token = "0x6006461")]
			[Address(RVA = "0xB26D38", Offset = "0xB26D38", VA = "0xB26D38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006462")]
		[Address(RVA = "0xB26DB4", Offset = "0xB26DB4", VA = "0xB26DB4")]
		public static void HandleWiresUI(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006463")]
		[Address(RVA = "0xB26EA0", Offset = "0xB26EA0", VA = "0xB26EA0")]
		public WiresUI()
		{
		}

		// Token: 0x0400A1EC RID: 41452
		[Token(Token = "0x400A1EC")]
		[FieldOffset(Offset = "0x0")]
		private static WiresUI.WiresRadial radial;

		// Token: 0x02000D3A RID: 3386
		[Token(Token = "0x2000D3A")]
		public static class Settings
		{
			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x06006465 RID: 25701 RVA: 0x0002DF60 File Offset: 0x0002C160
			// (set) Token: 0x06006466 RID: 25702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000AC8")]
			public static WiresUI.Settings.MultiToolMode ToolMode
			{
				[Token(Token = "0x6006465")]
				[Address(RVA = "0xB26F40", Offset = "0xB26F40", VA = "0xB26F40")]
				get
				{
					return (WiresUI.Settings.MultiToolMode)0;
				}
				[Token(Token = "0x6006466")]
				[Address(RVA = "0xB26FBC", Offset = "0xB26FBC", VA = "0xB26FBC")]
				set
				{
				}
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x06006467 RID: 25703 RVA: 0x0002DF78 File Offset: 0x0002C178
			[Token(Token = "0x17000AC9")]
			public static bool DrawWires
			{
				[Token(Token = "0x6006467")]
				[Address(RVA = "0xB2703C", Offset = "0xB2703C", VA = "0xB2703C")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x06006468 RID: 25704 RVA: 0x0002DF90 File Offset: 0x0002C190
			[Token(Token = "0x17000ACA")]
			public static bool HideWires
			{
				[Token(Token = "0x6006468")]
				[Address(RVA = "0xB27234", Offset = "0xB27234", VA = "0xB27234")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x06006469 RID: 25705 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
			[Token(Token = "0x17000ACB")]
			public static bool DrawToolModeUI
			{
				[Token(Token = "0x6006469")]
				[Address(RVA = "0xB27338", Offset = "0xB27338", VA = "0xB27338")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x0600646A RID: 25706 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
			// (set) Token: 0x0600646B RID: 25707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000ACC")]
			private static int _lastActuatorEnabled
			{
				[Token(Token = "0x600646A")]
				[Address(RVA = "0xB27498", Offset = "0xB27498", VA = "0xB27498")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600646B")]
				[Address(RVA = "0xB27514", Offset = "0xB27514", VA = "0xB27514")]
				set
				{
				}
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x0600646C RID: 25708 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
			[Token(Token = "0x17000ACD")]
			public static bool DrawToolAllowActuators
			{
				[Token(Token = "0x600646C")]
				[Address(RVA = "0xB27594", Offset = "0xB27594", VA = "0xB27594")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x02000D3B RID: 3387
			[Token(Token = "0x2000D3B")]
			public enum MultiToolMode
			{
				// Token: 0x0400A1EE RID: 41454
				[Token(Token = "0x400A1EE")]
				Red = 1,
				// Token: 0x0400A1EF RID: 41455
				[Token(Token = "0x400A1EF")]
				Green,
				// Token: 0x0400A1F0 RID: 41456
				[Token(Token = "0x400A1F0")]
				Blue = 4,
				// Token: 0x0400A1F1 RID: 41457
				[Token(Token = "0x400A1F1")]
				Yellow = 8,
				// Token: 0x0400A1F2 RID: 41458
				[Token(Token = "0x400A1F2")]
				Actuator = 16,
				// Token: 0x0400A1F3 RID: 41459
				[Token(Token = "0x400A1F3")]
				Cutter = 32
			}
		}

		// Token: 0x02000D3C RID: 3388
		[Token(Token = "0x2000D3C")]
		public class WiresRadial
		{
			// Token: 0x0600646D RID: 25709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600646D")]
			[Address(RVA = "0xB26E68", Offset = "0xB26E68", VA = "0xB26E68")]
			public void Update()
			{
			}

			// Token: 0x0600646E RID: 25710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600646E")]
			[Address(RVA = "0xB27B48", Offset = "0xB27B48", VA = "0xB27B48")]
			private void LineUpdate()
			{
			}

			// Token: 0x0600646F RID: 25711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600646F")]
			[Address(RVA = "0xB277F4", Offset = "0xB277F4", VA = "0xB277F4")]
			private void FlowerUpdate()
			{
			}

			// Token: 0x06006470 RID: 25712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006470")]
			[Address(RVA = "0xB26E80", Offset = "0xB26E80", VA = "0xB26E80")]
			public void Draw(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x06006471 RID: 25713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006471")]
			[Address(RVA = "0xB2A4E8", Offset = "0xB2A4E8", VA = "0xB2A4E8")]
			private void DrawLine(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x06006472 RID: 25714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006472")]
			[Address(RVA = "0xB27E60", Offset = "0xB27E60", VA = "0xB27E60")]
			private void DrawFlower(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x06006473 RID: 25715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006473")]
			[Address(RVA = "0xB296FC", Offset = "0xB296FC", VA = "0xB296FC")]
			private void DrawCursorArea(SpriteBatch spriteBatch)
			{
			}

			// Token: 0x06006474 RID: 25716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006474")]
			[Address(RVA = "0xB26F38", Offset = "0xB26F38", VA = "0xB26F38")]
			public WiresRadial()
			{
			}

			// Token: 0x0400A1F4 RID: 41460
			[Token(Token = "0x400A1F4")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 position;

			// Token: 0x0400A1F5 RID: 41461
			[Token(Token = "0x400A1F5")]
			[FieldOffset(Offset = "0x10")]
			public bool active;

			// Token: 0x0400A1F6 RID: 41462
			[Token(Token = "0x400A1F6")]
			[FieldOffset(Offset = "0x11")]
			public bool OnWiresMenu;

			// Token: 0x0400A1F7 RID: 41463
			[Token(Token = "0x400A1F7")]
			[FieldOffset(Offset = "0x14")]
			private float _lineOpacity;
		}
	}
}
