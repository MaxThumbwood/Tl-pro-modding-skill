using System;
using System.Collections;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Unity.Collections;

// Token: 0x02000168 RID: 360
[Token(Token = "0x2000168")]
public class GUIMap
{
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00006198 File Offset: 0x00004398
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000E0")]
	public GUIMap.MinimapFrameStyle ActiveFrameStyle
	{
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xACCEF8", Offset = "0xACCEF8", VA = "0xACCEF8")]
		get
		{
			return GUIMap.MinimapFrameStyle.Default;
		}
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xACCF00", Offset = "0xACCF00", VA = "0xACCF00")]
		set
		{
		}
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0xACD1DC", Offset = "0xACD1DC", VA = "0xACD1DC")]
	private void ClearMap()
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0xACD408", Offset = "0xACD408", VA = "0xACD408")]
	private void ApplyMap()
	{
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0xACD524", Offset = "0xACD524", VA = "0xACD524")]
	private void InitialiseTargets()
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0xACD068", Offset = "0xACD068", VA = "0xACD068")]
	public void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A30")]
	[Address(RVA = "0xACD960", Offset = "0xACD960", VA = "0xACD960")]
	public void LoadDefaultZoom()
	{
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x000061B0 File Offset: 0x000043B0
	[Token(Token = "0x6000A31")]
	[Address(RVA = "0xACDA08", Offset = "0xACDA08", VA = "0xACDA08")]
	public bool IsCursorOverFullScreenMapControls(Cursor cursor)
	{
		return default(bool);
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A32")]
	[Address(RVA = "0xACDDB0", Offset = "0xACDDB0", VA = "0xACDDB0")]
	public void CleanupMapTargets()
	{
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A33")]
	[Address(RVA = "0xACDF34", Offset = "0xACDF34", VA = "0xACDF34")]
	public void DrawToMap()
	{
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A34")]
	[Address(RVA = "0xACE840", Offset = "0xACE840", VA = "0xACE840")]
	private void ApplySection(int xStart, int xEnd, int yStart, int yEnd)
	{
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0xACEF04", Offset = "0xACEF04", VA = "0xACEF04")]
	public IEnumerator DrawToMap_Section_Sliced(int secX, int secY)
	{
		return null;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0xACEFBC", Offset = "0xACEFBC", VA = "0xACEFBC")]
	public void DrawToMap_Section(int secX, int secY)
	{
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0xACF81C", Offset = "0xACF81C", VA = "0xACF81C")]
	public void ResetMapPing()
	{
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0xACF888", Offset = "0xACF888", VA = "0xACF888")]
	public void CloseFullscreenMap()
	{
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A39")]
	[Address(RVA = "0xACF91C", Offset = "0xACF91C", VA = "0xACF91C")]
	public void OpenFullscreenMap()
	{
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0xACFBF0", Offset = "0xACFBF0", VA = "0xACFBF0")]
	public void DrawMap()
	{
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0xADCCCC", Offset = "0xADCCCC", VA = "0xADCCCC")]
	private void DrawMapFullscreenBackground(Vector2 screenPosition, int screenWidth, int screenHeight)
	{
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x170000E1")]
	private int WorldScreenWidth
	{
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xADCA44", Offset = "0xADCA44", VA = "0xADCA44")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000A3D RID: 2621 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x170000E2")]
	private int WorldScreenHeight
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xADCB88", Offset = "0xADCB88", VA = "0xADCB88")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A3E")]
	[Address(RVA = "0xADDB10", Offset = "0xADDB10", VA = "0xADDB10")]
	public GUIMap()
	{
	}

	// Token: 0x04000C33 RID: 3123
	[Token(Token = "0x4000C33")]
	private const int MapTextureDimensions = 256;

	// Token: 0x04000C34 RID: 3124
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x8")]
	public bool grabbedMap;

	// Token: 0x04000C35 RID: 3125
	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0xC")]
	private int activeX;

	// Token: 0x04000C36 RID: 3126
	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x10")]
	private int activeY;

	// Token: 0x04000C37 RID: 3127
	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x14")]
	private Texture2D[] mapTarget;

	// Token: 0x04000C38 RID: 3128
	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x18")]
	private bool[] mapDirty;

	// Token: 0x04000C39 RID: 3129
	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x1C")]
	private NativeArray<ushort>[] mapTextureData;

	// Token: 0x04000C3A RID: 3130
	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x20")]
	private unsafe ushort*[] mapTextureDataPtr;

	// Token: 0x04000C3B RID: 3131
	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x24")]
	public bool miniMapEnabled;

	// Token: 0x04000C3C RID: 3132
	[Token(Token = "0x4000C3C")]
	[FieldOffset(Offset = "0x25")]
	private bool mapPressed;

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x26")]
	private bool mapPressedLast;

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0x27")]
	private bool mapZoomInPressed;

	// Token: 0x04000C3F RID: 3135
	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x28")]
	private bool mapZoomOutPressed;

	// Token: 0x04000C40 RID: 3136
	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x29")]
	private bool mapZoomResetPressed;

	// Token: 0x04000C41 RID: 3137
	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x2C")]
	public Texture2D miniMapOpen;

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D miniMapClosed;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x34")]
	private float ZoomInButtonScale;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x38")]
	private float ZoomOutButtonScale;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x3C")]
	private float ZoomDefaultButtonScale;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x40")]
	private float ToggleButtonScale;

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x44")]
	private float MapButtonScale;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x48")]
	private bool use565Map;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x4C")]
	private GUIMap.MinimapFrameStyle _activeFrameStyle;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x50")]
	public string BackingMiniTextureId;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x54")]
	public string BackingLargeTextureId;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x58")]
	private bool draggingSlider;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x5C")]
	private float ZoomValue;

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x60")]
	private float TinyScrollScale;

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x64")]
	private float TinyXOffset;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x68")]
	private float TinyYOffset;

	// Token: 0x04000C51 RID: 3153
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x6C")]
	private float TinyW;

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x70")]
	private float TinyH;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x74")]
	private GUIControllerFullScreenMap _controller;

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x78")]
	private DateTime _lastPingMouseDownTime;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 _lastPingMousePosition;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x88")]
	private int LastFrame;

	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public enum MinimapFrameStyle
	{
		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		Default,
		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		Golden,
		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		Remix,
		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		Sticks,
		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		StoneGold,
		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		TwigLeaf,
		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		Leaf,
		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		Retro,
		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		Valkyrie
	}

	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	private sealed class <DrawToMap_Section_Sliced>d__40 : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xBABB74", Offset = "0xBABB74", VA = "0xBABB74")]
		public <DrawToMap_Section_Sliced>d__40(int <>1__state)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0xBABB90", Offset = "0xBABB90", VA = "0xBABB90", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xBABB94", Offset = "0xBABB94", VA = "0xBABB94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xBABEC8", Offset = "0xBABEC8", VA = "0xBABEC8", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xBABED0", Offset = "0xBABED0", VA = "0xBABED0", Slot = "8")]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xBABF1C", Offset = "0xBABF1C", VA = "0xBABF1C", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x8")]
		private int <>1__state;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0xC")]
		private object <>2__current;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x10")]
		public GUIMap <>4__this;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x14")]
		public int secX;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x18")]
		public int secY;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x1C")]
		private int <xStart>5__2;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x20")]
		private int <xEnd>5__3;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x24")]
		private int <yEnd>5__4;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x28")]
		private int <ty>5__5;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x2C")]
		private int <tx>5__6;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x30")]
		private int <chunkEndY>5__7;
	}
}
