using System;
using System.Collections.Concurrent;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020008A9 RID: 2217
	[Token(Token = "0x20008A9")]
	internal static class TextureManager
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x6506E8", Offset = "0x6506E8", VA = "0x6506E8")]
		public static void Initialize()
		{
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x6507FC", Offset = "0x6507FC", VA = "0x6507FC")]
		public static Texture2D Load(string name)
		{
			return null;
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x650AE8", Offset = "0x650AE8", VA = "0x650AE8")]
		public static Ref<Texture2D> Retrieve(string name)
		{
			return null;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x650BB4", Offset = "0x650BB4", VA = "0x650BB4")]
		public static void Run(object context)
		{
		}

		// Token: 0x0400905B RID: 36955
		[Token(Token = "0x400905B")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentDictionary<string, Texture2D> _textures;

		// Token: 0x0400905C RID: 36956
		[Token(Token = "0x400905C")]
		[FieldOffset(Offset = "0x4")]
		private static ConcurrentQueue<TextureManager.LoadPair> _loadQueue;

		// Token: 0x0400905D RID: 36957
		[Token(Token = "0x400905D")]
		[FieldOffset(Offset = "0x8")]
		private static Thread _loadThread;

		// Token: 0x0400905E RID: 36958
		[Token(Token = "0x400905E")]
		[FieldOffset(Offset = "0xC")]
		private static readonly object _loadThreadLock;

		// Token: 0x0400905F RID: 36959
		[Token(Token = "0x400905F")]
		[FieldOffset(Offset = "0x10")]
		public static Texture2D BlankTexture;

		// Token: 0x020008AA RID: 2218
		[Token(Token = "0x20008AA")]
		private struct LoadPair
		{
			// Token: 0x06004B58 RID: 19288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B58")]
			[Address(RVA = "0x650E9C", Offset = "0x650E9C", VA = "0x650E9C")]
			public LoadPair(string path, Ref<Texture2D> textureRef)
			{
			}

			// Token: 0x04009060 RID: 36960
			[Token(Token = "0x4009060")]
			[FieldOffset(Offset = "0x0")]
			public string Path;

			// Token: 0x04009061 RID: 36961
			[Token(Token = "0x4009061")]
			[FieldOffset(Offset = "0x4")]
			public Ref<Texture2D> TextureRef;
		}
	}
}
