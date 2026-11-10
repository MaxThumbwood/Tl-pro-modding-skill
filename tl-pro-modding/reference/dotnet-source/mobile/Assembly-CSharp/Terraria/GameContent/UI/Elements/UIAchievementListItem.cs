using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Achievements;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x02000D5E RID: 3422
	[Token(Token = "0x2000D5E")]
	public class UIAchievementListItem : UIPanel
	{
		// Token: 0x06006571 RID: 25969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006571")]
		[Address(RVA = "0xB477E8", Offset = "0xB477E8", VA = "0xB477E8")]
		public UIAchievementListItem(Achievement achievement, bool largeForOtherLanguages)
		{
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006572")]
		[Address(RVA = "0xB48170", Offset = "0xB48170", VA = "0xB48170", Slot = "6")]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006573")]
		[Address(RVA = "0xB48120", Offset = "0xB48120", VA = "0xB48120")]
		private void UpdateIconFrame()
		{
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006574")]
		[Address(RVA = "0xB499B8", Offset = "0xB499B8", VA = "0xB499B8")]
		private void DrawPanelTop(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006575")]
		[Address(RVA = "0xB49DE0", Offset = "0xB49DE0", VA = "0xB49DE0")]
		private void DrawPanelBottom(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006576")]
		[Address(RVA = "0xB4AEA4", Offset = "0xB4AEA4", VA = "0xB4AEA4", Slot = "23")]
		public override void MouseOver(UIMouseEvent evt)
		{
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006577")]
		[Address(RVA = "0xB4AF0C", Offset = "0xB4AF0C", VA = "0xB4AF0C", Slot = "24")]
		public override void MouseOut(UIMouseEvent evt)
		{
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006578")]
		[Address(RVA = "0xB4AFF0", Offset = "0xB4AFF0", VA = "0xB4AFF0")]
		public Achievement GetAchievement()
		{
			return null;
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006579")]
		[Address(RVA = "0xB495D8", Offset = "0xB495D8", VA = "0xB495D8")]
		private Tuple<decimal, decimal> GetTrackerValues()
		{
			return null;
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657A")]
		[Address(RVA = "0xB4A204", Offset = "0xB4A204", VA = "0xB4A204")]
		private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
		{
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x0002E200 File Offset: 0x0002C400
		[Token(Token = "0x600657B")]
		[Address(RVA = "0xB4AFF8", Offset = "0xB4AFF8", VA = "0xB4AFF8", Slot = "29")]
		public override int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0400A2D0 RID: 41680
		[Token(Token = "0x400A2D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Achievement _achievement;

		// Token: 0x0400A2D1 RID: 41681
		[Token(Token = "0x400A2D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIImageFramed _achievementIcon;

		// Token: 0x0400A2D2 RID: 41682
		[Token(Token = "0x400A2D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private UIImage _achievementIconBorders;

		// Token: 0x0400A2D3 RID: 41683
		[Token(Token = "0x400A2D3")]
		private const int _iconSize = 64;

		// Token: 0x0400A2D4 RID: 41684
		[Token(Token = "0x400A2D4")]
		private const int _iconSizeWithSpace = 66;

		// Token: 0x0400A2D5 RID: 41685
		[Token(Token = "0x400A2D5")]
		private const int _iconsPerRow = 8;

		// Token: 0x0400A2D6 RID: 41686
		[Token(Token = "0x400A2D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _iconIndex;

		// Token: 0x0400A2D7 RID: 41687
		[Token(Token = "0x400A2D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Rectangle _iconFrame;

		// Token: 0x0400A2D8 RID: 41688
		[Token(Token = "0x400A2D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Rectangle _iconFrameUnlocked;

		// Token: 0x0400A2D9 RID: 41689
		[Token(Token = "0x400A2D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Rectangle _iconFrameLocked;

		// Token: 0x0400A2DA RID: 41690
		[Token(Token = "0x400A2DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Asset<Texture2D> _innerPanelTopTexture;

		// Token: 0x0400A2DB RID: 41691
		[Token(Token = "0x400A2DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Asset<Texture2D> _innerPanelBottomTexture;

		// Token: 0x0400A2DC RID: 41692
		[Token(Token = "0x400A2DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Asset<Texture2D> _categoryTexture;

		// Token: 0x0400A2DD RID: 41693
		[Token(Token = "0x400A2DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _locked;

		// Token: 0x0400A2DE RID: 41694
		[Token(Token = "0x400A2DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool _large;
	}
}
