using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
public class GUIAchievementsMenu
{
	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018B")]
	private GUIContollerTransactionButtonList FilterListOptionsController
	{
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0xCA03C4", Offset = "0xCA03C4", VA = "0xCA03C4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EE9")]
	[Address(RVA = "0xCA05E8", Offset = "0xCA05E8", VA = "0xCA05E8")]
	public void GotoAchievement(Achievement achievement)
	{
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018C")]
	private List<Achievement> Achievements
	{
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0xCA0760", Offset = "0xCA0760", VA = "0xCA0760")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEB")]
	[Address(RVA = "0xCA07F0", Offset = "0xCA07F0", VA = "0xCA07F0")]
	public void Open(int backTo, int selected = -1)
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEC")]
	[Address(RVA = "0xCA0F14", Offset = "0xCA0F14", VA = "0xCA0F14")]
	private void DrawFilters()
	{
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EED")]
	[Address(RVA = "0xCA13B0", Offset = "0xCA13B0", VA = "0xCA13B0")]
	public void Draw()
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0xCA1DE8", Offset = "0xCA1DE8", VA = "0xCA1DE8")]
	public void Back()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EEF")]
	[Address(RVA = "0xCA20CC", Offset = "0xCA20CC", VA = "0xCA20CC")]
	private void AchievementDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00007AA0 File Offset: 0x00005CA0
	[Token(Token = "0x6000EF0")]
	[Address(RVA = "0xCA43F4", Offset = "0xCA43F4", VA = "0xCA43F4")]
	private float AchievementScale(int index)
	{
		return 0f;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF1")]
	[Address(RVA = "0xCA4400", Offset = "0xCA4400", VA = "0xCA4400")]
	private void AchievementOver(int index)
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF2")]
	[Address(RVA = "0xCA0B98", Offset = "0xCA0B98", VA = "0xCA0B98")]
	public static void LoadContent()
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF3")]
	[Address(RVA = "0xCA0CC8", Offset = "0xCA0CC8", VA = "0xCA0CC8")]
	public void UpdateAchievements()
	{
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF4")]
	[Address(RVA = "0xCA48CC", Offset = "0xCA48CC", VA = "0xCA48CC")]
	public void SortAndFilderAchievements()
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00007AB8 File Offset: 0x00005CB8
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0xCA4CD0", Offset = "0xCA4CD0", VA = "0xCA4CD0")]
	private int SortEntry(Achievement a, Achievement b)
	{
		return 0;
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0xCA369C", Offset = "0xCA369C", VA = "0xCA369C")]
	private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0xCA4DB0", Offset = "0xCA4DB0", VA = "0xCA4DB0")]
	public GUIAchievementsMenu()
	{
	}

	// Token: 0x04001EDF RID: 7903
	[Token(Token = "0x4001EDF")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private GUIControllerAchievements _controllerInput;

	// Token: 0x04001EE0 RID: 7904
	[Token(Token = "0x4001EE0")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private GUIContollerTransactionButtonList _filterListOptionsController;

	// Token: 0x04001EE1 RID: 7905
	[Token(Token = "0x4001EE1")]
	private const double SINGLE_CLICK_TIME = 350.0;

	// Token: 0x04001EE2 RID: 7906
	[Token(Token = "0x4001EE2")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	// Token: 0x04001EE3 RID: 7907
	[Token(Token = "0x4001EE3")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private DateTime LastTouchTime;

	// Token: 0x04001EE4 RID: 7908
	[Token(Token = "0x4001EE4")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector2 LastTouchMouse;

	// Token: 0x04001EE5 RID: 7909
	[Token(Token = "0x4001EE5")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _source;

	// Token: 0x04001EE6 RID: 7910
	[Token(Token = "0x4001EE6")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool allowItemClicking;

	// Token: 0x04001EE7 RID: 7911
	[Token(Token = "0x4001EE7")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float TitleScale;

	// Token: 0x04001EE8 RID: 7912
	[Token(Token = "0x4001EE8")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float BackScale;

	// Token: 0x04001EE9 RID: 7913
	[Token(Token = "0x4001EE9")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float ScrollOffset;

	// Token: 0x04001EEA RID: 7914
	[Token(Token = "0x4001EEA")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float ScrollMomentum;

	// Token: 0x04001EEB RID: 7915
	[Token(Token = "0x4001EEB")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int ScrollDragging;

	// Token: 0x04001EEC RID: 7916
	[Token(Token = "0x4001EEC")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector2 DragOffset;

	// Token: 0x04001EED RID: 7917
	[Token(Token = "0x4001EED")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int SelectedItem;

	// Token: 0x04001EEE RID: 7918
	[Token(Token = "0x4001EEE")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int SelectedItemId;

	// Token: 0x04001EEF RID: 7919
	[Token(Token = "0x4001EEF")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector2 InGameWindowShift;

	// Token: 0x04001EF0 RID: 7920
	[Token(Token = "0x4001EF0")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private List<bool> catButtonsActive;

	// Token: 0x04001EF1 RID: 7921
	[Token(Token = "0x4001EF1")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Achievement> _achievements;

	// Token: 0x04001EF2 RID: 7922
	[Token(Token = "0x4001EF2")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public List<Achievement> SortedAchievementsData;

	// Token: 0x04001EF3 RID: 7923
	[Token(Token = "0x4001EF3")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Texture2D AchievementsIcons;

	// Token: 0x04001EF4 RID: 7924
	[Token(Token = "0x4001EF4")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Texture2D AchievementsCategories;

	// Token: 0x04001EF5 RID: 7925
	[Token(Token = "0x4001EF5")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture2D AchievementsIconBorder;

	// Token: 0x04001EF6 RID: 7926
	[Token(Token = "0x4001EF6")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string _tooltip;

	// Token: 0x04001EF7 RID: 7927
	[Token(Token = "0x4001EF7")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _tooltipShow;

	// Token: 0x04001EF8 RID: 7928
	[Token(Token = "0x4001EF8")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 _tooltipLocation;

	// Token: 0x04001EF9 RID: 7929
	[Token(Token = "0x4001EF9")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private DateTime _tooltipTime;

	// Token: 0x04001EFA RID: 7930
	[Token(Token = "0x4001EFA")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 startPoint;

	// Token: 0x04001EFB RID: 7931
	[Token(Token = "0x4001EFB")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float[] catScale;

	// Token: 0x04001EFC RID: 7932
	[Token(Token = "0x4001EFC")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool displayFilters;

	// Token: 0x04001EFD RID: 7933
	[Token(Token = "0x4001EFD")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float filtersScale;

	// Token: 0x04001EFE RID: 7934
	[Token(Token = "0x4001EFE")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int achievementOver;

	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public class AchievementFileData
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0xCA5094", Offset = "0xCA5094", VA = "0xCA5094")]
		public AchievementFileData()
		{
		}

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;
	}
}
