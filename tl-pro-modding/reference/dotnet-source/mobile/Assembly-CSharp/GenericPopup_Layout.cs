using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000218 RID: 536
[Token(Token = "0x2000218")]
public class GenericPopup_Layout : LayoutDefinition
{
	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0xC90294", Offset = "0xC90294", VA = "0xC90294")]
	private void Awake()
	{
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000172")]
	public Dictionary<GUIGenericPopup.IconType, string> IconDictionary
	{
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0xC9054C", Offset = "0xC9054C", VA = "0xC9054C")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0xC90554", Offset = "0xC90554", VA = "0xC90554")]
	public GenericPopup_Layout()
	{
	}

	// Token: 0x040016DD RID: 5853
	[Token(Token = "0x40016DD")]
	[FieldOffset(Offset = "0x0")]
	public static GenericPopup_Layout Instance;

	// Token: 0x040016DE RID: 5854
	[Token(Token = "0x40016DE")]
	[FieldOffset(Offset = "0xC")]
	public List<GenericPopup_Layout.IconTexture> Icons;

	// Token: 0x040016DF RID: 5855
	[Token(Token = "0x40016DF")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<GUIGenericPopup.IconType, string> _iconDictionary;

	// Token: 0x040016E0 RID: 5856
	[Token(Token = "0x40016E0")]
	[FieldOffset(Offset = "0x14")]
	public StringButton_Layout Title;

	// Token: 0x040016E1 RID: 5857
	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x18")]
	public Panel_Layout Greyout;

	// Token: 0x040016E2 RID: 5858
	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x1C")]
	public Panel_Layout Backing;

	// Token: 0x040016E3 RID: 5859
	[Token(Token = "0x40016E3")]
	[FieldOffset(Offset = "0x20")]
	public Panel_Layout MenuDivider;

	// Token: 0x040016E4 RID: 5860
	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x24")]
	public StringButton_Layout Message;

	// Token: 0x040016E5 RID: 5861
	[Token(Token = "0x40016E5")]
	[FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ButtonA;

	// Token: 0x040016E6 RID: 5862
	[Token(Token = "0x40016E6")]
	[FieldOffset(Offset = "0x2C")]
	public TransactionButton_Layout ButtonB;

	// Token: 0x040016E7 RID: 5863
	[Token(Token = "0x40016E7")]
	[FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ButtonC;

	// Token: 0x040016E8 RID: 5864
	[Token(Token = "0x40016E8")]
	[FieldOffset(Offset = "0x34")]
	public Button_Layout SearchingIcon;

	// Token: 0x040016E9 RID: 5865
	[Token(Token = "0x40016E9")]
	[FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout EditBacking;

	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	[Serializable]
	public class IconTexture
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0xC905BC", Offset = "0xC905BC", VA = "0xC905BC")]
		public IconTexture()
		{
		}

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x8")]
		public GUIGenericPopup.IconType Type;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x40016EB")]
		[FieldOffset(Offset = "0xC")]
		public string Path;
	}
}
