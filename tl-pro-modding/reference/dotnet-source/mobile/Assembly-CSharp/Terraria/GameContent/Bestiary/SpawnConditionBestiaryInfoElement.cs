using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0E RID: 3086
	[Token(Token = "0x2000C0E")]
	public class SpawnConditionBestiaryInfoElement : FilterProviderInfoElement, FileAPI, GUIControllerItem
	{
		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06005CB2 RID: 23730 RVA: 0x0002B6E0 File Offset: 0x000298E0
		// (set) Token: 0x06005CB3 RID: 23731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4A")]
		public float OrderPriority
		{
			[Token(Token = "0x6005CB2")]
			[Address(RVA = "0x9A3E90", Offset = "0x9A3E90", VA = "0x9A3E90", Slot = "11")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005CB3")]
			[Address(RVA = "0x9A3E98", Offset = "0x9A3E98", VA = "0x9A3E98")]
			set
			{
			}
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x99628C", Offset = "0x99628C", VA = "0x99628C")]
		public SpawnConditionBestiaryInfoElement(string nameLanguageKey, int filterIconFrame, [Optional] string backgroundImagePath, [Optional] Color? backgroundColor)
		{
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x9A3EA0", Offset = "0x9A3EA0", VA = "0x9A3EA0", Slot = "9")]
		public Asset<Texture2D> GetBackgroundImage()
		{
			return null;
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x0002B6F8 File Offset: 0x000298F8
		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0x9A3FD4", Offset = "0x9A3FD4", VA = "0x9A3FD4", Slot = "10")]
		public Color? GetBackgroundColor()
		{
			return null;
		}

		// Token: 0x04009D20 RID: 40224
		[Token(Token = "0x4009D20")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string _backgroundImagePath;

		// Token: 0x04009D21 RID: 40225
		[Token(Token = "0x4009D21")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color? _backgroundColor;

		// Token: 0x04009D22 RID: 40226
		[Token(Token = "0x4009D22")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <OrderPriority>k__BackingField;
	}
}
