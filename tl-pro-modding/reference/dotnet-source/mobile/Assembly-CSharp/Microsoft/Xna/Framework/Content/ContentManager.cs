using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

namespace Microsoft.Xna.Framework.Content
{
	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	public class ContentManager
	{
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		public IServiceProvider ServiceProvider
		{
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0xE99C68", Offset = "0xE99C68", VA = "0xE99C68")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0xE99C70", Offset = "0xE99C70", VA = "0xE99C70")]
		public ContentManager(IServiceProvider serviceProvider, string p)
		{
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E85")]
		internal T1 Load<T1>(string asset) where T1 : class
		{
			return null;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x170003C3")]
		public static bool AsyncLoadStillRequired
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0xE99DB4", Offset = "0xE99DB4", VA = "0xE99DB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0xE99E44", Offset = "0xE99E44", VA = "0xE99E44")]
		public static void UpdateAysncLoad()
		{
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0xE91778", Offset = "0xE91778", VA = "0xE91778")]
		public static void LoadUnityTexturePageAsync(string asset0, string asset1, string asset2, int pageIndex, Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> loadedCallback)
		{
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E89")]
		public static ResourceType LoadUnityResource<ResourceType>(string asset) where ResourceType : global::UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8A")]
		public static ResourceType ConstructFromUnityResource<ResourceType>(string asset, ThreadContentRequest.ObjectCreate createFunction) where ResourceType : class
		{
			return null;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8B")]
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, ThreadContentRequest.ObjectCreate2 createFunction) where ResourceType : class
		{
			return null;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8C")]
		public static ResourceType ConstructFromUnityResources<ResourceType>(string asset, string asset2, string asset3, ThreadContentRequest.ObjectCreate3 createFunction) where ResourceType : class
		{
			return null;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0xE9A17C", Offset = "0xE9A17C", VA = "0xE9A17C")]
		private static object CreateTextureAsset(object resource)
		{
			return null;
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0xE9A2A8", Offset = "0xE9A2A8", VA = "0xE9A2A8")]
		private static object CreateTextureAssets(object resource, object resource2)
		{
			return null;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C4")]
		private static global::UnityEngine.Texture2D Empty
		{
			[Token(Token = "0x6001E8F")]
			[Address(RVA = "0xE9A434", Offset = "0xE9A434", VA = "0xE9A434")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0xE9A570", Offset = "0xE9A570", VA = "0xE9A570")]
		private static object CreateTextureAssetsWithPal(object resource, object resource2, object resource3)
		{
			return null;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0xE9A6EC", Offset = "0xE9A6EC", VA = "0xE9A6EC")]
		public void UnloadSourceTextures()
		{
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0xE9A7A8", Offset = "0xE9A7A8", VA = "0xE9A7A8")]
		private Microsoft.Xna.Framework.Graphics.Texture2D LoadTexture2D(string asset)
		{
			return null;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0xE9B154", Offset = "0xE9B154", VA = "0xE9B154")]
		private SpriteFont LoadSpriteFont(string asset)
		{
			return null;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0xE9BC04", Offset = "0xE9BC04", VA = "0xE9BC04")]
		private static object CreateSoundEffect(object resource)
		{
			return null;
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0xE9BD48", Offset = "0xE9BD48", VA = "0xE9BD48")]
		private SoundEffect LoadSoundEffect(string asset)
		{
			return null;
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0xE9BED8", Offset = "0xE9BED8", VA = "0xE9BED8")]
		internal void Unload()
		{
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C5")]
		public string RootDirectory
		{
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0xE9BEDC", Offset = "0xE9BEDC", VA = "0xE9BEDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E98")]
			[Address(RVA = "0xE9BEE4", Offset = "0xE9BEE4", VA = "0xE9BEE4")]
			set
			{
			}
		}

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x0")]
		public static ContentManager Instance;

		// Token: 0x0400314F RID: 12623
		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x8")]
		private IServiceProvider serviceProvider;

		// Token: 0x04003150 RID: 12624
		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0xC")]
		private string p;

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x4")]
		private static List<ContentManager.TextureLoadEntry> LoadingAssets;

		// Token: 0x04003152 RID: 12626
		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x8")]
		private static global::UnityEngine.Texture2D emptyTexture;

		// Token: 0x04003153 RID: 12627
		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0xC")]
		private static ContentManager.SourceAssetEntry[] sourceAssets;

		// Token: 0x04003154 RID: 12628
		[Token(Token = "0x4003154")]
		[FieldOffset(Offset = "0x10")]
		private List<Microsoft.Xna.Framework.Graphics.Texture2D> _sourceTexturesLoaded;

		// Token: 0x04003155 RID: 12629
		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<string, Microsoft.Xna.Framework.Graphics.Texture2D> _loadedTextures;

		// Token: 0x04003156 RID: 12630
		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x10")]
		private static int total;

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x18")]
		private string <RootDirectory>k__BackingField;

		// Token: 0x0200043F RID: 1087
		[Token(Token = "0x200043F")]
		public class TextureLoadEntry
		{
			// Token: 0x06001E9A RID: 7834 RVA: 0x0000EC58 File Offset: 0x0000CE58
			[Token(Token = "0x6001E9A")]
			[Address(RVA = "0xF09580", Offset = "0xF09580", VA = "0xF09580")]
			public bool Update()
			{
				return default(bool);
			}

			// Token: 0x06001E9B RID: 7835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0xF09770", Offset = "0xF09770", VA = "0xF09770")]
			public TextureLoadEntry()
			{
			}

			// Token: 0x04003158 RID: 12632
			[Token(Token = "0x4003158")]
			[FieldOffset(Offset = "0x8")]
			public string loadAsset0;

			// Token: 0x04003159 RID: 12633
			[Token(Token = "0x4003159")]
			[FieldOffset(Offset = "0xC")]
			public string loadAsset1;

			// Token: 0x0400315A RID: 12634
			[Token(Token = "0x400315A")]
			[FieldOffset(Offset = "0x10")]
			public string loadAsset2;

			// Token: 0x0400315B RID: 12635
			[Token(Token = "0x400315B")]
			[FieldOffset(Offset = "0x14")]
			public global::UnityEngine.Texture2D request0;

			// Token: 0x0400315C RID: 12636
			[Token(Token = "0x400315C")]
			[FieldOffset(Offset = "0x18")]
			public global::UnityEngine.Texture2D request1;

			// Token: 0x0400315D RID: 12637
			[Token(Token = "0x400315D")]
			[FieldOffset(Offset = "0x1C")]
			public global::UnityEngine.Texture2D request2;

			// Token: 0x0400315E RID: 12638
			[Token(Token = "0x400315E")]
			[FieldOffset(Offset = "0x20")]
			public int page;

			// Token: 0x0400315F RID: 12639
			[Token(Token = "0x400315F")]
			[FieldOffset(Offset = "0x24")]
			public Action<global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, global::UnityEngine.Texture2D, int> Callback;
		}

		// Token: 0x02000440 RID: 1088
		[Token(Token = "0x2000440")]
		public struct SourceAssetEntry
		{
			// Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0xF09778", Offset = "0xF09778", VA = "0xF09778")]
			public SourceAssetEntry(string asset, int width, int height)
			{
			}

			// Token: 0x04003160 RID: 12640
			[Token(Token = "0x4003160")]
			[FieldOffset(Offset = "0x0")]
			public readonly string Asset;

			// Token: 0x04003161 RID: 12641
			[Token(Token = "0x4003161")]
			[FieldOffset(Offset = "0x4")]
			public readonly int Width;

			// Token: 0x04003162 RID: 12642
			[Token(Token = "0x4003162")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Height;
		}
	}
}
