using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
public class GUIInputRegionManager
{
	// Token: 0x06000BE7 RID: 3047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0xC5481C", Offset = "0xC5481C", VA = "0xC5481C")]
	public static GUIInputRegionManager Create()
	{
		return null;
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00006D50 File Offset: 0x00004F50
	[Token(Token = "0x17000111")]
	public Vector2 MousePosition
	{
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0xC54930", Offset = "0xC54930", VA = "0xC54930")]
		get
		{
			return default(Vector2);
		}
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0xC54964", Offset = "0xC54964", VA = "0xC54964")]
	public void DisableAllPicking()
	{
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0xC54970", Offset = "0xC54970", VA = "0xC54970")]
	public void RenablePicking()
	{
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BEB")]
	[Address(RVA = "0xC5497C", Offset = "0xC5497C", VA = "0xC5497C")]
	public void SetMousePosition(int x, int y, bool inUISpace = false)
	{
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x00006D68 File Offset: 0x00004F68
	[Token(Token = "0x6000BEC")]
	[Address(RVA = "0xC54AFC", Offset = "0xC54AFC", VA = "0xC54AFC")]
	public bool RegisterInputRegion(Rectangle rect)
	{
		return default(bool);
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x00006D80 File Offset: 0x00004F80
	[Token(Token = "0x6000BED")]
	[Address(RVA = "0xC54F84", Offset = "0xC54F84", VA = "0xC54F84")]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale)
	{
		return default(bool);
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00006D98 File Offset: 0x00004F98
	[Token(Token = "0x6000BEE")]
	[Address(RVA = "0xC5503C", Offset = "0xC5503C", VA = "0xC5503C")]
	public bool RegisterInputRegion(int x, int y, Texture2D texture, float scale, Vector2 padding)
	{
		return default(bool);
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00006DB0 File Offset: 0x00004FB0
	[Token(Token = "0x6000BEF")]
	[Address(RVA = "0xC54BB4", Offset = "0xC54BB4", VA = "0xC54BB4")]
	public bool RegisterInputRegion(int xMin, int xMax, int yMin, int yMax)
	{
		return default(bool);
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x00006DC8 File Offset: 0x00004FC8
	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0xC55168", Offset = "0xC55168", VA = "0xC55168")]
	public bool IsOverExclusiveRegion()
	{
		return default(bool);
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0xC5510C", Offset = "0xC5510C", VA = "0xC5510C")]
	private void RemovePendingRegions()
	{
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0xC55454", Offset = "0xC55454", VA = "0xC55454")]
	public GUIInputRegionExclusive RegisterPickingInterceptor(GUIInputRegionExclusive.IsOverHandler handler)
	{
		return null;
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0xC55300", Offset = "0xC55300", VA = "0xC55300")]
	public void UnregisterPickingInterceptor(GUIInputRegionExclusive region)
	{
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00006DE0 File Offset: 0x00004FE0
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0xC55518", Offset = "0xC55518", VA = "0xC55518")]
	public bool RegisterInputRegion(int x, int y, Vector2 size)
	{
		return default(bool);
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00006DF8 File Offset: 0x00004FF8
	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0xC55578", Offset = "0xC55578", VA = "0xC55578")]
	public bool IsOverRegion()
	{
		return default(bool);
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00006E10 File Offset: 0x00005010
	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0xC55600", Offset = "0xC55600", VA = "0xC55600")]
	public bool IsOverRegionExpanded()
	{
		return default(bool);
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x00006E28 File Offset: 0x00005028
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0xC557B4", Offset = "0xC557B4", VA = "0xC557B4")]
	public bool IsPositionOverUI(Vector2 uiPosition)
	{
		return default(bool);
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0xC5586C", Offset = "0xC5586C", VA = "0xC5586C")]
	public void Clear()
	{
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0xC54890", Offset = "0xC54890", VA = "0xC54890")]
	public GUIInputRegionManager()
	{
	}

	// Token: 0x04000E94 RID: 3732
	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x0")]
	public static GUIInputRegionManager Instance;

	// Token: 0x04000E95 RID: 3733
	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x8")]
	private bool _disableAllRegions;

	// Token: 0x04000E96 RID: 3734
	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0xC")]
	private int _mouseX;

	// Token: 0x04000E97 RID: 3735
	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x10")]
	private int _mouseY;

	// Token: 0x04000E98 RID: 3736
	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x14")]
	private bool _checkingExclusiveRegions;

	// Token: 0x04000E99 RID: 3737
	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x18")]
	private int _exclusiveRegionCount;

	// Token: 0x04000E9A RID: 3738
	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x1C")]
	private GUIInputRegionExclusive[] _exclusiveRegion;

	// Token: 0x04000E9B RID: 3739
	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x20")]
	private int _pendingExclusiveRegionRemovesCount;

	// Token: 0x04000E9C RID: 3740
	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x24")]
	private GUIInputRegionExclusive[] _pendingExclusiveRegionRemoves;

	// Token: 0x04000E9D RID: 3741
	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x28")]
	private int _regionCount;

	// Token: 0x04000E9E RID: 3742
	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x2C")]
	private GUIInputRegion[] _currentRegion;
}
