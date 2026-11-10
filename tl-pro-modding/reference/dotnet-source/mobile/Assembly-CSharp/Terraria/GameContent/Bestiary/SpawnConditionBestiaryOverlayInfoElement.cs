using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x2000C0F")]
	public class SpawnConditionBestiaryOverlayInfoElement : FilterProviderInfoElement, FileAPI, GUIControllerItem
	{
		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x0002B710 File Offset: 0x00029910
		// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4B")]
		public float DisplayPriority
		{
			[Token(Token = "0x6005CB7")]
			[Address(RVA = "0x9A3FE8", Offset = "0x9A3FE8", VA = "0x9A3FE8", Slot = "11")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005CB8")]
			[Address(RVA = "0x9A3FF0", Offset = "0x9A3FF0", VA = "0x9A3FF0")]
			set
			{
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x0002B728 File Offset: 0x00029928
		// (set) Token: 0x06005CBA RID: 23738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4C")]
		public float OrderPriority
		{
			[Token(Token = "0x6005CB9")]
			[Address(RVA = "0x9A3FF8", Offset = "0x9A3FF8", VA = "0x9A3FF8", Slot = "12")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005CBA")]
			[Address(RVA = "0x9A4000", Offset = "0x9A4000", VA = "0x9A4000")]
			set
			{
			}
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x9A4008", Offset = "0x9A4008", VA = "0x9A4008")]
		public SpawnConditionBestiaryOverlayInfoElement(string nameLanguageKey, int filterIconFrame, [Optional] string overlayImagePath, [Optional] Color? overlayColor)
		{
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x9A405C", Offset = "0x9A405C", VA = "0x9A405C", Slot = "9")]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			return null;
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x0002B740 File Offset: 0x00029940
		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x9A4190", Offset = "0x9A4190", VA = "0x9A4190", Slot = "10")]
		public Color? GetBackgroundOverlayColor()
		{
			return null;
		}

		// Token: 0x04009D23 RID: 40227
		[Token(Token = "0x4009D23")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string _overlayImagePath;

		// Token: 0x04009D24 RID: 40228
		[Token(Token = "0x4009D24")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Color? _overlayColor;

		// Token: 0x04009D25 RID: 40229
		[Token(Token = "0x4009D25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <DisplayPriority>k__BackingField;

		// Token: 0x04009D26 RID: 40230
		[Token(Token = "0x4009D26")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <OrderPriority>k__BackingField;
	}
}
