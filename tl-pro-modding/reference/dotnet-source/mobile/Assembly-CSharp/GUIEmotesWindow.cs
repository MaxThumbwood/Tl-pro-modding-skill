using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

// Token: 0x0200014F RID: 335
[Token(Token = "0x200014F")]
public class GUIEmotesWindow
{
	// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091C")]
	[Address(RVA = "0x63751C", Offset = "0x63751C", VA = "0x63751C")]
	public static void LoadContent(ContentManager content)
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091D")]
	[Address(RVA = "0x637768", Offset = "0x637768", VA = "0x637768")]
	public void SetDisplayingEmotes(bool value)
	{
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x637B24", Offset = "0x637B24", VA = "0x637B24")]
	public void AddUIExcludeRegions(List<Rectangle> regions)
	{
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x600091F")]
	[Address(RVA = "0x637C64", Offset = "0x637C64", VA = "0x637C64")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000920")]
	[Address(RVA = "0x637A24", Offset = "0x637A24", VA = "0x637A24")]
	public void SetCategory(GUIEmotesWindow.Category cat)
	{
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000921")]
	[Address(RVA = "0x637DB0", Offset = "0x637DB0", VA = "0x637DB0")]
	private void GetEmotesGeneral(List<int> emotes)
	{
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000922")]
	[Address(RVA = "0x638970", Offset = "0x638970", VA = "0x638970")]
	private void GetEmotesRPS(List<int> emotes)
	{
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000923")]
	[Address(RVA = "0x638C1C", Offset = "0x638C1C", VA = "0x638C1C")]
	private void GetEmotesItems(List<int> emotes)
	{
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000924")]
	[Address(RVA = "0x639584", Offset = "0x639584", VA = "0x639584")]
	private void GetEmotesBiomesAndEvents(List<int> emotes)
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000925")]
	[Address(RVA = "0x639EEC", Offset = "0x639EEC", VA = "0x639EEC")]
	private void GetEmotesTownNPCs(List<int> emotes)
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000926")]
	[Address(RVA = "0x63AB10", Offset = "0x63AB10", VA = "0x63AB10")]
	private void GetEmotesCritters(List<int> emotes)
	{
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000927")]
	[Address(RVA = "0x63B198", Offset = "0x63B198", VA = "0x63B198")]
	private void GetEmotesBosses(List<int> emotes)
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000928")]
	[Address(RVA = "0x63C28C", Offset = "0x63C28C", VA = "0x63C28C")]
	public void Draw()
	{
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000929")]
	[Address(RVA = "0x63C85C", Offset = "0x63C85C", VA = "0x63C85C")]
	private void DrawBacking()
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092A")]
	[Address(RVA = "0x63C9A8", Offset = "0x63C9A8", VA = "0x63C9A8")]
	private void DrawEntries()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092B")]
	[Address(RVA = "0x63CBE8", Offset = "0x63CBE8", VA = "0x63CBE8")]
	private void DrawCategories()
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x600092C")]
	[Address(RVA = "0x63D8F4", Offset = "0x63D8F4", VA = "0x63D8F4")]
	public float EmoteScale(int index)
	{
		return 0f;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092D")]
	[Address(RVA = "0x63D95C", Offset = "0x63D95C", VA = "0x63D95C")]
	public void EmoteOver(int index)
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600092E")]
	[Address(RVA = "0x63E03C", Offset = "0x63E03C", VA = "0x63E03C")]
	public void EmoteDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00005BF8 File Offset: 0x00003DF8
	[Token(Token = "0x600092F")]
	[Address(RVA = "0x63EBD4", Offset = "0x63EBD4", VA = "0x63EBD4")]
	private Rectangle GetFrame(int emoteIndex)
	{
		return default(Rectangle);
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x63ED08", Offset = "0x63ED08", VA = "0x63ED08")]
	public GUIEmotesWindow()
	{
	}

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x8")]
	public List<int> _emoteEntries;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x0")]
	private static Asset<Texture2D> _emoteTexture;

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x4")]
	private static Asset<Texture2D> _emoteTextureBorder;

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0xC")]
	private int _frameCounter;

	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x10")]
	public GUIControllerEmotes _controller;

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x14")]
	private GUIEmotesWindow.Category CurrentSelection;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x18")]
	private float TimeSinceItemChange;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x1C")]
	private int emoteOver;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x20")]
	public bool DisplayingEmotes;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x24")]
	public GUIInputRegionExclusive PickingInterceptor;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x28")]
	private float EmotesCloseScale;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x2C")]
	private float emotesGeneralScale;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x30")]
	private float emotesRPSScale;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x34")]
	private float emotesItemsScale;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x38")]
	private float emotesBiomesAndEventsScale;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x3C")]
	private float emotesTownNPCsScale;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x40")]
	private float emotesCrittersScale;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x44")]
	private float emotesBossesScale;

	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x48")]
	public float emoteScrollOffset;

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x4C")]
	private float emoteScrollMomentum;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x50")]
	private int emoteScrollDragging;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 emoteDragOffset;

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x5C")]
	private float TitleScale;

	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public enum Category
	{
		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		General,
		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		RPS,
		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		Items,
		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		BiomesAndEvents,
		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		TownNPCs,
		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		Critters,
		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		Bosses
	}
}
