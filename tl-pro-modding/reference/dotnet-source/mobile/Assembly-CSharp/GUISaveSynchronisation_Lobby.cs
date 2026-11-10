using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
public class GUISaveSynchronisation_Lobby
{
	// Token: 0x06001264 RID: 4708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001264")]
	[Address(RVA = "0xD844F4", Offset = "0xD844F4", VA = "0xD844F4")]
	public static void Draw()
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001265")]
	[Address(RVA = "0xD8E31C", Offset = "0xD8E31C", VA = "0xD8E31C")]
	public static void RefreshServers()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001266")]
	[Address(RVA = "0xD8DB60", Offset = "0xD8DB60", VA = "0xD8DB60")]
	private static void DrawServers()
	{
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x000087F0 File Offset: 0x000069F0
	[Token(Token = "0x6001267")]
	[Address(RVA = "0xD8E490", Offset = "0xD8E490", VA = "0xD8E490")]
	private static float ServerScale(int index)
	{
		return 0f;
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001268")]
	[Address(RVA = "0xD8E498", Offset = "0xD8E498", VA = "0xD8E498")]
	private static void ServerOver(int index)
	{
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001269")]
	[Address(RVA = "0xD8E500", Offset = "0xD8E500", VA = "0xD8E500")]
	private static void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126A")]
	[Address(RVA = "0xD8EF20", Offset = "0xD8EF20", VA = "0xD8EF20")]
	private static void DrawServer(SaveSynchronisationFinder.SearchServerResult serverData)
	{
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126B")]
	[Address(RVA = "0xD8D3B0", Offset = "0xD8D3B0", VA = "0xD8D3B0")]
	private static void Back()
	{
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126C")]
	[Address(RVA = "0xD8D550", Offset = "0xD8D550", VA = "0xD8D550")]
	private static void DrawMainButtons()
	{
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600126D")]
	[Address(RVA = "0xD8F290", Offset = "0xD8F290", VA = "0xD8F290")]
	public GUISaveSynchronisation_Lobby()
	{
	}

	// Token: 0x040023C0 RID: 9152
	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0x0")]
	public static bool DisplayJoin;

	// Token: 0x040023C1 RID: 9153
	[Token(Token = "0x40023C1")]
	[FieldOffset(Offset = "0x4")]
	public static GUISaveSynchronisation_Join JoinUI;

	// Token: 0x040023C2 RID: 9154
	[Token(Token = "0x40023C2")]
	[FieldOffset(Offset = "0x8")]
	private static Rectangle SelectedItemRegion;

	// Token: 0x040023C3 RID: 9155
	[Token(Token = "0x40023C3")]
	[FieldOffset(Offset = "0x18")]
	public static float ScrollOffset;

	// Token: 0x040023C4 RID: 9156
	[Token(Token = "0x40023C4")]
	[FieldOffset(Offset = "0x1C")]
	private static float ScrollMomentum;

	// Token: 0x040023C5 RID: 9157
	[Token(Token = "0x40023C5")]
	[FieldOffset(Offset = "0x20")]
	private static int ScrollDragging;

	// Token: 0x040023C6 RID: 9158
	[Token(Token = "0x40023C6")]
	[FieldOffset(Offset = "0x24")]
	private static Vector2 DragOffset;

	// Token: 0x040023C7 RID: 9159
	[Token(Token = "0x40023C7")]
	[FieldOffset(Offset = "0x2C")]
	private static float TitleScale;

	// Token: 0x040023C8 RID: 9160
	[Token(Token = "0x40023C8")]
	[FieldOffset(Offset = "0x30")]
	private static float ConnectIPScale;

	// Token: 0x040023C9 RID: 9161
	[Token(Token = "0x40023C9")]
	[FieldOffset(Offset = "0x34")]
	private static float connectButtonScale;

	// Token: 0x040023CA RID: 9162
	[Token(Token = "0x40023CA")]
	[FieldOffset(Offset = "0x38")]
	private static float backButtonScale;

	// Token: 0x040023CB RID: 9163
	[Token(Token = "0x40023CB")]
	[FieldOffset(Offset = "0x40")]
	private static DateTime LastSelectTime;

	// Token: 0x040023CC RID: 9164
	[Token(Token = "0x40023CC")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x040023CD RID: 9165
	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x48")]
	private static GUIControllerSaveSynchronisation_Lobby _controllerInput;

	// Token: 0x040023CE RID: 9166
	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x4C")]
	public static int selectedServer;

	// Token: 0x040023CF RID: 9167
	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x50")]
	private static int serverOver;
}
