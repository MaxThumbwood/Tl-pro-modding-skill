using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C10 RID: 3088
	[Token(Token = "0x2000C10")]
	public class SpawnConditionDecorativeOverlayInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x0002B758 File Offset: 0x00029958
		// (set) Token: 0x06005CBF RID: 23743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4D")]
		public float DisplayPriority
		{
			[Token(Token = "0x6005CBE")]
			[Address(RVA = "0x9A41A4", Offset = "0x9A41A4", VA = "0x9A41A4", Slot = "7")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005CBF")]
			[Address(RVA = "0x9A41AC", Offset = "0x9A41AC", VA = "0x9A41AC")]
			set
			{
			}
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0x996B08", Offset = "0x996B08", VA = "0x996B08")]
		public SpawnConditionDecorativeOverlayInfoElement([Optional] string overlayImagePath, [Optional] Color? overlayColor)
		{
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0x9A41B4", Offset = "0x9A41B4", VA = "0x9A41B4", Slot = "5")]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			return null;
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x0002B770 File Offset: 0x00029970
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0x9A42E8", Offset = "0x9A42E8", VA = "0x9A42E8", Slot = "6")]
		public Color? GetBackgroundOverlayColor()
		{
			return null;
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0x9A42FC", Offset = "0x9A42FC", VA = "0x9A42FC", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x04009D27 RID: 40231
		[Token(Token = "0x4009D27")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string _overlayImagePath;

		// Token: 0x04009D28 RID: 40232
		[Token(Token = "0x4009D28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Color? _overlayColor;

		// Token: 0x04009D29 RID: 40233
		[Token(Token = "0x4009D29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <DisplayPriority>k__BackingField;
	}
}
