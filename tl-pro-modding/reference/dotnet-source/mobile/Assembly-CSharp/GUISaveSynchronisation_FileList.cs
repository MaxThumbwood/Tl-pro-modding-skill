using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
public class GUISaveSynchronisation_FileList
{
	// Token: 0x06001247 RID: 4679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001247")]
	[Address(RVA = "0xD84ECC", Offset = "0xD84ECC", VA = "0xD84ECC")]
	public static void Draw()
	{
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001248")]
	[Address(RVA = "0xD86514", Offset = "0xD86514", VA = "0xD86514")]
	private static void DrawCategories()
	{
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001249")]
	[Address(RVA = "0xD877B4", Offset = "0xD877B4", VA = "0xD877B4")]
	private static void Back()
	{
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124A")]
	[Address(RVA = "0xD8781C", Offset = "0xD8781C", VA = "0xD8781C")]
	private static void UpdateAnim(Player player, bool animated)
	{
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124B")]
	[Address(RVA = "0xD8797C", Offset = "0xD8797C", VA = "0xD8797C")]
	private static void DrawPlayer(Player player, bool animated)
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124C")]
	[Address(RVA = "0xD85090", Offset = "0xD85090", VA = "0xD85090")]
	private static void DrawPlayers(List<PlayerFileData> playerFiles)
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00008790 File Offset: 0x00006990
	[Token(Token = "0x600124D")]
	[Address(RVA = "0xD87BF8", Offset = "0xD87BF8", VA = "0xD87BF8")]
	private static float PlayerScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124E")]
	[Address(RVA = "0xD87C00", Offset = "0xD87C00", VA = "0xD87C00")]
	private static void PlayerOver(int index)
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124F")]
	[Address(RVA = "0xD87D78", Offset = "0xD87D78", VA = "0xD87D78")]
	private static void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001250")]
	[Address(RVA = "0xD85B1C", Offset = "0xD85B1C", VA = "0xD85B1C")]
	private static void DrawWorlds(List<WorldFileData> worldFiles)
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x6001251")]
	[Address(RVA = "0xD89454", Offset = "0xD89454", VA = "0xD89454")]
	private static float WorldScale(int index)
	{
		return 0f;
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001252")]
	[Address(RVA = "0xD8945C", Offset = "0xD8945C", VA = "0xD8945C")]
	private static void WorldOver(int index)
	{
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001253")]
	[Address(RVA = "0xD895D4", Offset = "0xD895D4", VA = "0xD895D4")]
	private static void DrawWorld(WorldFileData worldData)
	{
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001254")]
	[Address(RVA = "0xD89818", Offset = "0xD89818", VA = "0xD89818")]
	private static Texture2D GetWorldIcon(WorldFileData worldData)
	{
		return null;
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001255")]
	[Address(RVA = "0xD89988", Offset = "0xD89988", VA = "0xD89988")]
	private static void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001256")]
	[Address(RVA = "0xD8A9B8", Offset = "0xD8A9B8", VA = "0xD8A9B8")]
	public GUISaveSynchronisation_FileList()
	{
	}

	// Token: 0x0400239D RID: 9117
	[Token(Token = "0x400239D")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x0400239E RID: 9118
	[Token(Token = "0x400239E")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x0400239F RID: 9119
	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0x0")]
	private static GUIControllerSaveSynchronisation_FileListWorld _worldController;

	// Token: 0x040023A0 RID: 9120
	[Token(Token = "0x40023A0")]
	[FieldOffset(Offset = "0x4")]
	private static GUIControllerSaveSynchronisation_FileListPlayer _playerController;

	// Token: 0x040023A1 RID: 9121
	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0x8")]
	private static GUISaveSynchronisation_FileList.Filter CurrentFilter;

	// Token: 0x040023A2 RID: 9122
	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0xC")]
	private static Vector2 CharacterOffset;

	// Token: 0x040023A3 RID: 9123
	[Token(Token = "0x40023A3")]
	[FieldOffset(Offset = "0x14")]
	private static int playerOver;

	// Token: 0x040023A4 RID: 9124
	[Token(Token = "0x40023A4")]
	[FieldOffset(Offset = "0x18")]
	public static List<PlayerFileData> SortedPlayerData;

	// Token: 0x040023A5 RID: 9125
	[Token(Token = "0x40023A5")]
	[FieldOffset(Offset = "0x1C")]
	public static int SelectedPlayerItem;

	// Token: 0x040023A6 RID: 9126
	[Token(Token = "0x40023A6")]
	[FieldOffset(Offset = "0x20")]
	public static float ScrollOffset;

	// Token: 0x040023A7 RID: 9127
	[Token(Token = "0x40023A7")]
	[FieldOffset(Offset = "0x24")]
	private static float ScrollMomentum;

	// Token: 0x040023A8 RID: 9128
	[Token(Token = "0x40023A8")]
	[FieldOffset(Offset = "0x28")]
	private static int ScrollDragging;

	// Token: 0x040023A9 RID: 9129
	[Token(Token = "0x40023A9")]
	[FieldOffset(Offset = "0x2C")]
	private static Vector2 DragOffset;

	// Token: 0x040023AA RID: 9130
	[Token(Token = "0x40023AA")]
	[FieldOffset(Offset = "0x34")]
	private static int worldOver;

	// Token: 0x040023AB RID: 9131
	[Token(Token = "0x40023AB")]
	[FieldOffset(Offset = "0x38")]
	public static List<WorldFileData> SortedWorldData;

	// Token: 0x040023AC RID: 9132
	[Token(Token = "0x40023AC")]
	[FieldOffset(Offset = "0x3C")]
	public static int SelectedWorldItem;

	// Token: 0x040023AD RID: 9133
	[Token(Token = "0x40023AD")]
	[FieldOffset(Offset = "0x40")]
	private static DateTime LastSelectTime;

	// Token: 0x040023AE RID: 9134
	[Token(Token = "0x40023AE")]
	[FieldOffset(Offset = "0x48")]
	private static DateTime LastTouchTime;

	// Token: 0x040023AF RID: 9135
	[Token(Token = "0x40023AF")]
	[FieldOffset(Offset = "0x50")]
	private static Vector2 LastTouchMouse;

	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	private enum Filter
	{
		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		LocalPlayers,
		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		LocalWorlds,
		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		ServerPlayers,
		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		ServerWorlds
	}
}
