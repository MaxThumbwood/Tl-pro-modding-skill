using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000425 RID: 1061
	[Token(Token = "0x2000425")]
	public class Texture2D : Texture
	{
		// Token: 0x06001D61 RID: 7521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0xE90E6C", Offset = "0xE90E6C", VA = "0xE90E6C")]
		public void ResetLoaded()
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x170003A0")]
		public int UnityTextureWidth
		{
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0xE910D4", Offset = "0xE910D4", VA = "0xE910D4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0xE91224", Offset = "0xE91224", VA = "0xE91224")]
		private void LoadCallback(Texture2D tex0, Texture2D tex1, Texture2D tex2, int page)
		{
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0xE913A8", Offset = "0xE913A8", VA = "0xE913A8")]
		private void LoadSourceTexture()
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x170003A1")]
		public int UnityTextureHeight
		{
			[Token(Token = "0x6001D65")]
			[Address(RVA = "0xE919A0", Offset = "0xE919A0", VA = "0xE919A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public Texture UnityBindTexture
		{
			[Token(Token = "0x6001D66")]
			[Address(RVA = "0xE9119C", Offset = "0xE9119C", VA = "0xE9119C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0xE91C00", Offset = "0xE91C00", VA = "0xE91C00")]
		public void RefreshAtlasTexture()
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public Texture2D UnityTexture
		{
			[Token(Token = "0x6001D68")]
			[Address(RVA = "0xE91A68", Offset = "0xE91A68", VA = "0xE91A68")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		public Texture2D UnityAlphaTexture
		{
			[Token(Token = "0x6001D69")]
			[Address(RVA = "0xE91D10", Offset = "0xE91D10", VA = "0xE91D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A5")]
		public Texture2D UnityPalTexture
		{
			[Token(Token = "0x6001D6A")]
			[Address(RVA = "0xE91D18", Offset = "0xE91D18", VA = "0xE91D18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0xE91D20", Offset = "0xE91D20", VA = "0xE91D20")]
		public static int GetBatchId()
		{
			return 0;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0xE91078", Offset = "0xE91078", VA = "0xE91078")]
		public void RefreshBatchIndex()
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x170003A6")]
		public Rectangle Bounds
		{
			[Token(Token = "0x6001D6D")]
			[Address(RVA = "0xE91D78", Offset = "0xE91D78", VA = "0xE91D78")]
			get
			{
				return default(Rectangle);
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0xE91DAC", Offset = "0xE91DAC", VA = "0xE91DAC")]
		public Texture2D(string sourceAsset, int width, int height)
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0xE921B8", Offset = "0xE921B8", VA = "0xE921B8")]
		public Texture2D(Texture2D texture)
		{
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0xE922A0", Offset = "0xE922A0", VA = "0xE922A0")]
		public Texture2D(RenderTexture texture)
		{
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0xE9238C", Offset = "0xE9238C", VA = "0xE9238C")]
		public Texture2D(Texture2D texture, Texture2D texture2)
		{
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0xE924B0", Offset = "0xE924B0", VA = "0xE924B0")]
		public Texture2D(Texture2D texture, Texture2D texture2, Texture2D texture3)
		{
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0xE92674", Offset = "0xE92674", VA = "0xE92674")]
		public Texture2D(Texture2D texture, TextureAtlasEntry entry)
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0xE927E8", Offset = "0xE927E8", VA = "0xE927E8")]
		public Texture2D(TextureAtlasDB textureAtlas, TextureAtlasEntry entry)
		{
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0xE929D8", Offset = "0xE929D8", VA = "0xE929D8")]
		private void CreateEmptyTexture(object data)
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0xE92A68", Offset = "0xE92A68", VA = "0xE92A68")]
		public Texture2D(GraphicsDevice device, int width, int height)
		{
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0xE92BDC", Offset = "0xE92BDC", VA = "0xE92BDC")]
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format)
		{
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0xE92C10", Offset = "0xE92C10", VA = "0xE92C10")]
		public Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, int arraySize)
		{
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0xE92C44", Offset = "0xE92C44", VA = "0xE92C44")]
		internal Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0xE91E08", Offset = "0xE91E08", VA = "0xE91E08")]
		protected Texture2D(GraphicsDevice device, int width, int height, bool mipmap, SurfaceFormat format, Texture2D.SurfaceType type, bool shared, int arraySize)
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0xE92C78", Offset = "0xE92C78", VA = "0xE92C78")]
		public void SaveAsPng(Stream stream, int width, int height)
		{
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7C")]
		public void SetData<T>(T[] data, int start, int length)
		{
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0xE92C7C", Offset = "0xE92C7C", VA = "0xE92C7C")]
		private static void ConvertToABGR(int pixelHeight, int pixelWidth, int[] pixels)
		{
		}

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x24")]
		public int UnityWidth;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x28")]
		public int UnityHeight;

		// Token: 0x0400311B RID: 12571
		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0x2C")]
		public readonly int Width;

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x30")]
		public readonly int Height;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0x34")]
		internal int ArraySize;

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x38")]
		internal float TexelWidth;

		// Token: 0x0400311F RID: 12575
		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x3C")]
		internal float TexelHeight;

		// Token: 0x04003120 RID: 12576
		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x40")]
		public float TextureOffsetScale;

		// Token: 0x04003121 RID: 12577
		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0x44")]
		public bool SharedBatching;

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x45")]
		public bool NonSharedHeadInsert;

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x48")]
		public TextureAtlasEntry PackedEntry;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x4C")]
		private bool loadRequested;

		// Token: 0x04003125 RID: 12581
		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x0")]
		public static bool ignoreLoad;

		// Token: 0x04003126 RID: 12582
		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x4D")]
		private bool _textureLoaded;

		// Token: 0x04003127 RID: 12583
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture _unityRenderTexture;

		// Token: 0x04003128 RID: 12584
		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x54")]
		private Texture2D _unityTexture;

		// Token: 0x04003129 RID: 12585
		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x58")]
		private Texture2D _unityAlphaTexture;

		// Token: 0x0400312A RID: 12586
		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x5C")]
		private Texture2D _unityPalTexture;

		// Token: 0x0400312B RID: 12587
		[Token(Token = "0x400312B")]
		[FieldOffset(Offset = "0x60")]
		public TextureAtlasDB _textureAtlas;

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x4")]
		private static int _nextTextureId;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x64")]
		private readonly int _batchTextureIndex;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x68")]
		public int BatchTextureIndex;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x6C")]
		private string _sourceLoadAsset;

		// Token: 0x02000426 RID: 1062
		[Token(Token = "0x2000426")]
		protected internal enum SurfaceType
		{
			// Token: 0x04003131 RID: 12593
			[Token(Token = "0x4003131")]
			Texture,
			// Token: 0x04003132 RID: 12594
			[Token(Token = "0x4003132")]
			RenderTarget,
			// Token: 0x04003133 RID: 12595
			[Token(Token = "0x4003133")]
			SwapChainRenderTarget
		}

		// Token: 0x02000427 RID: 1063
		// (Invoke) Token: 0x06001D7F RID: 7551
		[Token(Token = "0x2000427")]
		public delegate Texture2D TextureLoader(int data);
	}
}
