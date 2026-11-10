using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200029D RID: 669
[Token(Token = "0x200029D")]
public class GUIMultiplayerLobby
{
	// Token: 0x06000FCC RID: 4044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0xCD0858", Offset = "0xCD0858", VA = "0xCD0858")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019A")]
	private GUIContollerTransactionButtonList MultiplayerLobbyOptionsController
	{
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0xCD0998", Offset = "0xCD0998", VA = "0xCD0998")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0xCD0B24", Offset = "0xCD0B24", VA = "0xCD0B24")]
	private GUIMultiplayerLobby.ServerInformation NewServerInformation(string worldName, string hostName, string serverIPText, int port, int players, int maxPlayers, int worldWidth, bool corruption, short gameMode, bool hardMode, bool active, bool favorite, int realID, bool isCrossplay, bool isSkyWorld, string password, MPSessionManager.MPSessionFriendSearchEntry existingSession, GUIMultiplayerLobby.ServerInformation.EntryType typeId)
	{
		return null;
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0xCD0D28", Offset = "0xCD0D28", VA = "0xCD0D28")]
	private GUIMultiplayerLobby.ServerInformation NewServerInformation(GUIMultiplayerLobby.ServerInformation.EntryType typeId)
	{
		return null;
	}

	// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0xCD0E94", Offset = "0xCD0E94", VA = "0xCD0E94")]
	public void Draw()
	{
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0xCD380C", Offset = "0xCD380C", VA = "0xCD380C")]
	private void DrawPlatformFriends()
	{
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0xCD15C0", Offset = "0xCD15C0", VA = "0xCD15C0")]
	private void DrawCategoryButtons()
	{
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0xCCA188", Offset = "0xCCA188", VA = "0xCCA188")]
	public void Startup()
	{
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0xCD3E04", Offset = "0xCD3E04", VA = "0xCD3E04")]
	public void Shutdown()
	{
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0xCD3E9C", Offset = "0xCD3E9C", VA = "0xCD3E9C")]
	private void DrawSettings()
	{
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0xCD1B3C", Offset = "0xCD1B3C", VA = "0xCD1B3C")]
	private void DrawHost()
	{
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0xCD1BC8", Offset = "0xCD1BC8", VA = "0xCD1BC8")]
	private void DrawJoin()
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0xCD416C", Offset = "0xCD416C", VA = "0xCD416C")]
	private void DrawFriendProfile(PlatformUser user, Panel_Layout friendPanel)
	{
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0xCD4778", Offset = "0xCD4778", VA = "0xCD4778")]
	public List<PlatformUser> GetSessionUsers(GUIMultiplayerLobby.ServerInformation serverData)
	{
		return null;
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0xCD2B00", Offset = "0xCD2B00", VA = "0xCD2B00")]
	private void DrawOptions()
	{
	}

	// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0xCD4604", Offset = "0xCD4604", VA = "0xCD4604")]
	public Texture2D GetHostPlayerIcon(PlatformUser user)
	{
		return null;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0xCD46F4", Offset = "0xCD46F4", VA = "0xCD46F4")]
	public void DisplayUserProfile(PlatformUser user)
	{
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0xCD5D10", Offset = "0xCD5D10", VA = "0xCD5D10")]
	public string SelectedUserProfileName(PlatformUser user)
	{
		return null;
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0xCD5E08", Offset = "0xCD5E08", VA = "0xCD5E08")]
	private void AddInviteCode()
	{
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0xCD5ED0", Offset = "0xCD5ED0", VA = "0xCD5ED0")]
	private void AddPlatformFriendGames()
	{
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0xCD676C", Offset = "0xCD676C", VA = "0xCD676C")]
	private void AddLANGames()
	{
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0xCD6E60", Offset = "0xCD6E60", VA = "0xCD6E60")]
	private void AddServerGames()
	{
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0xCD38B8", Offset = "0xCD38B8", VA = "0xCD38B8")]
	private void RefreshGames()
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0xCD736C", Offset = "0xCD736C", VA = "0xCD736C")]
	private Texture2D GetIcon(GUIMultiplayerLobby.ServerInformation serverData)
	{
		return null;
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0xCD7450", Offset = "0xCD7450", VA = "0xCD7450")]
	private void DrawServer(GUIMultiplayerLobby.ServerInformation serverData)
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0xCD7664", Offset = "0xCD7664", VA = "0xCD7664")]
	private void JoinServerCheck()
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00007DB8 File Offset: 0x00005FB8
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0xCD7DE8", Offset = "0xCD7DE8", VA = "0xCD7DE8")]
	public Vector2 ServerItemSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0xCD8090", Offset = "0xCD8090", VA = "0xCD8090")]
	private void ServerSearchingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0xCD8790", Offset = "0xCD8790", VA = "0xCD8790")]
	private void ServerDedicatedMissingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700019B")]
	private GUIMultiplayerLobby.GUILobbyToggleSetting CrossPlayerToggleSetting
	{
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0xCD8AA0", Offset = "0xCD8AA0", VA = "0xCD8AA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0xCD4B58", Offset = "0xCD4B58", VA = "0xCD4B58")]
	private void InviteCodeDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0xCD8C44", Offset = "0xCD8C44", VA = "0xCD8C44")]
	private void CloseInviteCodeEdit()
	{
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0xCD8B2C", Offset = "0xCD8B2C", VA = "0xCD8B2C")]
	private void EnterInviteCode()
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00007DD0 File Offset: 0x00005FD0
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0xCD8CFC", Offset = "0xCD8CFC", VA = "0xCD8CFC")]
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0xCD8DA4", Offset = "0xCD8DA4", VA = "0xCD8DA4")]
	private void ServerHeaderDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0xCD991C", Offset = "0xCD991C", VA = "0xCD991C")]
	private void ServerSeperatorDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0xCD9A70", Offset = "0xCD9A70", VA = "0xCD9A70")]
	private void ServerDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0xCD2848", Offset = "0xCD2848", VA = "0xCD2848")]
	private void DrawMainButtons()
	{
	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0xCD1474", Offset = "0xCD1474", VA = "0xCD1474")]
	public void Back()
	{
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00007DE8 File Offset: 0x00005FE8
	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0xCDB2A4", Offset = "0xCDB2A4", VA = "0xCDB2A4")]
	private float ServerScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0xCDB2AC", Offset = "0xCDB2AC", VA = "0xCDB2AC")]
	private void ServerOver(int index)
	{
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0xCDB2B4", Offset = "0xCDB2B4", VA = "0xCDB2B4")]
	public GUIMultiplayerLobby.ServerInformation ActiveServer()
	{
		return null;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0xCD77F4", Offset = "0xCD77F4", VA = "0xCD77F4")]
	private void JoinServer()
	{
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0xCD3F28", Offset = "0xCD3F28", VA = "0xCD3F28")]
	public void StartNewServer()
	{
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0xCDB320", Offset = "0xCDB320", VA = "0xCDB320")]
	private void AddDedicatedServer()
	{
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x00007E00 File Offset: 0x00006000
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0xCDB5A4", Offset = "0xCDB5A4", VA = "0xCDB5A4")]
	private int SortEntry(GUIMultiplayerLobby.ServerInformation a, GUIMultiplayerLobby.ServerInformation b)
	{
		return 0;
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0xCDB6AC", Offset = "0xCDB6AC", VA = "0xCDB6AC")]
	public int CompareNatural(string strA, string strB)
	{
		return 0;
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0xCDB738", Offset = "0xCDB738", VA = "0xCDB738")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return 0;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0xCDC08C", Offset = "0xCDC08C", VA = "0xCDC08C")]
	public GUIMultiplayerLobby()
	{
	}

	// Token: 0x04001FF9 RID: 8185
	[Token(Token = "0x4001FF9")]
	[FieldOffset(Offset = "0x8")]
	public GUIMultiplayerLobby.ItemSelection CurrentSelection;

	// Token: 0x04001FFA RID: 8186
	[Token(Token = "0x4001FFA")]
	[FieldOffset(Offset = "0xC")]
	public bool NoPlatformFriends;

	// Token: 0x04001FFB RID: 8187
	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x10")]
	private float localScale;

	// Token: 0x04001FFC RID: 8188
	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x14")]
	private float dedicatedScale;

	// Token: 0x04001FFD RID: 8189
	[Token(Token = "0x4001FFD")]
	[FieldOffset(Offset = "0x18")]
	private float joinButtonScale;

	// Token: 0x04001FFE RID: 8190
	[Token(Token = "0x4001FFE")]
	[FieldOffset(Offset = "0x1C")]
	private float backButtonScale;

	// Token: 0x04001FFF RID: 8191
	[Token(Token = "0x4001FFF")]
	[FieldOffset(Offset = "0x20")]
	private float NewScale;

	// Token: 0x04002000 RID: 8192
	[Token(Token = "0x4002000")]
	[FieldOffset(Offset = "0x24")]
	private float TitleScale;

	// Token: 0x04002001 RID: 8193
	[Token(Token = "0x4002001")]
	[FieldOffset(Offset = "0x28")]
	private float DeleteScale;

	// Token: 0x04002002 RID: 8194
	[Token(Token = "0x4002002")]
	[FieldOffset(Offset = "0x2C")]
	public int previousMenu;

	// Token: 0x04002003 RID: 8195
	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0x30")]
	private DateTime LastSelectTime;

	// Token: 0x04002004 RID: 8196
	[Token(Token = "0x4002004")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04002005 RID: 8197
	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0x38")]
	public float ScrollOffset;

	// Token: 0x04002006 RID: 8198
	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0x3C")]
	private float ScrollMomentum;

	// Token: 0x04002007 RID: 8199
	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x40")]
	private int ScrollDragging;

	// Token: 0x04002008 RID: 8200
	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 DragOffset;

	// Token: 0x04002009 RID: 8201
	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0x4C")]
	public bool FriendsCollapsed;

	// Token: 0x0400200A RID: 8202
	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x4D")]
	public bool LanCollapsed;

	// Token: 0x0400200B RID: 8203
	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x4E")]
	public bool DedicatedCollapsed;

	// Token: 0x0400200C RID: 8204
	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x50")]
	private Rectangle SelectedItemRegion;

	// Token: 0x0400200D RID: 8205
	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x60")]
	private bool serverJoinAvailable;

	// Token: 0x0400200E RID: 8206
	[Token(Token = "0x400200E")]
	[FieldOffset(Offset = "0x0")]
	private static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x0400200F RID: 8207
	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x4")]
	private static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04002010 RID: 8208
	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x64")]
	private GUIControllerMultiplayerLobby _controllerInput;

	// Token: 0x04002011 RID: 8209
	[Token(Token = "0x4002011")]
	[FieldOffset(Offset = "0x68")]
	private GUIContollerTransactionButtonList _multiplayerLobbyOptionsController;

	// Token: 0x04002012 RID: 8210
	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0x6C")]
	public int drawOptions;

	// Token: 0x04002013 RID: 8211
	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0x70")]
	public int selectedServer;

	// Token: 0x04002014 RID: 8212
	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0x74")]
	public List<GUIMultiplayerLobby.ServerInformation> avaiableList;

	// Token: 0x04002015 RID: 8213
	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0x78")]
	public List<GUIMultiplayerLobby.ServerInformation> serverList;

	// Token: 0x04002016 RID: 8214
	[Token(Token = "0x4002016")]
	[FieldOffset(Offset = "0x7C")]
	private Rectangle fullClipRegion;

	// Token: 0x04002017 RID: 8215
	[Token(Token = "0x4002017")]
	[FieldOffset(Offset = "0x8C")]
	private Rectangle dragClipRegion;

	// Token: 0x04002018 RID: 8216
	[Token(Token = "0x4002018")]
	[FieldOffset(Offset = "0x9C")]
	private List<PlatformUser> displaySessionUsers;

	// Token: 0x04002019 RID: 8217
	[Token(Token = "0x4002019")]
	[FieldOffset(Offset = "0xA0")]
	private GUIMultiplayerLobby.GUILobbyToggleSetting _crossPlayerToggleSetting;

	// Token: 0x0400201A RID: 8218
	[Token(Token = "0x400201A")]
	[FieldOffset(Offset = "0xA4")]
	private bool editingInviteCode;

	// Token: 0x0400201B RID: 8219
	[Token(Token = "0x400201B")]
	[FieldOffset(Offset = "0xA8")]
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400201C RID: 8220
	[Token(Token = "0x400201C")]
	[FieldOffset(Offset = "0xAC")]
	private string _inviteCode;

	// Token: 0x0400201D RID: 8221
	[Token(Token = "0x400201D")]
	[FieldOffset(Offset = "0xB0")]
	private ItemGrid_Layout editInviteCodeGridLayout;

	// Token: 0x0400201E RID: 8222
	[Token(Token = "0x400201E")]
	[FieldOffset(Offset = "0xB4")]
	private int editInviteCodeIndex;

	// Token: 0x0400201F RID: 8223
	[Token(Token = "0x400201F")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 editInviteCodePosition;

	// Token: 0x04002020 RID: 8224
	[Token(Token = "0x4002020")]
	[FieldOffset(Offset = "0xC0")]
	private float editInviteCodeScale;

	// Token: 0x04002021 RID: 8225
	[Token(Token = "0x4002021")]
	[FieldOffset(Offset = "0xC4")]
	private int serverOver;

	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	public enum ItemSelection
	{
		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		Host,
		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		Join
	}

	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	public class ServerInformation
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0xCDC294", Offset = "0xCDC294", VA = "0xCDC294")]
		public void Setup(GUIMultiplayerLobby.ServerInformation.EntryType typeId)
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0xCDC334", Offset = "0xCDC334", VA = "0xCDC334")]
		private static string FilterItem(string source)
		{
			return null;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0xCDC4CC", Offset = "0xCDC4CC", VA = "0xCDC4CC")]
		public static void ClearFilterCache()
		{
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001000")]
		[Address(RVA = "0xCDC564", Offset = "0xCDC564", VA = "0xCDC564")]
		public void Setup(string worldName, string hostName, string serverIPText, int port, int players, int maxPlayers, int worldWidth, bool corruption, short gameMode, bool hardMode, bool active, bool favorite, int realID, bool isCrossplay, bool skyblockWorld, string password, MPSessionManager.MPSessionFriendSearchEntry existingSession, GUIMultiplayerLobby.ServerInformation.EntryType typeId)
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001001")]
		[Address(RVA = "0xCDC698", Offset = "0xCDC698", VA = "0xCDC698")]
		public void UpdateSavedInfo(string serverAddress, int serverPort, string savedPassword)
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001002")]
		[Address(RVA = "0xCDC78C", Offset = "0xCDC78C", VA = "0xCDC78C")]
		public void RestoreSavedInfo()
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019C")]
		public string WorldSize
		{
			[Token(Token = "0x6001003")]
			[Address(RVA = "0xCDC86C", Offset = "0xCDC86C", VA = "0xCDC86C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001004")]
		[Address(RVA = "0xCDCA1C", Offset = "0xCDCA1C", VA = "0xCDCA1C")]
		public ServerInformation()
		{
		}

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, string> filteredData;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x8")]
		public GUIMultiplayerLobby.ServerInformation.EntryType TypeId;

		// Token: 0x04002027 RID: 8231
		[Token(Token = "0x4002027")]
		[FieldOffset(Offset = "0xC")]
		public int RealID;

		// Token: 0x04002028 RID: 8232
		[Token(Token = "0x4002028")]
		[FieldOffset(Offset = "0x10")]
		public string WorldName;

		// Token: 0x04002029 RID: 8233
		[Token(Token = "0x4002029")]
		[FieldOffset(Offset = "0x14")]
		public int CurrentPlayers;

		// Token: 0x0400202A RID: 8234
		[Token(Token = "0x400202A")]
		[FieldOffset(Offset = "0x18")]
		public int MaxPlayers;

		// Token: 0x0400202B RID: 8235
		[Token(Token = "0x400202B")]
		[FieldOffset(Offset = "0x1C")]
		public int WorldWidth;

		// Token: 0x0400202C RID: 8236
		[Token(Token = "0x400202C")]
		[FieldOffset(Offset = "0x20")]
		public bool HasCorruption;

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[FieldOffset(Offset = "0x22")]
		public short GameMode;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		[FieldOffset(Offset = "0x24")]
		public bool IsHardMode;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x28")]
		public string ServerIPText;

		// Token: 0x04002030 RID: 8240
		[Token(Token = "0x4002030")]
		[FieldOffset(Offset = "0x2C")]
		public int ServerPort;

		// Token: 0x04002031 RID: 8241
		[Token(Token = "0x4002031")]
		[FieldOffset(Offset = "0x30")]
		public string HostName;

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		[FieldOffset(Offset = "0x34")]
		public bool Active;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x35")]
		public bool Favorite;

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x36")]
		public bool IsCrossplay;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x38")]
		public string SavedPassword;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x3C")]
		public bool SkyblockWorld;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x40")]
		public MPSessionManager.MPSessionFriendSearchEntry ExistingSession;

		// Token: 0x020002A0 RID: 672
		[Token(Token = "0x20002A0")]
		public enum EntryType
		{
			// Token: 0x04002039 RID: 8249
			[Token(Token = "0x4002039")]
			None,
			// Token: 0x0400203A RID: 8250
			[Token(Token = "0x400203A")]
			LANCrossplaySetting,
			// Token: 0x0400203B RID: 8251
			[Token(Token = "0x400203B")]
			InviteCode,
			// Token: 0x0400203C RID: 8252
			[Token(Token = "0x400203C")]
			FriendHeader,
			// Token: 0x0400203D RID: 8253
			[Token(Token = "0x400203D")]
			FriendSearching,
			// Token: 0x0400203E RID: 8254
			[Token(Token = "0x400203E")]
			FriendGame,
			// Token: 0x0400203F RID: 8255
			[Token(Token = "0x400203F")]
			FriendSeperator,
			// Token: 0x04002040 RID: 8256
			[Token(Token = "0x4002040")]
			LANHeader,
			// Token: 0x04002041 RID: 8257
			[Token(Token = "0x4002041")]
			LANSearching,
			// Token: 0x04002042 RID: 8258
			[Token(Token = "0x4002042")]
			LANGame,
			// Token: 0x04002043 RID: 8259
			[Token(Token = "0x4002043")]
			LANSeperator,
			// Token: 0x04002044 RID: 8260
			[Token(Token = "0x4002044")]
			DedicatedHeader,
			// Token: 0x04002045 RID: 8261
			[Token(Token = "0x4002045")]
			DedicatedGame,
			// Token: 0x04002046 RID: 8262
			[Token(Token = "0x4002046")]
			DedicatedMissing
		}
	}

	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public class GUILobbyToggleSetting : GUIToggleSetting
	{
		// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001006")]
		[Address(RVA = "0xCDCAD0", Offset = "0xCDCAD0", VA = "0xCDCAD0")]
		public GUILobbyToggleSetting(GUISettingID id)
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001007")]
		[Address(RVA = "0xCDCAD8", Offset = "0xCDCAD8", VA = "0xCDCAD8", Slot = "7")]
		protected override SettingsOverlayToggle_Layout GetLayout()
		{
			return null;
		}
	}
}
