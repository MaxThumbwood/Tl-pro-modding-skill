using System;
using System.Collections.Generic;
using System.Globalization;
using Controller;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

// Token: 0x020002CC RID: 716
[Token(Token = "0x20002CC")]
public class GUIWorldSelectMenu
{
	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x06001191 RID: 4497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B0")]
	private GUIContollerTransactionButtonList WorldListOptionsController
	{
		[Token(Token = "0x6001191")]
		[Address(RVA = "0xD45D1C", Offset = "0xD45D1C", VA = "0xD45D1C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001192")]
	[Address(RVA = "0xD45EA8", Offset = "0xD45EA8", VA = "0xD45EA8")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x000084C0 File Offset: 0x000066C0
	[Token(Token = "0x6001193")]
	[Address(RVA = "0xD46250", Offset = "0xD46250", VA = "0xD46250")]
	private Rectangle UpdateGlitchAnimation(WorldFileData worldData)
	{
		return default(Rectangle);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001194")]
	[Address(RVA = "0xD4653C", Offset = "0xD4653C", VA = "0xD4653C")]
	private Texture2D GetIcon(WorldFileData worldData, out bool mixedSeed)
	{
		return null;
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001195")]
	[Address(RVA = "0xD46F3C", Offset = "0xD46F3C", VA = "0xD46F3C")]
	private Texture2D GetSeedIcon(WorldFileData worldData, string seed)
	{
		return null;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001196")]
	[Address(RVA = "0xD47094", Offset = "0xD47094", VA = "0xD47094")]
	public static Texture2D GetSeedIcon(bool hardMode, bool corruption, bool skyblock, string seed = "")
	{
		return null;
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001197")]
	[Address(RVA = "0xD47220", Offset = "0xD47220", VA = "0xD47220")]
	private void PlayWorldCheck()
	{
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001198")]
	[Address(RVA = "0xD47524", Offset = "0xD47524", VA = "0xD47524")]
	public void ActionNew()
	{
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x000084D8 File Offset: 0x000066D8
	[Token(Token = "0x6001199")]
	[Address(RVA = "0xD47830", Offset = "0xD47830", VA = "0xD47830")]
	private bool DrawMenuButton(string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x000084F0 File Offset: 0x000066F0
	[Token(Token = "0x600119A")]
	[Address(RVA = "0xD479E0", Offset = "0xD479E0", VA = "0xD479E0")]
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, ref float scale, bool disabled)
	{
		return default(bool);
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x00008508 File Offset: 0x00006708
	[Token(Token = "0x600119B")]
	[Address(RVA = "0xD47A3C", Offset = "0xD47A3C", VA = "0xD47A3C")]
	public Vector2 ItemSize(int index)
	{
		return default(Vector2);
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119C")]
	[Address(RVA = "0xD47ACC", Offset = "0xD47ACC", VA = "0xD47ACC")]
	private void DrawWorldSync()
	{
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119D")]
	[Address(RVA = "0xD47D8C", Offset = "0xD47D8C", VA = "0xD47D8C")]
	public void SelectAndHighlight(WorldFileData worldDataOld)
	{
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119E")]
	[Address(RVA = "0xD4818C", Offset = "0xD4818C", VA = "0xD4818C")]
	private void OpenNameEdit()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600119F")]
	[Address(RVA = "0xD4827C", Offset = "0xD4827C", VA = "0xD4827C")]
	private void CloseNameEditAndSaveIf()
	{
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A0")]
	[Address(RVA = "0xD48678", Offset = "0xD48678", VA = "0xD48678")]
	private void CloseNameEditIf()
	{
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0xD485E8", Offset = "0xD485E8", VA = "0xD485E8")]
	private void CloseNameEdit()
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0xD48784", Offset = "0xD48784", VA = "0xD48784")]
	public void Draw()
	{
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0xD4A87C", Offset = "0xD4A87C", VA = "0xD4A87C")]
	public void Back()
	{
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0xD466AC", Offset = "0xD466AC", VA = "0xD466AC")]
	private void GetIcons(WorldFileData worldData, List<Texture2D> icons)
	{
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0xD4AB7C", Offset = "0xD4AB7C", VA = "0xD4AB7C")]
	private void DrawWorld(WorldFileData worldData)
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00008520 File Offset: 0x00006720
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0xD4B15C", Offset = "0xD4B15C", VA = "0xD4B15C")]
	public bool IsNewlyGenerated(WorldFileData file)
	{
		return default(bool);
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0xD4B1AC", Offset = "0xD4B1AC", VA = "0xD4B1AC")]
	public void ClearNewlyGenerated()
	{
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0xD4B1B8", Offset = "0xD4B1B8", VA = "0xD4B1B8")]
	private void WorldDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0xD4737C", Offset = "0xD4737C", VA = "0xD4737C")]
	private void PlayWorld()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0xD4D5C4", Offset = "0xD4D5C4", VA = "0xD4D5C4")]
	public void SortWorlds()
	{
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00008538 File Offset: 0x00006738
	[Token(Token = "0x60011AB")]
	[Address(RVA = "0xD4D80C", Offset = "0xD4D80C", VA = "0xD4D80C")]
	private int SortEntry(WorldFileData a, WorldFileData b)
	{
		return 0;
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00008550 File Offset: 0x00006750
	[Token(Token = "0x60011AC")]
	[Address(RVA = "0xD4AA98", Offset = "0xD4AA98", VA = "0xD4AA98")]
	private bool CanWorldBePlayed(WorldFileData world)
	{
		return default(bool);
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00008568 File Offset: 0x00006768
	[Token(Token = "0x60011AD")]
	[Address(RVA = "0xD4DC48", Offset = "0xD4DC48", VA = "0xD4DC48")]
	private float WorldScale(int index)
	{
		return 0f;
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AE")]
	[Address(RVA = "0xD4DC50", Offset = "0xD4DC50", VA = "0xD4DC50")]
	private void WorldOver(int index)
	{
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00008580 File Offset: 0x00006780
	[Token(Token = "0x60011AF")]
	[Address(RVA = "0xD4DBC0", Offset = "0xD4DBC0", VA = "0xD4DBC0")]
	public int CompareNatural(string strA, string strB)
	{
		return 0;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x60011B0")]
	[Address(RVA = "0xD4DD98", Offset = "0xD4DD98", VA = "0xD4DD98")]
	public int CompareNatural(string strA, string strB, CultureInfo culture, CompareOptions options)
	{
		return 0;
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B1")]
	[Address(RVA = "0xD4E6EC", Offset = "0xD4E6EC", VA = "0xD4E6EC")]
	public GUIWorldSelectMenu()
	{
	}

	// Token: 0x04002252 RID: 8786
	[Token(Token = "0x4002252")]
	private const double DOUBLE_CLICK_TIME = 500.0;

	// Token: 0x04002253 RID: 8787
	[Token(Token = "0x4002253")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x04002254 RID: 8788
	[Token(Token = "0x4002254")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04002255 RID: 8789
	[Token(Token = "0x4002255")]
	[FieldOffset(Offset = "0x8")]
	private float TitleScale;

	// Token: 0x04002256 RID: 8790
	[Token(Token = "0x4002256")]
	[FieldOffset(Offset = "0xC")]
	private float BackScale;

	// Token: 0x04002257 RID: 8791
	[Token(Token = "0x4002257")]
	[FieldOffset(Offset = "0x10")]
	private float NewScale;

	// Token: 0x04002258 RID: 8792
	[Token(Token = "0x4002258")]
	[FieldOffset(Offset = "0x14")]
	private float PlayScale;

	// Token: 0x04002259 RID: 8793
	[Token(Token = "0x4002259")]
	[FieldOffset(Offset = "0x18")]
	private float DeleteScale;

	// Token: 0x0400225A RID: 8794
	[Token(Token = "0x400225A")]
	[FieldOffset(Offset = "0x1C")]
	private float FavoriteScale;

	// Token: 0x0400225B RID: 8795
	[Token(Token = "0x400225B")]
	[FieldOffset(Offset = "0x20")]
	private float OptionsScale;

	// Token: 0x0400225C RID: 8796
	[Token(Token = "0x400225C")]
	[FieldOffset(Offset = "0x24")]
	private float RenameScale;

	// Token: 0x0400225D RID: 8797
	[Token(Token = "0x400225D")]
	[FieldOffset(Offset = "0x28")]
	private float SeedDisplayScale;

	// Token: 0x0400225E RID: 8798
	[Token(Token = "0x400225E")]
	[FieldOffset(Offset = "0x2C")]
	public float ScrollOffset;

	// Token: 0x0400225F RID: 8799
	[Token(Token = "0x400225F")]
	[FieldOffset(Offset = "0x30")]
	private float ScrollMomentum;

	// Token: 0x04002260 RID: 8800
	[Token(Token = "0x4002260")]
	[FieldOffset(Offset = "0x34")]
	private int ScrollDragging;

	// Token: 0x04002261 RID: 8801
	[Token(Token = "0x4002261")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 DragOffset;

	// Token: 0x04002262 RID: 8802
	[Token(Token = "0x4002262")]
	[FieldOffset(Offset = "0x0")]
	public static Texture2D _dividerTexture;

	// Token: 0x04002263 RID: 8803
	[Token(Token = "0x4002263")]
	[FieldOffset(Offset = "0x4")]
	public static Texture2D _buttonCloudActiveTexture;

	// Token: 0x04002264 RID: 8804
	[Token(Token = "0x4002264")]
	[FieldOffset(Offset = "0x8")]
	public static Texture2D _buttonCloudInactiveTexture;

	// Token: 0x04002265 RID: 8805
	[Token(Token = "0x4002265")]
	[FieldOffset(Offset = "0xC")]
	public static Texture2D _buttonFavoriteActiveTexture;

	// Token: 0x04002266 RID: 8806
	[Token(Token = "0x4002266")]
	[FieldOffset(Offset = "0x10")]
	public static Texture2D _buttonFavoriteInactiveTexture;

	// Token: 0x04002267 RID: 8807
	[Token(Token = "0x4002267")]
	[FieldOffset(Offset = "0x14")]
	public static Texture2D _buttonPlayTexture;

	// Token: 0x04002268 RID: 8808
	[Token(Token = "0x4002268")]
	[FieldOffset(Offset = "0x18")]
	public static Texture2D _buttonDeleteTexture;

	// Token: 0x04002269 RID: 8809
	[Token(Token = "0x4002269")]
	[FieldOffset(Offset = "0x1C")]
	public static Texture2D _buttonPlayedBeforeTexture;

	// Token: 0x0400226A RID: 8810
	[Token(Token = "0x400226A")]
	[FieldOffset(Offset = "0x20")]
	public static Texture2D _isNewlyGeneratedTexture;

	// Token: 0x0400226B RID: 8811
	[Token(Token = "0x400226B")]
	[FieldOffset(Offset = "0x40")]
	private int _worldCount;

	// Token: 0x0400226C RID: 8812
	[Token(Token = "0x400226C")]
	[FieldOffset(Offset = "0x44")]
	public List<WorldFileData> SortedWorldData;

	// Token: 0x0400226D RID: 8813
	[Token(Token = "0x400226D")]
	[FieldOffset(Offset = "0x48")]
	private float SeedDisplayTime;

	// Token: 0x0400226E RID: 8814
	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x4C")]
	private bool SeedVersionToggle;

	// Token: 0x0400226F RID: 8815
	[Token(Token = "0x400226F")]
	[FieldOffset(Offset = "0x50")]
	public int SelectedItem;

	// Token: 0x04002270 RID: 8816
	[Token(Token = "0x4002270")]
	[FieldOffset(Offset = "0x54")]
	private int LastSelectedItem;

	// Token: 0x04002271 RID: 8817
	[Token(Token = "0x4002271")]
	[FieldOffset(Offset = "0x58")]
	public string SelectedItemWorld;

	// Token: 0x04002272 RID: 8818
	[Token(Token = "0x4002272")]
	[FieldOffset(Offset = "0x60")]
	private DateTime LastSelectTime;

	// Token: 0x04002273 RID: 8819
	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x68")]
	private DateTime LastTouchTime;

	// Token: 0x04002274 RID: 8820
	[Token(Token = "0x4002274")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 LastTouchMouse;

	// Token: 0x04002275 RID: 8821
	[Token(Token = "0x4002275")]
	[FieldOffset(Offset = "0x78")]
	private GUIControllerWorldSelect _controllerInput;

	// Token: 0x04002276 RID: 8822
	[Token(Token = "0x4002276")]
	[FieldOffset(Offset = "0x7C")]
	private GUIContollerTransactionButtonList _worldListOptionsController;

	// Token: 0x04002277 RID: 8823
	[Token(Token = "0x4002277")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D everythingAnimatedIcon;

	// Token: 0x04002278 RID: 8824
	[Token(Token = "0x4002278")]
	[FieldOffset(Offset = "0x84")]
	private Texture2D mixedSeedIcon;

	// Token: 0x04002279 RID: 8825
	[Token(Token = "0x4002279")]
	[FieldOffset(Offset = "0x88")]
	private List<Texture2D> icons;

	// Token: 0x0400227A RID: 8826
	[Token(Token = "0x400227A")]
	[FieldOffset(Offset = "0x8C")]
	private bool allowItemClicking;

	// Token: 0x0400227B RID: 8827
	[Token(Token = "0x400227B")]
	[FieldOffset(Offset = "0x90")]
	private Rectangle fullClipRegion;

	// Token: 0x0400227C RID: 8828
	[Token(Token = "0x400227C")]
	[FieldOffset(Offset = "0xA0")]
	private Rectangle dragClipRegion;

	// Token: 0x0400227D RID: 8829
	[Token(Token = "0x400227D")]
	[FieldOffset(Offset = "0xB0")]
	public WorldFileData NewlyGeneratedWorld;

	// Token: 0x0400227E RID: 8830
	[Token(Token = "0x400227E")]
	[FieldOffset(Offset = "0xB4")]
	private int worldOver;

	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	public enum WorldRenameOption
	{
		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		DontRenameOldFormatWorlds,
		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		RenameOldFormatWithLoadSave,
		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		RenameAllFormatsWithLoadSave
	}

	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0xD4A874", Offset = "0xD4A874", VA = "0xD4A874")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0xD4E94C", Offset = "0xD4E94C", VA = "0xD4E94C")]
		internal void <Draw>b__0()
		{
		}

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x8")]
		public WorldFileData worldData;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0xC")]
		public GUIWorldSelectMenu <>4__this;
	}

	// Token: 0x020002CF RID: 719
	[Token(Token = "0x20002CF")]
	private sealed class <>c__DisplayClass69_0
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0xD4D5BC", Offset = "0xD4D5BC", VA = "0xD4D5BC")]
		public <>c__DisplayClass69_0()
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0xD4EA6C", Offset = "0xD4EA6C", VA = "0xD4EA6C")]
		internal void <WorldDraw>b__0()
		{
		}

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x8")]
		public WorldFileData worldData;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0xC")]
		public GUIWorldSelectMenu <>4__this;
	}
}
