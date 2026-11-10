using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000D4B RID: 3403
	[Token(Token = "0x2000D4B")]
	public class FancyClassicPlayerResourcesDisplaySet : FileAPI, GUIControllerItem
	{
		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064EB RID: 25835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD4")]
		public string NameKey
		{
			[Token(Token = "0x60064EA")]
			[Address(RVA = "0xB3C2F0", Offset = "0xB3C2F0", VA = "0xB3C2F0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064EB")]
			[Address(RVA = "0xB3C2F8", Offset = "0xB3C2F8", VA = "0xB3C2F8")]
			private set
			{
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060064EC RID: 25836 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064ED RID: 25837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD5")]
		public string ConfigKey
		{
			[Token(Token = "0x60064EC")]
			[Address(RVA = "0xB3C300", Offset = "0xB3C300", VA = "0xB3C300", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064ED")]
			[Address(RVA = "0xB3C308", Offset = "0xB3C308", VA = "0xB3C308")]
			private set
			{
			}
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EE")]
		[Address(RVA = "0xB3C310", Offset = "0xB3C310", VA = "0xB3C310")]
		public FancyClassicPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0xB3CE24", Offset = "0xB3CE24", VA = "0xB3CE24", Slot = "4")]
		public void Draw()
		{
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0xB3D09C", Offset = "0xB3D09C", VA = "0xB3D09C")]
		private void DrawLifeBar(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0xB3E158", Offset = "0xB3E158", VA = "0xB3E158")]
		private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
		{
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0xB3DBD0", Offset = "0xB3DBD0", VA = "0xB3DBD0")]
		private void DrawManaBar(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0xB3E848", Offset = "0xB3E848", VA = "0xB3E848")]
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0xB3EB28", Offset = "0xB3EB28", VA = "0xB3EB28")]
		private void HeartPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0xB3ECBC", Offset = "0xB3ECBC", VA = "0xB3ECBC")]
		private void HeartFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F6")]
		[Address(RVA = "0xB3EEA4", Offset = "0xB3EEA4", VA = "0xB3EEA4")]
		private void StarPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0xB3F000", Offset = "0xB3F000", VA = "0xB3F000")]
		private void StarFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0xB3CEB8", Offset = "0xB3CEB8", VA = "0xB3CEB8")]
		private void PrepareFields(Player player)
		{
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0xB3F1D0", Offset = "0xB3F1D0", VA = "0xB3F1D0", Slot = "5")]
		public void TryToHover()
		{
		}

		// Token: 0x0400A24F RID: 41551
		[Token(Token = "0x400A24F")]
		[FieldOffset(Offset = "0x8")]
		private float _currentPlayerLife;

		// Token: 0x0400A250 RID: 41552
		[Token(Token = "0x400A250")]
		[FieldOffset(Offset = "0xC")]
		private float _lifePerHeart;

		// Token: 0x0400A251 RID: 41553
		[Token(Token = "0x400A251")]
		[FieldOffset(Offset = "0x10")]
		private int _playerLifeFruitCount;

		// Token: 0x0400A252 RID: 41554
		[Token(Token = "0x400A252")]
		[FieldOffset(Offset = "0x14")]
		private int _lastHeartFillingIndex;

		// Token: 0x0400A253 RID: 41555
		[Token(Token = "0x400A253")]
		[FieldOffset(Offset = "0x18")]
		private int _lastHeartPanelIndex;

		// Token: 0x0400A254 RID: 41556
		[Token(Token = "0x400A254")]
		[FieldOffset(Offset = "0x1C")]
		private int _heartCountRow1;

		// Token: 0x0400A255 RID: 41557
		[Token(Token = "0x400A255")]
		[FieldOffset(Offset = "0x20")]
		private int _heartCountRow2;

		// Token: 0x0400A256 RID: 41558
		[Token(Token = "0x400A256")]
		[FieldOffset(Offset = "0x24")]
		private int _starCount;

		// Token: 0x0400A257 RID: 41559
		[Token(Token = "0x400A257")]
		[FieldOffset(Offset = "0x28")]
		private int _lastStarFillingIndex;

		// Token: 0x0400A258 RID: 41560
		[Token(Token = "0x400A258")]
		[FieldOffset(Offset = "0x2C")]
		private float _manaPerStar;

		// Token: 0x0400A259 RID: 41561
		[Token(Token = "0x400A259")]
		[FieldOffset(Offset = "0x30")]
		private float _currentPlayerMana;

		// Token: 0x0400A25A RID: 41562
		[Token(Token = "0x400A25A")]
		[FieldOffset(Offset = "0x34")]
		private Asset<Texture2D> _heartLeft;

		// Token: 0x0400A25B RID: 41563
		[Token(Token = "0x400A25B")]
		[FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _heartMiddle;

		// Token: 0x0400A25C RID: 41564
		[Token(Token = "0x400A25C")]
		[FieldOffset(Offset = "0x3C")]
		private Asset<Texture2D> _heartRight;

		// Token: 0x0400A25D RID: 41565
		[Token(Token = "0x400A25D")]
		[FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _heartRightFancy;

		// Token: 0x0400A25E RID: 41566
		[Token(Token = "0x400A25E")]
		[FieldOffset(Offset = "0x44")]
		private Asset<Texture2D> _heartFill;

		// Token: 0x0400A25F RID: 41567
		[Token(Token = "0x400A25F")]
		[FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _heartFillHoney;

		// Token: 0x0400A260 RID: 41568
		[Token(Token = "0x400A260")]
		[FieldOffset(Offset = "0x4C")]
		private Asset<Texture2D> _heartSingleFancy;

		// Token: 0x0400A261 RID: 41569
		[Token(Token = "0x400A261")]
		[FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _starTop;

		// Token: 0x0400A262 RID: 41570
		[Token(Token = "0x400A262")]
		[FieldOffset(Offset = "0x54")]
		private Asset<Texture2D> _starMiddle;

		// Token: 0x0400A263 RID: 41571
		[Token(Token = "0x400A263")]
		[FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _starBottom;

		// Token: 0x0400A264 RID: 41572
		[Token(Token = "0x400A264")]
		[FieldOffset(Offset = "0x5C")]
		private Asset<Texture2D> _starSingle;

		// Token: 0x0400A265 RID: 41573
		[Token(Token = "0x400A265")]
		[FieldOffset(Offset = "0x60")]
		private Asset<Texture2D> _starFill;

		// Token: 0x0400A266 RID: 41574
		[Token(Token = "0x400A266")]
		[FieldOffset(Offset = "0x64")]
		private bool _hoverLife;

		// Token: 0x0400A267 RID: 41575
		[Token(Token = "0x400A267")]
		[FieldOffset(Offset = "0x65")]
		private bool _hoverMana;

		// Token: 0x0400A268 RID: 41576
		[Token(Token = "0x400A268")]
		[FieldOffset(Offset = "0x66")]
		private bool _drawText;

		// Token: 0x0400A269 RID: 41577
		[Token(Token = "0x400A269")]
		[FieldOffset(Offset = "0x68")]
		private string <NameKey>k__BackingField;

		// Token: 0x0400A26A RID: 41578
		[Token(Token = "0x400A26A")]
		[FieldOffset(Offset = "0x6C")]
		private string <ConfigKey>k__BackingField;
	}
}
