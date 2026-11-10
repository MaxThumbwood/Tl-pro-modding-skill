using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001DE RID: 478
[Token(Token = "0x20001DE")]
[Serializable]
public class Texture_Layout
{
	// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0xC7A478", Offset = "0xC7A478", VA = "0xC7A478")]
	public Texture_Layout()
	{
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0xC74970", Offset = "0xC74970", VA = "0xC74970")]
	public void Copy(Texture_Layout other)
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0xC6C69C", Offset = "0xC6C69C", VA = "0xC6C69C")]
	public Texture_Layout(string defaultTextureId)
	{
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0xC7A480", Offset = "0xC7A480", VA = "0xC7A480")]
	public void Write(BinaryWriter writer)
	{
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0xC7A4B4", Offset = "0xC7A4B4", VA = "0xC7A4B4")]
	public void Load(int version, BinaryReader reader)
	{
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000154")]
	public Texture2D Texture
	{
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0xC75C40", Offset = "0xC75C40", VA = "0xC75C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0xC7A4E8", Offset = "0xC7A4E8", VA = "0xC7A4E8")]
	public static void Setup(ContentManager manager)
	{
	}

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x8")]
	public string TextureId;

	// Token: 0x04001356 RID: 4950
	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0xC")]
	private Texture2D _texture;

	// Token: 0x04001357 RID: 4951
	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x10")]
	private string _lastTextureId;

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x0")]
	private static ContentManager _contentManager;

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x4")]
	private static Dictionary<string, Texture2D> _textureDictionary;
}
