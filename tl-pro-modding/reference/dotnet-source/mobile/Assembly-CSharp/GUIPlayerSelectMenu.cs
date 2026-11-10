using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;

// Token: 0x020002B0 RID: 688
[Token(Token = "0x20002B0")]
public class GUIPlayerSelectMenu
{
	// Token: 0x06001064 RID: 4196 RVA: 0x00007F38 File Offset: 0x00006138
	[Token(Token = "0x6001064")]
	[Address(RVA = "0xCF55EC", Offset = "0xCF55EC", VA = "0xCF55EC")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0xCF55F4", Offset = "0xCF55F4", VA = "0xCF55F4")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001066")]
	[Address(RVA = "0xCF58F0", Offset = "0xCF58F0", VA = "0xCF58F0")]
	public void ActionNew()
	{
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001A3")]
	private GUIContollerTransactionButtonList PlayerListOptionsController
	{
		[Token(Token = "0x6001067")]
		[Address(RVA = "0xCF59B8", Offset = "0xCF59B8", VA = "0xCF59B8")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001068")]
	[Address(RVA = "0xCF5B44", Offset = "0xCF5B44", VA = "0xCF5B44")]
	private void DrawPlayerSync()
	{
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x00007F50 File Offset: 0x00006150
	[Token(Token = "0x6001069")]
	[Address(RVA = "0xCF5E04", Offset = "0xCF5E04", VA = "0xCF5E04")]
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x00007F68 File Offset: 0x00006168
	[Token(Token = "0x600106A")]
	[Address(RVA = "0xCF5FA8", Offset = "0xCF5FA8", VA = "0xCF5FA8")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00007F80 File Offset: 0x00006180
	[Token(Token = "0x600106B")]
	[Address(RVA = "0xCF6004", Offset = "0xCF6004", VA = "0xCF6004")]
	public Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106C")]
	[Address(RVA = "0xCF6094", Offset = "0xCF6094", VA = "0xCF6094")]
	public void SelectAndHighlight(PlayerFileData playerData)
	{
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106D")]
	[Address(RVA = "0xCF62EC", Offset = "0xCF62EC", VA = "0xCF62EC")]
	public void Draw()
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106E")]
	[Address(RVA = "0xCF81B4", Offset = "0xCF81B4", VA = "0xCF81B4")]
	public void Back()
	{
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106F")]
	[Address(RVA = "0xCF8CDC", Offset = "0xCF8CDC", VA = "0xCF8CDC")]
	private void UpdateAnim(Player player, bool animated)
	{
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001070")]
	[Address(RVA = "0xCF8F54", Offset = "0xCF8F54", VA = "0xCF8F54")]
	private void DrawPlayer(Player player, Projectile pet, bool animated)
	{
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001071")]
	[Address(RVA = "0xCF928C", Offset = "0xCF928C", VA = "0xCF928C")]
	public void DrawPet(Player player, Projectile proj, Vector2 playerPosition, bool animated)
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001072")]
	[Address(RVA = "0xCF976C", Offset = "0xCF976C", VA = "0xCF976C")]
	public void DrawPlayerUI(Player player, Vector2 origin, Vector2 size)
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001073")]
	[Address(RVA = "0xCF9DF0", Offset = "0xCF9DF0", VA = "0xCF9DF0")]
	public void RefreshPlayers()
	{
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001074")]
	[Address(RVA = "0xCF8908", Offset = "0xCF8908", VA = "0xCF8908")]
	private void OpenNameEdit()
	{
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001075")]
	[Address(RVA = "0xCF8A08", Offset = "0xCF8A08", VA = "0xCF8A08")]
	private void CloseNameEditAndSave()
	{
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00007F98 File Offset: 0x00006198
	[Token(Token = "0x6001076")]
	[Address(RVA = "0xCF83F0", Offset = "0xCF83F0", VA = "0xCF83F0")]
	private bool CloseNameEditIf()
	{
		return default(bool);
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001077")]
	[Address(RVA = "0xCF9F74", Offset = "0xCF9F74", VA = "0xCF9F74")]
	private void CloseNameEdit()
	{
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00007FB0 File Offset: 0x000061B0
	[Token(Token = "0x6001078")]
	[Address(RVA = "0xCF8530", Offset = "0xCF8530", VA = "0xCF8530")]
	private static bool CanSelectPlayer(PlayerFileData playerData)
	{
		return default(bool);
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001079")]
	[Address(RVA = "0xCFA008", Offset = "0xCFA008", VA = "0xCFA008")]
	private void PlayerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107A")]
	[Address(RVA = "0xCFC21C", Offset = "0xCFC21C", VA = "0xCFC21C")]
	public void SortPlayers()
	{
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00007FC8 File Offset: 0x000061C8
	[Token(Token = "0x600107B")]
	[Address(RVA = "0xCFBFF0", Offset = "0xCFBFF0", VA = "0xCFBFF0")]
	private static bool CanPlayerBePlayed(PlayerFileData playerData)
	{
		return default(bool);
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00007FE0 File Offset: 0x000061E0
	[Token(Token = "0x600107C")]
	[Address(RVA = "0xCFC5C8", Offset = "0xCFC5C8", VA = "0xCFC5C8")]
	private int SortEntry(PlayerFileData a, PlayerFileData b)
	{
		return 0;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00007FF8 File Offset: 0x000061F8
	[Token(Token = "0x600107D")]
	[Address(RVA = "0xCFC83C", Offset = "0xCFC83C", VA = "0xCFC83C")]
	private float PlayerScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107E")]
	[Address(RVA = "0xCFC844", Offset = "0xCFC844", VA = "0xCFC844")]
	private void PlayerOver(int index)
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00008010 File Offset: 0x00006210
	[Token(Token = "0x600107F")]
	[Address(RVA = "0xCFC7B4", Offset = "0xCFC7B4", VA = "0xCFC7B4")]
	public int CompareNatural(string strA, string strB)
	{
		return 0;
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00008028 File Offset: 0x00006228
	[Token(Token = "0x6001080")]
	[Address(RVA = "0xCFC990", Offset = "0xCFC990", VA = "0xCFC990")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return 0;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001081")]
	[Address(RVA = "0xCFD2E4", Offset = "0xCFD2E4", VA = "0xCFD2E4")]
	public GUIPlayerSelectMenu()
	{
	}

	// Token: 0x040020C6 RID: 8390
	[Token(Token = "0x40020C6")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x040020C7 RID: 8391
	[Token(Token = "0x40020C7")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x040020C8 RID: 8392
	[Token(Token = "0x40020C8")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x040020C9 RID: 8393
	[Token(Token = "0x40020C9")]
	[FieldOffset(Offset = "0x8")]
	private float TitleScale;

	// Token: 0x040020CA RID: 8394
	[Token(Token = "0x40020CA")]
	[FieldOffset(Offset = "0xC")]
	private float BackScale;

	// Token: 0x040020CB RID: 8395
	[Token(Token = "0x40020CB")]
	[FieldOffset(Offset = "0x10")]
	private float NewScale;

	// Token: 0x040020CC RID: 8396
	[Token(Token = "0x40020CC")]
	[FieldOffset(Offset = "0x14")]
	private float PlayScale;

	// Token: 0x040020CD RID: 8397
	[Token(Token = "0x40020CD")]
	[FieldOffset(Offset = "0x18")]
	private float EditNameScale;

	// Token: 0x040020CE RID: 8398
	[Token(Token = "0x40020CE")]
	[FieldOffset(Offset = "0x1C")]
	private float OptionsScale;

	// Token: 0x040020CF RID: 8399
	[Token(Token = "0x40020CF")]
	[FieldOffset(Offset = "0x20")]
	private float DeleteScale;

	// Token: 0x040020D0 RID: 8400
	[Token(Token = "0x40020D0")]
	[FieldOffset(Offset = "0x24")]
	private float FavoriteScale;

	// Token: 0x040020D1 RID: 8401
	[Token(Token = "0x40020D1")]
	[FieldOffset(Offset = "0x28")]
	public float ScrollOffset;

	// Token: 0x040020D2 RID: 8402
	[Token(Token = "0x40020D2")]
	[FieldOffset(Offset = "0x2C")]
	private float ScrollMomentum;

	// Token: 0x040020D3 RID: 8403
	[Token(Token = "0x40020D3")]
	[FieldOffset(Offset = "0x30")]
	private int ScrollDragging;

	// Token: 0x040020D4 RID: 8404
	[Token(Token = "0x40020D4")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 DragOffset;

	// Token: 0x040020D5 RID: 8405
	[Token(Token = "0x40020D5")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D _dividerTexture;

	// Token: 0x040020D6 RID: 8406
	[Token(Token = "0x40020D6")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D _buttonCloudActiveTexture;

	// Token: 0x040020D7 RID: 8407
	[Token(Token = "0x40020D7")]
	[FieldOffset(Offset = "0x8")]
	private static Texture2D _buttonCloudInactiveTexture;

	// Token: 0x040020D8 RID: 8408
	[Token(Token = "0x40020D8")]
	[FieldOffset(Offset = "0xC")]
	private static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x040020D9 RID: 8409
	[Token(Token = "0x40020D9")]
	[FieldOffset(Offset = "0x10")]
	private static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x040020DA RID: 8410
	[Token(Token = "0x40020DA")]
	[FieldOffset(Offset = "0x14")]
	private static Texture2D _buttonPlayTexture;

	// Token: 0x040020DB RID: 8411
	[Token(Token = "0x40020DB")]
	[FieldOffset(Offset = "0x18")]
	private static Texture2D _buttonDeleteTexture;

	// Token: 0x040020DC RID: 8412
	[Token(Token = "0x40020DC")]
	[FieldOffset(Offset = "0x3C")]
	private int _playerCount;

	// Token: 0x040020DD RID: 8413
	[Token(Token = "0x40020DD")]
	[FieldOffset(Offset = "0x40")]
	public List<PlayerFileData> SortedPlayerData;

	// Token: 0x040020DE RID: 8414
	[Token(Token = "0x40020DE")]
	[FieldOffset(Offset = "0x44")]
	private Rectangle SelectedItemRegion;

	// Token: 0x040020DF RID: 8415
	[Token(Token = "0x40020DF")]
	[FieldOffset(Offset = "0x54")]
	public int SelectedItem;

	// Token: 0x040020E0 RID: 8416
	[Token(Token = "0x40020E0")]
	[FieldOffset(Offset = "0x58")]
	public string SelectedItemPlayer;

	// Token: 0x040020E1 RID: 8417
	[Token(Token = "0x40020E1")]
	[FieldOffset(Offset = "0x60")]
	private DateTime LastSelectTime;

	// Token: 0x040020E2 RID: 8418
	[Token(Token = "0x40020E2")]
	[FieldOffset(Offset = "0x68")]
	private DateTime LastTouchTime;

	// Token: 0x040020E3 RID: 8419
	[Token(Token = "0x40020E3")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 LastTouchMouse;

	// Token: 0x040020E4 RID: 8420
	[Token(Token = "0x40020E4")]
	[FieldOffset(Offset = "0x78")]
	private float NameScale;

	// Token: 0x040020E5 RID: 8421
	[Token(Token = "0x40020E5")]
	[FieldOffset(Offset = "0x7C")]
	public bool allowItemClicking;

	// Token: 0x040020E6 RID: 8422
	[Token(Token = "0x40020E6")]
	[FieldOffset(Offset = "0x80")]
	private GUIControllerPlayerSelect _controllerInput;

	// Token: 0x040020E7 RID: 8423
	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0x84")]
	private GUIContollerTransactionButtonList _playerListOptionsController;

	// Token: 0x040020E8 RID: 8424
	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0x88")]
	private Rectangle fullClipRegion;

	// Token: 0x040020E9 RID: 8425
	[Token(Token = "0x40020E9")]
	[FieldOffset(Offset = "0x98")]
	private Rectangle dragClipRegion;

	// Token: 0x040020EA RID: 8426
	[Token(Token = "0x40020EA")]
	[FieldOffset(Offset = "0xA8")]
	private Vector2 CharacterOffset;

	// Token: 0x040020EB RID: 8427
	[Token(Token = "0x40020EB")]
	[FieldOffset(Offset = "0xB0")]
	private Item _blankItem;

	// Token: 0x040020EC RID: 8428
	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0xB4")]
	private int SelectedItemForTextEdit;

	// Token: 0x040020ED RID: 8429
	[Token(Token = "0x40020ED")]
	[FieldOffset(Offset = "0xB8")]
	private int playerOver;

	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	private sealed class <>c__DisplayClass46_0
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001082")]
		[Address(RVA = "0xCF81AC", Offset = "0xCF81AC", VA = "0xCF81AC")]
		public <>c__DisplayClass46_0()
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001083")]
		[Address(RVA = "0xCFD550", Offset = "0xCFD550", VA = "0xCFD550")]
		internal void <Draw>b__0()
		{
		}

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		[FieldOffset(Offset = "0x8")]
		public PlayerFileData playerData;
	}

	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	private sealed class <>c__DisplayClass61_0
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001084")]
		[Address(RVA = "0xCFBFE8", Offset = "0xCFBFE8", VA = "0xCFBFE8")]
		public <>c__DisplayClass61_0()
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001085")]
		[Address(RVA = "0xCFD5BC", Offset = "0xCFD5BC", VA = "0xCFD5BC")]
		internal void <PlayerDraw>b__0()
		{
		}

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		[FieldOffset(Offset = "0x8")]
		public PlayerFileData playerData;
	}
}
