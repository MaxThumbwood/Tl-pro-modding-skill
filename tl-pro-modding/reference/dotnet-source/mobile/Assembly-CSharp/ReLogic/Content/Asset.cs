using System;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x02000E02 RID: 3586
	[Token(Token = "0x2000E02")]
	public sealed class Asset<T> : FileAPI, GUIControllerItem where T : class
	{
		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06006907 RID: 26887 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006908 RID: 26888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3B")]
		public string Name
		{
			[Token(Token = "0x6006907")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006908")]
			private set
			{
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06006909 RID: 26889 RVA: 0x0002F9A0 File Offset: 0x0002DBA0
		[Token(Token = "0x17000B3C")]
		public bool IsLoaded
		{
			[Token(Token = "0x6006909")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3D")]
		public AssetState State
		{
			[Token(Token = "0x600690A")]
			get
			{
				return AssetState.NotLoaded;
			}
			[Token(Token = "0x600690B")]
			private set
			{
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600690C RID: 26892 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
		// (set) Token: 0x0600690D RID: 26893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3E")]
		public bool IsDisposed
		{
			[Token(Token = "0x600690C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600690D")]
			private set
			{
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600690E RID: 26894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600690F RID: 26895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B3F")]
		public IContentSource Source
		{
			[Token(Token = "0x600690E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600690F")]
			private set
			{
			}
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006910")]
		public void ActionUnityLoad()
		{
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006911")]
		internal Asset(string name)
		{
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006912")]
		public static explicit operator T(Asset<T> asset)
		{
			return null;
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006913")]
		internal void Unload()
		{
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006914")]
		internal void SubmitLoadedContent(T value, IContentSource source)
		{
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006915")]
		internal void SetToLoadingState()
		{
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006916")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006917")]
		public void Dispose()
		{
		}

		// Token: 0x0400A6D4 RID: 42708
		[Token(Token = "0x400A6D4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Asset<T> Empty;

		// Token: 0x0400A6D5 RID: 42709
		[Token(Token = "0x400A6D5")]
		[FieldOffset(Offset = "0x0")]
		private string <Name>k__BackingField;

		// Token: 0x0400A6D6 RID: 42710
		[Token(Token = "0x400A6D6")]
		[FieldOffset(Offset = "0x0")]
		private AssetState <State>k__BackingField;

		// Token: 0x0400A6D7 RID: 42711
		[Token(Token = "0x400A6D7")]
		[FieldOffset(Offset = "0x0")]
		private bool <IsDisposed>k__BackingField;

		// Token: 0x0400A6D8 RID: 42712
		[Token(Token = "0x400A6D8")]
		[FieldOffset(Offset = "0x0")]
		private IContentSource <Source>k__BackingField;

		// Token: 0x0400A6D9 RID: 42713
		[Token(Token = "0x400A6D9")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
