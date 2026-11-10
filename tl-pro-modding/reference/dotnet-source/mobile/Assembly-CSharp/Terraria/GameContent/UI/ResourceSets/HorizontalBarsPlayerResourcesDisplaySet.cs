using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D4C RID: 3404
	[Token(Token = "0x2000D4C")]
	public class HorizontalBarsPlayerResourcesDisplaySet : FileAPI, GUIControllerItem
	{
		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064FB RID: 25851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD6")]
		public string NameKey
		{
			[Token(Token = "0x60064FA")]
			[Address(RVA = "0xB3F1F8", Offset = "0xB3F1F8", VA = "0xB3F1F8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064FB")]
			[Address(RVA = "0xB3F200", Offset = "0xB3F200", VA = "0xB3F200")]
			private set
			{
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060064FC RID: 25852 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064FD RID: 25853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD7")]
		public string ConfigKey
		{
			[Token(Token = "0x60064FC")]
			[Address(RVA = "0xB3F208", Offset = "0xB3F208", VA = "0xB3F208", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064FD")]
			[Address(RVA = "0xB3F210", Offset = "0xB3F210", VA = "0xB3F210")]
			private set
			{
			}
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0xB3F218", Offset = "0xB3F218", VA = "0xB3F218")]
		public HorizontalBarsPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0xB3FA1C", Offset = "0xB3FA1C", VA = "0xB3FA1C", Slot = "4")]
		public void Draw()
		{
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006500")]
		[Address(RVA = "0xB40E5C", Offset = "0xB40E5C", VA = "0xB40E5C")]
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006501")]
		[Address(RVA = "0xB4076C", Offset = "0xB4076C", VA = "0xB4076C")]
		private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
		{
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006502")]
		[Address(RVA = "0xB406B0", Offset = "0xB406B0", VA = "0xB406B0")]
		private void PrepareFields(Player player)
		{
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006503")]
		[Address(RVA = "0xB41BC8", Offset = "0xB41BC8", VA = "0xB41BC8")]
		private void LifePanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006504")]
		[Address(RVA = "0xB41D18", Offset = "0xB41D18", VA = "0xB41D18")]
		private void ManaPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006505")]
		[Address(RVA = "0xB41E68", Offset = "0xB41E68", VA = "0xB41E68")]
		private void LifeFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006506")]
		[Address(RVA = "0xB41EC0", Offset = "0xB41EC0", VA = "0xB41EC0")]
		private static void FillBarByValues(int elementIndex, Asset<Texture2D> sprite, int segmentsCount, float fillPercent, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006507")]
		[Address(RVA = "0xB42120", Offset = "0xB42120", VA = "0xB42120")]
		private void ManaFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006508")]
		[Address(RVA = "0xB42164", Offset = "0xB42164", VA = "0xB42164", Slot = "5")]
		public void TryToHover()
		{
		}

		// Token: 0x0400A26B RID: 41579
		[Token(Token = "0x400A26B")]
		[FieldOffset(Offset = "0x8")]
		private int _maxSegmentCount;

		// Token: 0x0400A26C RID: 41580
		[Token(Token = "0x400A26C")]
		[FieldOffset(Offset = "0xC")]
		private int _hpSegmentsCount;

		// Token: 0x0400A26D RID: 41581
		[Token(Token = "0x400A26D")]
		[FieldOffset(Offset = "0x10")]
		private int _mpSegmentsCount;

		// Token: 0x0400A26E RID: 41582
		[Token(Token = "0x400A26E")]
		[FieldOffset(Offset = "0x14")]
		private int _hpFruitCount;

		// Token: 0x0400A26F RID: 41583
		[Token(Token = "0x400A26F")]
		[FieldOffset(Offset = "0x18")]
		private float _hpPercent;

		// Token: 0x0400A270 RID: 41584
		[Token(Token = "0x400A270")]
		[FieldOffset(Offset = "0x1C")]
		private float _mpPercent;

		// Token: 0x0400A271 RID: 41585
		[Token(Token = "0x400A271")]
		[FieldOffset(Offset = "0x20")]
		private byte _drawTextStyle;

		// Token: 0x0400A272 RID: 41586
		[Token(Token = "0x400A272")]
		[FieldOffset(Offset = "0x21")]
		private bool _hpHovered;

		// Token: 0x0400A273 RID: 41587
		[Token(Token = "0x400A273")]
		[FieldOffset(Offset = "0x22")]
		private bool _mpHovered;

		// Token: 0x0400A274 RID: 41588
		[Token(Token = "0x400A274")]
		[FieldOffset(Offset = "0x24")]
		private Asset<Texture2D> _hpFill;

		// Token: 0x0400A275 RID: 41589
		[Token(Token = "0x400A275")]
		[FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _hpFillHoney;

		// Token: 0x0400A276 RID: 41590
		[Token(Token = "0x400A276")]
		[FieldOffset(Offset = "0x2C")]
		private Asset<Texture2D> _mpFill;

		// Token: 0x0400A277 RID: 41591
		[Token(Token = "0x400A277")]
		[FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _panelLeft;

		// Token: 0x0400A278 RID: 41592
		[Token(Token = "0x400A278")]
		[FieldOffset(Offset = "0x34")]
		private Asset<Texture2D> _panelMiddleHP;

		// Token: 0x0400A279 RID: 41593
		[Token(Token = "0x400A279")]
		[FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _panelRightHP;

		// Token: 0x0400A27A RID: 41594
		[Token(Token = "0x400A27A")]
		[FieldOffset(Offset = "0x3C")]
		private Asset<Texture2D> _panelMiddleMP;

		// Token: 0x0400A27B RID: 41595
		[Token(Token = "0x400A27B")]
		[FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _panelRightMP;

		// Token: 0x0400A27C RID: 41596
		[Token(Token = "0x400A27C")]
		[FieldOffset(Offset = "0x44")]
		private string <NameKey>k__BackingField;

		// Token: 0x0400A27D RID: 41597
		[Token(Token = "0x400A27D")]
		[FieldOffset(Offset = "0x48")]
		private string <ConfigKey>k__BackingField;
	}
}
