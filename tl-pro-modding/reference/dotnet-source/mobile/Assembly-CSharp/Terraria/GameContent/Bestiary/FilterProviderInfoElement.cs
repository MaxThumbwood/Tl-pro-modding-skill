using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public class FilterProviderInfoElement : FileAPI, GUIControllerItem, GUIControllerItem
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06005C97 RID: 23703 RVA: 0x0002B668 File Offset: 0x00029868
		// (set) Token: 0x06005C98 RID: 23704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A48")]
		public int DisplayTextPriority
		{
			[Token(Token = "0x6005C97")]
			[Address(RVA = "0x9A2F1C", Offset = "0x9A2F1C", VA = "0x9A2F1C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005C98")]
			[Address(RVA = "0x9A2F24", Offset = "0x9A2F24", VA = "0x9A2F24")]
			set
			{
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x0002B680 File Offset: 0x00029880
		// (set) Token: 0x06005C9A RID: 23706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A49")]
		public bool HideInPortraitInfo
		{
			[Token(Token = "0x6005C99")]
			[Address(RVA = "0x9A2F2C", Offset = "0x9A2F2C", VA = "0x9A2F2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C9A")]
			[Address(RVA = "0x9A2F34", Offset = "0x9A2F34", VA = "0x9A2F34")]
			set
			{
			}
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x9A2F3C", Offset = "0x9A2F3C", VA = "0x9A2F3C")]
		public FilterProviderInfoElement(string nameLanguageKey, int filterIconFrame)
		{
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x9A2F78", Offset = "0x9A2F78", VA = "0x9A2F78", Slot = "4")]
		public UIElement GetFilterImage()
		{
			return null;
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x9A31B8", Offset = "0x9A31B8", VA = "0x9A31B8", Slot = "7")]
		public string GetSearchString(ref BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x9A3258", Offset = "0x9A3258", VA = "0x9A3258", Slot = "5")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x9A3260", Offset = "0x9A3260", VA = "0x9A3260", Slot = "8")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x9A37C0", Offset = "0x9A37C0", VA = "0x9A37C0", Slot = "6")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x9A3710", Offset = "0x9A3710", VA = "0x9A3710")]
		private void AddOnHover(UIElement button)
		{
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x9A3994", Offset = "0x9A3994", VA = "0x9A3994")]
		private void ShowButtonName(UIElement element)
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x9A3AA4", Offset = "0x9A3AA4", VA = "0x9A3AA4")]
		private void <AddOnHover>b__18_0(UIElement e)
		{
		}

		// Token: 0x04009D17 RID: 40215
		[Token(Token = "0x4009D17")]
		private const int framesPerRow = 16;

		// Token: 0x04009D18 RID: 40216
		[Token(Token = "0x4009D18")]
		private const int framesPerColumn = 5;

		// Token: 0x04009D19 RID: 40217
		[Token(Token = "0x4009D19")]
		[FieldOffset(Offset = "0x8")]
		public Point _filterIconFrame;

		// Token: 0x04009D1A RID: 40218
		[Token(Token = "0x4009D1A")]
		[FieldOffset(Offset = "0x10")]
		private string _key;

		// Token: 0x04009D1B RID: 40219
		[Token(Token = "0x4009D1B")]
		[FieldOffset(Offset = "0x14")]
		private int <DisplayTextPriority>k__BackingField;

		// Token: 0x04009D1C RID: 40220
		[Token(Token = "0x4009D1C")]
		[FieldOffset(Offset = "0x18")]
		private bool <HideInPortraitInfo>k__BackingField;
	}
}
