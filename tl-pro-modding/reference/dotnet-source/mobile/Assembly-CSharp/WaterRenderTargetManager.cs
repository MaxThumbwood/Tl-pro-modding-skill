using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000371")]
public class WaterRenderTargetManager : MonoBehaviour
{
	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FA")]
	public static WaterRenderTargetManager Instance
	{
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0xDFE144", Offset = "0xDFE144", VA = "0xDFE144")]
		get
		{
			return null;
		}
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0xDFE27C", Offset = "0xDFE27C", VA = "0xDFE27C")]
	private void InitialiseCamera()
	{
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0xDFE714", Offset = "0xDFE714", VA = "0xDFE714")]
	public void UpdateRenderTarget()
	{
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0xDFE7AC", Offset = "0xDFE7AC", VA = "0xDFE7AC")]
	public WaterRenderTargetManager()
	{
	}

	// Token: 0x04002A12 RID: 10770
	[Token(Token = "0x4002A12")]
	[FieldOffset(Offset = "0x0")]
	public static WaterRenderTargetManager _instance;

	// Token: 0x04002A13 RID: 10771
	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0xC")]
	private Camera cameraObject;

	// Token: 0x04002A14 RID: 10772
	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0x10")]
	public RenderTexture RenderTarget;

	// Token: 0x04002A15 RID: 10773
	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x14")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameRenderTarget;
}
