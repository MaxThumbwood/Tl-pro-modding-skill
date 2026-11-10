using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E0B RID: 3595
	[Token(Token = "0x2000E0B")]
	public class AssetRepository : FileAPI, GUIControllerItem
	{
		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x0600692E RID: 26926 RVA: 0x0002FA60 File Offset: 0x0002DC60
		[Token(Token = "0x17000B40")]
		public int PendingAssets
		{
			[Token(Token = "0x600692E")]
			[Address(RVA = "0xB85240", Offset = "0xB85240", VA = "0xB85240", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x0600692F RID: 26927 RVA: 0x0002FA78 File Offset: 0x0002DC78
		// (set) Token: 0x06006930 RID: 26928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B41")]
		public int TotalAssets
		{
			[Token(Token = "0x600692F")]
			[Address(RVA = "0xB85298", Offset = "0xB85298", VA = "0xB85298", Slot = "5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006930")]
			[Address(RVA = "0xB852A0", Offset = "0xB852A0", VA = "0xB852A0")]
			private set
			{
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06006931 RID: 26929 RVA: 0x0002FA90 File Offset: 0x0002DC90
		// (set) Token: 0x06006932 RID: 26930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B42")]
		public int LoadedAssets
		{
			[Token(Token = "0x6006931")]
			[Address(RVA = "0xB852A8", Offset = "0xB852A8", VA = "0xB852A8", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006932")]
			[Address(RVA = "0xB852B0", Offset = "0xB852B0", VA = "0xB852B0")]
			private set
			{
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06006933 RID: 26931 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		[Token(Token = "0x17000B43")]
		public bool IsAsyncLoadingEnabled
		{
			[Token(Token = "0x6006933")]
			[Address(RVA = "0xB852B8", Offset = "0xB852B8", VA = "0xB852B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006934")]
		[Address(RVA = "0xB852C0", Offset = "0xB852C0", VA = "0xB852C0")]
		public AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader)
		{
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006935")]
		[Address(RVA = "0xB8549C", Offset = "0xB8549C", VA = "0xB8549C")]
		internal AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader, bool useAsync)
		{
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006936")]
		[Address(RVA = "0xB85678", Offset = "0xB85678", VA = "0xB85678", Slot = "10")]
		public void ProcessAsyncLoad()
		{
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006937")]
		[Address(RVA = "0xB858F4", Offset = "0xB858F4", VA = "0xB858F4", Slot = "7")]
		public void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad)
		{
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006938")]
		public Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class
		{
			return null;
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006939")]
		[Address(RVA = "0xB86278", Offset = "0xB86278", VA = "0xB86278", Slot = "9")]
		public void TransferCompletedAssets()
		{
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693A")]
		[Address(RVA = "0xB85C08", Offset = "0xB85C08", VA = "0xB85C08")]
		private void ReloadAssetsIfSourceChanged(AssetRequestMode mode)
		{
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693B")]
		private void LoadAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693C")]
		private void TryLoadingAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693D")]
		[Address(RVA = "0xB864AC", Offset = "0xB864AC", VA = "0xB864AC")]
		private void ForceReloadAsset(IAsset asset, AssetRequestMode mode)
		{
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693E")]
		private void EnsureReloadActionExistsForType<T>() where T : class
		{
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693F")]
		private void ForceReloadAsset<T>(IAsset asset, AssetRequestMode mode) where T : class
		{
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006940")]
		[Address(RVA = "0xB86354", Offset = "0xB86354", VA = "0xB86354")]
		private IContentSource FindSourceForAsset(string assetName)
		{
			return null;
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006941")]
		[Address(RVA = "0xB85A64", Offset = "0xB85A64", VA = "0xB85A64")]
		private void ThrowIfDisposed()
		{
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006942")]
		[Address(RVA = "0xB86578", Offset = "0xB86578", VA = "0xB86578", Slot = "12")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006943")]
		[Address(RVA = "0xB867CC", Offset = "0xB867CC", VA = "0xB867CC", Slot = "11")]
		public void Dispose()
		{
		}

		// Token: 0x0400A6DD RID: 42717
		[Token(Token = "0x400A6DD")]
		[FieldOffset(Offset = "0x8")]
		private int <TotalAssets>k__BackingField;

		// Token: 0x0400A6DE RID: 42718
		[Token(Token = "0x400A6DE")]
		[FieldOffset(Offset = "0xC")]
		private int <LoadedAssets>k__BackingField;

		// Token: 0x0400A6DF RID: 42719
		[Token(Token = "0x400A6DF")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IAsset> _assets;

		// Token: 0x0400A6E0 RID: 42720
		[Token(Token = "0x400A6E0")]
		[FieldOffset(Offset = "0x14")]
		private IEnumerable<IContentSource> _sources;

		// Token: 0x0400A6E1 RID: 42721
		[Token(Token = "0x400A6E1")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Type, Action<IAsset, AssetRequestMode>> _typeSpecificReloadActions;

		// Token: 0x0400A6E2 RID: 42722
		[Token(Token = "0x400A6E2")]
		[FieldOffset(Offset = "0x1C")]
		private readonly AsyncAssetLoader _asyncLoader;

		// Token: 0x0400A6E3 RID: 42723
		[Token(Token = "0x400A6E3")]
		[FieldOffset(Offset = "0x20")]
		private readonly IAssetLoader _loader;

		// Token: 0x0400A6E4 RID: 42724
		[Token(Token = "0x400A6E4")]
		[FieldOffset(Offset = "0x24")]
		private List<IAsset> _queuedAssets;

		// Token: 0x0400A6E5 RID: 42725
		[Token(Token = "0x400A6E5")]
		[FieldOffset(Offset = "0x28")]
		private readonly object _requestLock;

		// Token: 0x0400A6E6 RID: 42726
		[Token(Token = "0x400A6E6")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isDisposed;

		// Token: 0x02000E0C RID: 3596
		[Token(Token = "0x2000E0C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006945 RID: 26949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006945")]
			[Address(RVA = "0xB86854", Offset = "0xB86854", VA = "0xB86854")]
			public <>c()
			{
			}

			// Token: 0x06006946 RID: 26950 RVA: 0x0002FAC0 File Offset: 0x0002DCC0
			[Token(Token = "0x6006946")]
			[Address(RVA = "0xB8685C", Offset = "0xB8685C", VA = "0xB8685C")]
			internal bool <ReloadAssetsIfSourceChanged>b__25_0(IAsset asset)
			{
				return default(bool);
			}

			// Token: 0x0400A6E7 RID: 42727
			[Token(Token = "0x400A6E7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly AssetRepository.<>c <>9;

			// Token: 0x0400A6E8 RID: 42728
			[Token(Token = "0x400A6E8")]
			[FieldOffset(Offset = "0x4")]
			public static Func<IAsset, bool> <>9__25_0;
		}

		// Token: 0x02000E0D RID: 3597
		[Token(Token = "0x2000E0D")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x06006947 RID: 26951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006947")]
			[Address(RVA = "0xB86570", Offset = "0xB86570", VA = "0xB86570")]
			public <>c__DisplayClass31_0()
			{
			}

			// Token: 0x06006948 RID: 26952 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
			[Token(Token = "0x6006948")]
			[Address(RVA = "0xB86910", Offset = "0xB86910", VA = "0xB86910")]
			internal bool <FindSourceForAsset>b__0(IContentSource source)
			{
				return default(bool);
			}

			// Token: 0x0400A6E9 RID: 42729
			[Token(Token = "0x400A6E9")]
			[FieldOffset(Offset = "0x8")]
			public string assetName;
		}
	}
}
