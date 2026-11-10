using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	public class MoonLordPortraitBackgroundProviderBestiaryInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005CAE RID: 23726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x9A3CB0", Offset = "0x9A3CB0", VA = "0x9A3CB0")]
		public MoonLordPortraitBackgroundProviderBestiaryInfoElement()
		{
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x9A3CB8", Offset = "0x9A3CB8", VA = "0x9A3CB8", Slot = "5")]
		public Asset<Texture2D> GetBackgroundImage()
		{
			return null;
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x0002B6C8 File Offset: 0x000298C8
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x9A3DEC", Offset = "0x9A3DEC", VA = "0x9A3DEC", Slot = "6")]
		public Color? GetBackgroundColor()
		{
			return null;
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x9A3E88", Offset = "0x9A3E88", VA = "0x9A3E88", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}
	}
}
