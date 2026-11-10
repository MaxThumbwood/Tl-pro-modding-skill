using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000C24 RID: 3108
	[Token(Token = "0x2000C24")]
	public class Actions
	{
		// Token: 0x06005D09 RID: 23817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x9AA9DC", Offset = "0x9AA9DC", VA = "0x9AA9DC")]
		public Actions()
		{
		}

		// Token: 0x02000C25 RID: 3109
		[Token(Token = "0x2000C25")]
		public class Players
		{
			// Token: 0x06005D0A RID: 23818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D0A")]
			[Address(RVA = "0x9AA9E4", Offset = "0x9AA9E4", VA = "0x9AA9E4")]
			public Players()
			{
			}

			// Token: 0x02000C26 RID: 3110
			[Token(Token = "0x2000C26")]
			public interface IPlayerAction : FileAPI
			{
			}

			// Token: 0x02000C27 RID: 3111
			[Token(Token = "0x2000C27")]
			public class Fade : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D0B RID: 23819 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D0B")]
				[Address(RVA = "0x9AA9EC", Offset = "0x9AA9EC", VA = "0x9AA9EC")]
				public Fade(float opacityTarget)
				{
				}

				// Token: 0x06005D0C RID: 23820 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D0C")]
				[Address(RVA = "0x9AAA10", Offset = "0x9AAA10", VA = "0x9AAA10")]
				public Fade(float opacityTarget, int duration)
				{
				}

				// Token: 0x06005D0D RID: 23821 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D0D")]
				[Address(RVA = "0x9AAA34", Offset = "0x9AAA34", VA = "0x9AAA34", Slot = "4")]
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000A51 RID: 2641
				// (get) Token: 0x06005D0E RID: 23822 RVA: 0x0002B860 File Offset: 0x00029A60
				[Token(Token = "0x17000A51")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D0E")]
					[Address(RVA = "0x9AAA38", Offset = "0x9AAA38", VA = "0x9AAA38", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D0F RID: 23823 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D0F")]
				[Address(RVA = "0x9AAA40", Offset = "0x9AAA40", VA = "0x9AAA40", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D10 RID: 23824 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D10")]
				[Address(RVA = "0x9AAA48", Offset = "0x9AAA48", VA = "0x9AAA48", Slot = "6")]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D47 RID: 40263
				[Token(Token = "0x4009D47")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D48 RID: 40264
				[Token(Token = "0x4009D48")]
				[FieldOffset(Offset = "0xC")]
				private float _opacityTarget;

				// Token: 0x04009D49 RID: 40265
				[Token(Token = "0x4009D49")]
				[FieldOffset(Offset = "0x10")]
				private float _delay;
			}

			// Token: 0x02000C28 RID: 3112
			[Token(Token = "0x2000C28")]
			public class Wait : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D11 RID: 23825 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D11")]
				[Address(RVA = "0x9AAB64", Offset = "0x9AAB64", VA = "0x9AAB64")]
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x06005D12 RID: 23826 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D12")]
				[Address(RVA = "0x9AAB80", Offset = "0x9AAB80", VA = "0x9AAB80", Slot = "4")]
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000A52 RID: 2642
				// (get) Token: 0x06005D13 RID: 23827 RVA: 0x0002B878 File Offset: 0x00029A78
				[Token(Token = "0x17000A52")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D13")]
					[Address(RVA = "0x9AAB84", Offset = "0x9AAB84", VA = "0x9AAB84", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D14 RID: 23828 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D14")]
				[Address(RVA = "0x9AAB8C", Offset = "0x9AAB8C", VA = "0x9AAB8C", Slot = "6")]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D15 RID: 23829 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D15")]
				[Address(RVA = "0x9AAC6C", Offset = "0x9AAC6C", VA = "0x9AAC6C", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D4A RID: 40266
				[Token(Token = "0x4009D4A")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D4B RID: 40267
				[Token(Token = "0x4009D4B")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C29 RID: 3113
			[Token(Token = "0x2000C29")]
			public class LookAt : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D16 RID: 23830 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D16")]
				[Address(RVA = "0x9AAC74", Offset = "0x9AAC74", VA = "0x9AAC74")]
				public LookAt(int direction)
				{
				}

				// Token: 0x06005D17 RID: 23831 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D17")]
				[Address(RVA = "0x9AAC90", Offset = "0x9AAC90", VA = "0x9AAC90", Slot = "4")]
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000A53 RID: 2643
				// (get) Token: 0x06005D18 RID: 23832 RVA: 0x0002B890 File Offset: 0x00029A90
				[Token(Token = "0x17000A53")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D18")]
					[Address(RVA = "0x9AAC94", Offset = "0x9AAC94", VA = "0x9AAC94", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D19 RID: 23833 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D19")]
				[Address(RVA = "0x9AAC9C", Offset = "0x9AAC9C", VA = "0x9AAC9C", Slot = "6")]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D1A RID: 23834 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D1A")]
				[Address(RVA = "0x9AACD8", Offset = "0x9AACD8", VA = "0x9AACD8", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D4C RID: 40268
				[Token(Token = "0x4009D4C")]
				[FieldOffset(Offset = "0x8")]
				private int _direction;

				// Token: 0x04009D4D RID: 40269
				[Token(Token = "0x4009D4D")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C2A RID: 3114
			[Token(Token = "0x2000C2A")]
			public class MoveWithAcceleration : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D1B RID: 23835 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D1B")]
				[Address(RVA = "0x9AACE0", Offset = "0x9AACE0", VA = "0x9AACE0")]
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
				}

				// Token: 0x06005D1C RID: 23836 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D1C")]
				[Address(RVA = "0x9AAD1C", Offset = "0x9AAD1C", VA = "0x9AAD1C", Slot = "4")]
				public void BindTo(Player obj)
				{
				}

				// Token: 0x17000A54 RID: 2644
				// (get) Token: 0x06005D1D RID: 23837 RVA: 0x0002B8A8 File Offset: 0x00029AA8
				[Token(Token = "0x17000A54")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D1D")]
					[Address(RVA = "0x9AAD20", Offset = "0x9AAD20", VA = "0x9AAD20", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D1E RID: 23838 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D1E")]
				[Address(RVA = "0x9AAD28", Offset = "0x9AAD28", VA = "0x9AAD28", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D1F RID: 23839 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D1F")]
				[Address(RVA = "0x9AAD30", Offset = "0x9AAD30", VA = "0x9AAD30", Slot = "6")]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D4E RID: 40270
				[Token(Token = "0x4009D4E")]
				[FieldOffset(Offset = "0x8")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009D4F RID: 40271
				[Token(Token = "0x4009D4F")]
				[FieldOffset(Offset = "0x10")]
				private Vector2 _accelerationPerFrame;

				// Token: 0x04009D50 RID: 40272
				[Token(Token = "0x4009D50")]
				[FieldOffset(Offset = "0x18")]
				private int _duration;

				// Token: 0x04009D51 RID: 40273
				[Token(Token = "0x4009D51")]
				[FieldOffset(Offset = "0x1C")]
				private float _delay;
			}
		}

		// Token: 0x02000C2B RID: 3115
		[Token(Token = "0x2000C2B")]
		public class NPCs
		{
			// Token: 0x06005D20 RID: 23840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D20")]
			[Address(RVA = "0x9AAF10", Offset = "0x9AAF10", VA = "0x9AAF10")]
			public NPCs()
			{
			}

			// Token: 0x02000C2C RID: 3116
			[Token(Token = "0x2000C2C")]
			public interface INPCAction : FileAPI
			{
			}

			// Token: 0x02000C2D RID: 3117
			[Token(Token = "0x2000C2D")]
			public class Fade : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D21 RID: 23841 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D21")]
				[Address(RVA = "0x9AAF18", Offset = "0x9AAF18", VA = "0x9AAF18")]
				public Fade(int alphaPerFrame)
				{
				}

				// Token: 0x06005D22 RID: 23842 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D22")]
				[Address(RVA = "0x9AAF3C", Offset = "0x9AAF3C", VA = "0x9AAF3C")]
				public Fade(int alphaPerFrame, int duration)
				{
				}

				// Token: 0x06005D23 RID: 23843 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D23")]
				[Address(RVA = "0x9AAF60", Offset = "0x9AAF60", VA = "0x9AAF60", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A55 RID: 2645
				// (get) Token: 0x06005D24 RID: 23844 RVA: 0x0002B8C0 File Offset: 0x00029AC0
				[Token(Token = "0x17000A55")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D24")]
					[Address(RVA = "0x9AAF64", Offset = "0x9AAF64", VA = "0x9AAF64", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D25 RID: 23845 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D25")]
				[Address(RVA = "0x9AAF6C", Offset = "0x9AAF6C", VA = "0x9AAF6C", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D26 RID: 23846 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D26")]
				[Address(RVA = "0x9AAF74", Offset = "0x9AAF74", VA = "0x9AAF74", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D52 RID: 40274
				[Token(Token = "0x4009D52")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D53 RID: 40275
				[Token(Token = "0x4009D53")]
				[FieldOffset(Offset = "0xC")]
				private int _alphaPerFrame;

				// Token: 0x04009D54 RID: 40276
				[Token(Token = "0x4009D54")]
				[FieldOffset(Offset = "0x10")]
				private float _delay;
			}

			// Token: 0x02000C2E RID: 3118
			[Token(Token = "0x2000C2E")]
			public class ShowItem : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D27 RID: 23847 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D27")]
				[Address(RVA = "0x9AB0B4", Offset = "0x9AB0B4", VA = "0x9AB0B4")]
				public ShowItem(int durationInFrames, int itemIdToShow)
				{
				}

				// Token: 0x06005D28 RID: 23848 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D28")]
				[Address(RVA = "0x9AB0D8", Offset = "0x9AB0D8", VA = "0x9AB0D8", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A56 RID: 2646
				// (get) Token: 0x06005D29 RID: 23849 RVA: 0x0002B8D8 File Offset: 0x00029AD8
				[Token(Token = "0x17000A56")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D29")]
					[Address(RVA = "0x9AB0DC", Offset = "0x9AB0DC", VA = "0x9AB0DC", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D2A RID: 23850 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D2A")]
				[Address(RVA = "0x9AB0E4", Offset = "0x9AB0E4", VA = "0x9AB0E4", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D2B RID: 23851 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D2B")]
				[Address(RVA = "0x9AB0EC", Offset = "0x9AB0EC", VA = "0x9AB0EC", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D2C RID: 23852 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D2C")]
				[Address(RVA = "0x9AB31C", Offset = "0x9AB31C", VA = "0x9AB31C")]
				private void FixNPCIfWasHoldingItem(NPC obj)
				{
				}

				// Token: 0x04009D55 RID: 40277
				[Token(Token = "0x4009D55")]
				[FieldOffset(Offset = "0x8")]
				private int _itemIdToShow;

				// Token: 0x04009D56 RID: 40278
				[Token(Token = "0x4009D56")]
				[FieldOffset(Offset = "0xC")]
				private int _duration;

				// Token: 0x04009D57 RID: 40279
				[Token(Token = "0x4009D57")]
				[FieldOffset(Offset = "0x10")]
				private float _delay;
			}

			// Token: 0x02000C2F RID: 3119
			[Token(Token = "0x2000C2F")]
			public class Move : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D2D RID: 23853 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D2D")]
				[Address(RVA = "0x9AB3BC", Offset = "0x9AB3BC", VA = "0x9AB3BC")]
				public Move(Vector2 offsetPerFrame, int durationInFrames)
				{
				}

				// Token: 0x06005D2E RID: 23854 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D2E")]
				[Address(RVA = "0x9AB3E8", Offset = "0x9AB3E8", VA = "0x9AB3E8", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A57 RID: 2647
				// (get) Token: 0x06005D2F RID: 23855 RVA: 0x0002B8F0 File Offset: 0x00029AF0
				[Token(Token = "0x17000A57")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D2F")]
					[Address(RVA = "0x9AB3EC", Offset = "0x9AB3EC", VA = "0x9AB3EC", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D30 RID: 23856 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D30")]
				[Address(RVA = "0x9AB3F4", Offset = "0x9AB3F4", VA = "0x9AB3F4", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D31 RID: 23857 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D31")]
				[Address(RVA = "0x9AB3FC", Offset = "0x9AB3FC", VA = "0x9AB3FC", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D58 RID: 40280
				[Token(Token = "0x4009D58")]
				[FieldOffset(Offset = "0x8")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009D59 RID: 40281
				[Token(Token = "0x4009D59")]
				[FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009D5A RID: 40282
				[Token(Token = "0x4009D5A")]
				[FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000C30 RID: 3120
			[Token(Token = "0x2000C30")]
			public class MoveWithAcceleration : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D32 RID: 23858 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D32")]
				[Address(RVA = "0x9AB53C", Offset = "0x9AB53C", VA = "0x9AB53C")]
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
				}

				// Token: 0x06005D33 RID: 23859 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D33")]
				[Address(RVA = "0x9AB578", Offset = "0x9AB578", VA = "0x9AB578", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A58 RID: 2648
				// (get) Token: 0x06005D34 RID: 23860 RVA: 0x0002B908 File Offset: 0x00029B08
				[Token(Token = "0x17000A58")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D34")]
					[Address(RVA = "0x9AB57C", Offset = "0x9AB57C", VA = "0x9AB57C", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D35 RID: 23861 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D35")]
				[Address(RVA = "0x9AB584", Offset = "0x9AB584", VA = "0x9AB584", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D36 RID: 23862 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D36")]
				[Address(RVA = "0x9AB58C", Offset = "0x9AB58C", VA = "0x9AB58C", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D5B RID: 40283
				[Token(Token = "0x4009D5B")]
				[FieldOffset(Offset = "0x8")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009D5C RID: 40284
				[Token(Token = "0x4009D5C")]
				[FieldOffset(Offset = "0x10")]
				private Vector2 _accelerationPerFrame;

				// Token: 0x04009D5D RID: 40285
				[Token(Token = "0x4009D5D")]
				[FieldOffset(Offset = "0x18")]
				private int _duration;

				// Token: 0x04009D5E RID: 40286
				[Token(Token = "0x4009D5E")]
				[FieldOffset(Offset = "0x1C")]
				private float _delay;
			}

			// Token: 0x02000C31 RID: 3121
			[Token(Token = "0x2000C31")]
			public class MoveWithRotor : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D37 RID: 23863 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D37")]
				[Address(RVA = "0x9AB770", Offset = "0x9AB770", VA = "0x9AB770")]
				public MoveWithRotor(Vector2 radialOffset, float rotationPerFrame, Vector2 resultMultiplier, int durationInFrames)
				{
				}

				// Token: 0x06005D38 RID: 23864 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D38")]
				[Address(RVA = "0x9AB7B4", Offset = "0x9AB7B4", VA = "0x9AB7B4", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A59 RID: 2649
				// (get) Token: 0x06005D39 RID: 23865 RVA: 0x0002B920 File Offset: 0x00029B20
				[Token(Token = "0x17000A59")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D39")]
					[Address(RVA = "0x9AB7B8", Offset = "0x9AB7B8", VA = "0x9AB7B8", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D3A RID: 23866 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D3A")]
				[Address(RVA = "0x9AB7C0", Offset = "0x9AB7C0", VA = "0x9AB7C0", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D3B RID: 23867 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D3B")]
				[Address(RVA = "0x9AB7C8", Offset = "0x9AB7C8", VA = "0x9AB7C8", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D5F RID: 40287
				[Token(Token = "0x4009D5F")]
				[FieldOffset(Offset = "0x8")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009D60 RID: 40288
				[Token(Token = "0x4009D60")]
				[FieldOffset(Offset = "0x10")]
				private Vector2 _resultMultiplier;

				// Token: 0x04009D61 RID: 40289
				[Token(Token = "0x4009D61")]
				[FieldOffset(Offset = "0x18")]
				private float _radialOffset;

				// Token: 0x04009D62 RID: 40290
				[Token(Token = "0x4009D62")]
				[FieldOffset(Offset = "0x1C")]
				private int _duration;

				// Token: 0x04009D63 RID: 40291
				[Token(Token = "0x4009D63")]
				[FieldOffset(Offset = "0x20")]
				private float _delay;
			}

			// Token: 0x02000C32 RID: 3122
			[Token(Token = "0x2000C32")]
			public class DoBunnyRestAnimation : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D3C RID: 23868 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D3C")]
				[Address(RVA = "0x9AB944", Offset = "0x9AB944", VA = "0x9AB944")]
				public DoBunnyRestAnimation(int durationInFrames)
				{
				}

				// Token: 0x06005D3D RID: 23869 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D3D")]
				[Address(RVA = "0x9AB960", Offset = "0x9AB960", VA = "0x9AB960", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5A RID: 2650
				// (get) Token: 0x06005D3E RID: 23870 RVA: 0x0002B938 File Offset: 0x00029B38
				[Token(Token = "0x17000A5A")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D3E")]
					[Address(RVA = "0x9AB964", Offset = "0x9AB964", VA = "0x9AB964", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D3F RID: 23871 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D3F")]
				[Address(RVA = "0x9AB96C", Offset = "0x9AB96C", VA = "0x9AB96C", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D40 RID: 23872 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D40")]
				[Address(RVA = "0x9AB974", Offset = "0x9AB974", VA = "0x9AB974", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D64 RID: 40292
				[Token(Token = "0x4009D64")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D65 RID: 40293
				[Token(Token = "0x4009D65")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C33 RID: 3123
			[Token(Token = "0x2000C33")]
			public class Wait : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D41 RID: 23873 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D41")]
				[Address(RVA = "0x9ABA88", Offset = "0x9ABA88", VA = "0x9ABA88")]
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x06005D42 RID: 23874 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D42")]
				[Address(RVA = "0x9ABAA4", Offset = "0x9ABAA4", VA = "0x9ABAA4", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5B RID: 2651
				// (get) Token: 0x06005D43 RID: 23875 RVA: 0x0002B950 File Offset: 0x00029B50
				[Token(Token = "0x17000A5B")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D43")]
					[Address(RVA = "0x9ABAA8", Offset = "0x9ABAA8", VA = "0x9ABAA8", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D44 RID: 23876 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D44")]
				[Address(RVA = "0x9ABAB0", Offset = "0x9ABAB0", VA = "0x9ABAB0", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D45 RID: 23877 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D45")]
				[Address(RVA = "0x9ABB90", Offset = "0x9ABB90", VA = "0x9ABB90", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D66 RID: 40294
				[Token(Token = "0x4009D66")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D67 RID: 40295
				[Token(Token = "0x4009D67")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C34 RID: 3124
			[Token(Token = "0x2000C34")]
			public class Blink : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D46 RID: 23878 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D46")]
				[Address(RVA = "0x9ABB98", Offset = "0x9ABB98", VA = "0x9ABB98")]
				public Blink(int durationInFrames)
				{
				}

				// Token: 0x06005D47 RID: 23879 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D47")]
				[Address(RVA = "0x9ABBB4", Offset = "0x9ABBB4", VA = "0x9ABBB4", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5C RID: 2652
				// (get) Token: 0x06005D48 RID: 23880 RVA: 0x0002B968 File Offset: 0x00029B68
				[Token(Token = "0x17000A5C")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D48")]
					[Address(RVA = "0x9ABBB8", Offset = "0x9ABBB8", VA = "0x9ABBB8", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D49 RID: 23881 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D49")]
				[Address(RVA = "0x9ABBC0", Offset = "0x9ABBC0", VA = "0x9ABBC0", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D4A RID: 23882 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D4A")]
				[Address(RVA = "0x9ABD08", Offset = "0x9ABD08", VA = "0x9ABD08", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D68 RID: 40296
				[Token(Token = "0x4009D68")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D69 RID: 40297
				[Token(Token = "0x4009D69")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C35 RID: 3125
			[Token(Token = "0x2000C35")]
			public class LookAt : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D4B RID: 23883 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D4B")]
				[Address(RVA = "0x9ABD10", Offset = "0x9ABD10", VA = "0x9ABD10")]
				public LookAt(int direction)
				{
				}

				// Token: 0x06005D4C RID: 23884 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D4C")]
				[Address(RVA = "0x9ABD2C", Offset = "0x9ABD2C", VA = "0x9ABD2C", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5D RID: 2653
				// (get) Token: 0x06005D4D RID: 23885 RVA: 0x0002B980 File Offset: 0x00029B80
				[Token(Token = "0x17000A5D")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D4D")]
					[Address(RVA = "0x9ABD30", Offset = "0x9ABD30", VA = "0x9ABD30", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D4E RID: 23886 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D4E")]
				[Address(RVA = "0x9ABD38", Offset = "0x9ABD38", VA = "0x9ABD38", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D4F RID: 23887 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D4F")]
				[Address(RVA = "0x9ABD84", Offset = "0x9ABD84", VA = "0x9ABD84", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D6A RID: 40298
				[Token(Token = "0x4009D6A")]
				[FieldOffset(Offset = "0x8")]
				private int _direction;

				// Token: 0x04009D6B RID: 40299
				[Token(Token = "0x4009D6B")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C36 RID: 3126
			[Token(Token = "0x2000C36")]
			public class PartyHard : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D50 RID: 23888 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D50")]
				[Address(RVA = "0x9ABD8C", Offset = "0x9ABD8C", VA = "0x9ABD8C")]
				public PartyHard()
				{
				}

				// Token: 0x06005D51 RID: 23889 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D51")]
				[Address(RVA = "0x9ABD94", Offset = "0x9ABD94", VA = "0x9ABD94", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5E RID: 2654
				// (get) Token: 0x06005D52 RID: 23890 RVA: 0x0002B998 File Offset: 0x00029B98
				[Token(Token = "0x17000A5E")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D52")]
					[Address(RVA = "0x9ABDD4", Offset = "0x9ABDD4", VA = "0x9ABDD4", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D53 RID: 23891 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D53")]
				[Address(RVA = "0x9ABDDC", Offset = "0x9ABDDC", VA = "0x9ABDDC", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D54 RID: 23892 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D54")]
				[Address(RVA = "0x9ABDE0", Offset = "0x9ABDE0", VA = "0x9ABDE0", Slot = "7")]
				public void SetDelay(float delay)
				{
				}
			}

			// Token: 0x02000C37 RID: 3127
			[Token(Token = "0x2000C37")]
			public class ForceAltTexture : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D55 RID: 23893 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D55")]
				[Address(RVA = "0x9ABDE4", Offset = "0x9ABDE4", VA = "0x9ABDE4")]
				public ForceAltTexture(int altTexture)
				{
				}

				// Token: 0x06005D56 RID: 23894 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D56")]
				[Address(RVA = "0x9ABE00", Offset = "0x9ABE00", VA = "0x9ABE00", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A5F RID: 2655
				// (get) Token: 0x06005D57 RID: 23895 RVA: 0x0002B9B0 File Offset: 0x00029BB0
				[Token(Token = "0x17000A5F")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D57")]
					[Address(RVA = "0x9ABE28", Offset = "0x9ABE28", VA = "0x9ABE28", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D58 RID: 23896 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D58")]
				[Address(RVA = "0x9ABE30", Offset = "0x9ABE30", VA = "0x9ABE30", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D59 RID: 23897 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D59")]
				[Address(RVA = "0x9ABE34", Offset = "0x9ABE34", VA = "0x9ABE34", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D6C RID: 40300
				[Token(Token = "0x4009D6C")]
				[FieldOffset(Offset = "0x8")]
				private int _altTexture;
			}

			// Token: 0x02000C38 RID: 3128
			[Token(Token = "0x2000C38")]
			public class Variant : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D5A RID: 23898 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D5A")]
				[Address(RVA = "0x9ABE38", Offset = "0x9ABE38", VA = "0x9ABE38")]
				public Variant(int variant)
				{
				}

				// Token: 0x06005D5B RID: 23899 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D5B")]
				[Address(RVA = "0x9ABE54", Offset = "0x9ABE54", VA = "0x9ABE54", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A60 RID: 2656
				// (get) Token: 0x06005D5C RID: 23900 RVA: 0x0002B9C8 File Offset: 0x00029BC8
				[Token(Token = "0x17000A60")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D5C")]
					[Address(RVA = "0x9ABE7C", Offset = "0x9ABE7C", VA = "0x9ABE7C", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D5D RID: 23901 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D5D")]
				[Address(RVA = "0x9ABE84", Offset = "0x9ABE84", VA = "0x9ABE84", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D5E RID: 23902 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D5E")]
				[Address(RVA = "0x9ABE88", Offset = "0x9ABE88", VA = "0x9ABE88", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D6D RID: 40301
				[Token(Token = "0x4009D6D")]
				[FieldOffset(Offset = "0x8")]
				private int _variant;
			}

			// Token: 0x02000C39 RID: 3129
			[Token(Token = "0x2000C39")]
			public class ZombieKnockOnDoor : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D5F RID: 23903 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D5F")]
				[Address(RVA = "0x9ABE8C", Offset = "0x9ABE8C", VA = "0x9ABE8C")]
				public ZombieKnockOnDoor(int durationInFrames)
				{
				}

				// Token: 0x06005D60 RID: 23904 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D60")]
				[Address(RVA = "0x9ABF10", Offset = "0x9ABF10", VA = "0x9ABF10", Slot = "4")]
				public void BindTo(NPC obj)
				{
				}

				// Token: 0x17000A61 RID: 2657
				// (get) Token: 0x06005D61 RID: 23905 RVA: 0x0002B9E0 File Offset: 0x00029BE0
				[Token(Token = "0x17000A61")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D61")]
					[Address(RVA = "0x9ABF14", Offset = "0x9ABF14", VA = "0x9ABF14", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D62 RID: 23906 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D62")]
				[Address(RVA = "0x9ABF1C", Offset = "0x9ABF1C", VA = "0x9ABF1C", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D63 RID: 23907 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D63")]
				[Address(RVA = "0x9ABF24", Offset = "0x9ABF24", VA = "0x9ABF24", Slot = "6")]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D6E RID: 40302
				[Token(Token = "0x4009D6E")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D6F RID: 40303
				[Token(Token = "0x4009D6F")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;

				// Token: 0x04009D70 RID: 40304
				[Token(Token = "0x4009D70")]
				[FieldOffset(Offset = "0x10")]
				private Vector2 bumpOffset;

				// Token: 0x04009D71 RID: 40305
				[Token(Token = "0x4009D71")]
				[FieldOffset(Offset = "0x18")]
				private Vector2 bumpVelocity;
			}
		}

		// Token: 0x02000C3A RID: 3130
		[Token(Token = "0x2000C3A")]
		public class Sprites
		{
			// Token: 0x06005D64 RID: 23908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005D64")]
			[Address(RVA = "0x9AC104", Offset = "0x9AC104", VA = "0x9AC104")]
			public Sprites()
			{
			}

			// Token: 0x02000C3B RID: 3131
			[Token(Token = "0x2000C3B")]
			public interface ISpriteAction : FileAPI
			{
			}

			// Token: 0x02000C3C RID: 3132
			[Token(Token = "0x2000C3C")]
			public class Fade : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D65 RID: 23909 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D65")]
				[Address(RVA = "0x9AC10C", Offset = "0x9AC10C", VA = "0x9AC10C")]
				public Fade(float opacityTarget)
				{
				}

				// Token: 0x06005D66 RID: 23910 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D66")]
				[Address(RVA = "0x9AC130", Offset = "0x9AC130", VA = "0x9AC130")]
				public Fade(float opacityTarget, int duration)
				{
				}

				// Token: 0x06005D67 RID: 23911 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D67")]
				[Address(RVA = "0x9AC154", Offset = "0x9AC154", VA = "0x9AC154", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A62 RID: 2658
				// (get) Token: 0x06005D68 RID: 23912 RVA: 0x0002B9F8 File Offset: 0x00029BF8
				[Token(Token = "0x17000A62")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D68")]
					[Address(RVA = "0x9AC158", Offset = "0x9AC158", VA = "0x9AC158", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D69 RID: 23913 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D69")]
				[Address(RVA = "0x9AC160", Offset = "0x9AC160", VA = "0x9AC160", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D6A RID: 23914 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D6A")]
				[Address(RVA = "0x9AC168", Offset = "0x9AC168", VA = "0x9AC168", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D72 RID: 40306
				[Token(Token = "0x4009D72")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D73 RID: 40307
				[Token(Token = "0x4009D73")]
				[FieldOffset(Offset = "0xC")]
				private float _opacityTarget;

				// Token: 0x04009D74 RID: 40308
				[Token(Token = "0x4009D74")]
				[FieldOffset(Offset = "0x10")]
				private float _delay;
			}

			// Token: 0x02000C3D RID: 3133
			[Token(Token = "0x2000C3D")]
			public abstract class AScale : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D6B RID: 23915 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D6B")]
				[Address(RVA = "0x9AC27C", Offset = "0x9AC27C", VA = "0x9AC27C")]
				public AScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x06005D6C RID: 23916 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D6C")]
				[Address(RVA = "0x9AC2A8", Offset = "0x9AC2A8", VA = "0x9AC2A8")]
				public AScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x06005D6D RID: 23917 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D6D")]
				[Address(RVA = "0x9AC2D4", Offset = "0x9AC2D4", VA = "0x9AC2D4", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A63 RID: 2659
				// (get) Token: 0x06005D6E RID: 23918 RVA: 0x0002BA10 File Offset: 0x00029C10
				[Token(Token = "0x17000A63")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D6E")]
					[Address(RVA = "0x9AC2D8", Offset = "0x9AC2D8", VA = "0x9AC2D8", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D6F RID: 23919 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D6F")]
				[Address(RVA = "0x9AC2E0", Offset = "0x9AC2E0", VA = "0x9AC2E0", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D70 RID: 23920 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D70")]
				[Address(RVA = "0x9AC2E8", Offset = "0x9AC2E8", VA = "0x9AC2E8", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D71 RID: 23921
				[Token(Token = "0x6005D71")]
				protected abstract float GetProgress(float durationInFramesToApply);

				// Token: 0x04009D75 RID: 40309
				[Token(Token = "0x4009D75")]
				[FieldOffset(Offset = "0x8")]
				protected int Duration;

				// Token: 0x04009D76 RID: 40310
				[Token(Token = "0x4009D76")]
				[FieldOffset(Offset = "0xC")]
				private Vector2 _scaleTarget;

				// Token: 0x04009D77 RID: 40311
				[Token(Token = "0x4009D77")]
				[FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000C3E RID: 3134
			[Token(Token = "0x2000C3E")]
			public class LinearScale : Actions.Sprites.AScale
			{
				// Token: 0x06005D72 RID: 23922 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D72")]
				[Address(RVA = "0x9AC41C", Offset = "0x9AC41C", VA = "0x9AC41C")]
				public LinearScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x06005D73 RID: 23923 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D73")]
				[Address(RVA = "0x9AC448", Offset = "0x9AC448", VA = "0x9AC448")]
				public LinearScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x06005D74 RID: 23924 RVA: 0x0002BA28 File Offset: 0x00029C28
				[Token(Token = "0x6005D74")]
				[Address(RVA = "0x9AC474", Offset = "0x9AC474", VA = "0x9AC474", Slot = "8")]
				protected override float GetProgress(float durationInFramesToApply)
				{
					return 0f;
				}
			}

			// Token: 0x02000C3F RID: 3135
			[Token(Token = "0x2000C3F")]
			public class OutCircleScale : Actions.Sprites.AScale
			{
				// Token: 0x06005D75 RID: 23925 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D75")]
				[Address(RVA = "0x9AC504", Offset = "0x9AC504", VA = "0x9AC504")]
				public OutCircleScale(Vector2 scaleTarget)
				{
				}

				// Token: 0x06005D76 RID: 23926 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D76")]
				[Address(RVA = "0x9AC530", Offset = "0x9AC530", VA = "0x9AC530")]
				public OutCircleScale(Vector2 scaleTarget, int duration)
				{
				}

				// Token: 0x06005D77 RID: 23927 RVA: 0x0002BA40 File Offset: 0x00029C40
				[Token(Token = "0x6005D77")]
				[Address(RVA = "0x9AC55C", Offset = "0x9AC55C", VA = "0x9AC55C", Slot = "8")]
				protected override float GetProgress(float durationInFramesToApply)
				{
					return 0f;
				}
			}

			// Token: 0x02000C40 RID: 3136
			[Token(Token = "0x2000C40")]
			public class Wait : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D78 RID: 23928 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D78")]
				[Address(RVA = "0x9AC640", Offset = "0x9AC640", VA = "0x9AC640")]
				public Wait(int durationInFrames)
				{
				}

				// Token: 0x06005D79 RID: 23929 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D79")]
				[Address(RVA = "0x9AC65C", Offset = "0x9AC65C", VA = "0x9AC65C", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A64 RID: 2660
				// (get) Token: 0x06005D7A RID: 23930 RVA: 0x0002BA58 File Offset: 0x00029C58
				[Token(Token = "0x17000A64")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D7A")]
					[Address(RVA = "0x9AC660", Offset = "0x9AC660", VA = "0x9AC660", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D7B RID: 23931 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D7B")]
				[Address(RVA = "0x9AC668", Offset = "0x9AC668", VA = "0x9AC668", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x06005D7C RID: 23932 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D7C")]
				[Address(RVA = "0x9AC66C", Offset = "0x9AC66C", VA = "0x9AC66C", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x04009D78 RID: 40312
				[Token(Token = "0x4009D78")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D79 RID: 40313
				[Token(Token = "0x4009D79")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;
			}

			// Token: 0x02000C41 RID: 3137
			[Token(Token = "0x2000C41")]
			public class SimulateGravity : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D7D RID: 23933 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D7D")]
				[Address(RVA = "0x9AC674", Offset = "0x9AC674", VA = "0x9AC674")]
				public SimulateGravity(Vector2 initialVelocity, Vector2 gravityPerFrame, float rotationPerFrame, int duration)
				{
				}

				// Token: 0x06005D7E RID: 23934 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D7E")]
				[Address(RVA = "0x9AC6B8", Offset = "0x9AC6B8", VA = "0x9AC6B8", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A65 RID: 2661
				// (get) Token: 0x06005D7F RID: 23935 RVA: 0x0002BA70 File Offset: 0x00029C70
				[Token(Token = "0x17000A65")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D7F")]
					[Address(RVA = "0x9AC6BC", Offset = "0x9AC6BC", VA = "0x9AC6BC", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D80 RID: 23936 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D80")]
				[Address(RVA = "0x9AC6C4", Offset = "0x9AC6C4", VA = "0x9AC6C4", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D81 RID: 23937 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D81")]
				[Address(RVA = "0x9AC6CC", Offset = "0x9AC6CC", VA = "0x9AC6CC", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D7A RID: 40314
				[Token(Token = "0x4009D7A")]
				[FieldOffset(Offset = "0x8")]
				private int _duration;

				// Token: 0x04009D7B RID: 40315
				[Token(Token = "0x4009D7B")]
				[FieldOffset(Offset = "0xC")]
				private float _delay;

				// Token: 0x04009D7C RID: 40316
				[Token(Token = "0x4009D7C")]
				[FieldOffset(Offset = "0x10")]
				private Vector2 _initialVelocity;

				// Token: 0x04009D7D RID: 40317
				[Token(Token = "0x4009D7D")]
				[FieldOffset(Offset = "0x18")]
				private Vector2 _gravityPerFrame;

				// Token: 0x04009D7E RID: 40318
				[Token(Token = "0x4009D7E")]
				[FieldOffset(Offset = "0x20")]
				private float _rotationPerFrame;
			}

			// Token: 0x02000C42 RID: 3138
			[Token(Token = "0x2000C42")]
			public class SetFrame : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D82 RID: 23938 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D82")]
				[Address(RVA = "0x9AC824", Offset = "0x9AC824", VA = "0x9AC824")]
				public SetFrame(int frameX, int frameY, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x06005D83 RID: 23939 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D83")]
				[Address(RVA = "0x9AC858", Offset = "0x9AC858", VA = "0x9AC858", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A66 RID: 2662
				// (get) Token: 0x06005D84 RID: 23940 RVA: 0x0002BA88 File Offset: 0x00029C88
				[Token(Token = "0x17000A66")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D84")]
					[Address(RVA = "0x9AC85C", Offset = "0x9AC85C", VA = "0x9AC85C", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D85 RID: 23941 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D85")]
				[Address(RVA = "0x9AC864", Offset = "0x9AC864", VA = "0x9AC864", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D86 RID: 23942 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D86")]
				[Address(RVA = "0x9AC86C", Offset = "0x9AC86C", VA = "0x9AC86C", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D7F RID: 40319
				[Token(Token = "0x4009D7F")]
				[FieldOffset(Offset = "0x8")]
				private int _targetFrameX;

				// Token: 0x04009D80 RID: 40320
				[Token(Token = "0x4009D80")]
				[FieldOffset(Offset = "0xC")]
				private int _targetFrameY;

				// Token: 0x04009D81 RID: 40321
				[Token(Token = "0x4009D81")]
				[FieldOffset(Offset = "0x10")]
				private int _paddingX;

				// Token: 0x04009D82 RID: 40322
				[Token(Token = "0x4009D82")]
				[FieldOffset(Offset = "0x14")]
				private int _paddingY;

				// Token: 0x04009D83 RID: 40323
				[Token(Token = "0x4009D83")]
				[FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			// Token: 0x02000C43 RID: 3139
			[Token(Token = "0x2000C43")]
			public class SetFrameSequence : FileAPI, GUIControllerItem
			{
				// Token: 0x06005D87 RID: 23943 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D87")]
				[Address(RVA = "0x9AC8D8", Offset = "0x9AC8D8", VA = "0x9AC8D8")]
				public SetFrameSequence(int duration, Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x06005D88 RID: 23944 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D88")]
				[Address(RVA = "0x9AC928", Offset = "0x9AC928", VA = "0x9AC928")]
				public SetFrameSequence(Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
				}

				// Token: 0x06005D89 RID: 23945 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D89")]
				[Address(RVA = "0x9AC974", Offset = "0x9AC974", VA = "0x9AC974", Slot = "4")]
				public void BindTo(Segments.LooseSprite obj)
				{
				}

				// Token: 0x17000A67 RID: 2663
				// (get) Token: 0x06005D8A RID: 23946 RVA: 0x0002BAA0 File Offset: 0x00029CA0
				[Token(Token = "0x17000A67")]
				public int ExpectedLengthOfActionInFrames
				{
					[Token(Token = "0x6005D8A")]
					[Address(RVA = "0x9AC978", Offset = "0x9AC978", VA = "0x9AC978", Slot = "5")]
					get
					{
						return 0;
					}
				}

				// Token: 0x06005D8B RID: 23947 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D8B")]
				[Address(RVA = "0x9AC980", Offset = "0x9AC980", VA = "0x9AC980", Slot = "7")]
				public void SetDelay(float delay)
				{
				}

				// Token: 0x06005D8C RID: 23948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005D8C")]
				[Address(RVA = "0x9AC988", Offset = "0x9AC988", VA = "0x9AC988", Slot = "6")]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
				}

				// Token: 0x04009D84 RID: 40324
				[Token(Token = "0x4009D84")]
				[FieldOffset(Offset = "0x8")]
				private Point[] _frameIndices;

				// Token: 0x04009D85 RID: 40325
				[Token(Token = "0x4009D85")]
				[FieldOffset(Offset = "0xC")]
				private int _timePerFrame;

				// Token: 0x04009D86 RID: 40326
				[Token(Token = "0x4009D86")]
				[FieldOffset(Offset = "0x10")]
				private int _paddingX;

				// Token: 0x04009D87 RID: 40327
				[Token(Token = "0x4009D87")]
				[FieldOffset(Offset = "0x14")]
				private int _paddingY;

				// Token: 0x04009D88 RID: 40328
				[Token(Token = "0x4009D88")]
				[FieldOffset(Offset = "0x18")]
				private float _delay;

				// Token: 0x04009D89 RID: 40329
				[Token(Token = "0x4009D89")]
				[FieldOffset(Offset = "0x1C")]
				private int _duration;

				// Token: 0x04009D8A RID: 40330
				[Token(Token = "0x4009D8A")]
				[FieldOffset(Offset = "0x20")]
				private bool _loop;
			}
		}
	}
}
