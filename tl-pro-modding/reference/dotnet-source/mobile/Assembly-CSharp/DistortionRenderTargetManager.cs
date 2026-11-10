using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x0200036B RID: 875
[Token(Token = "0x200036B")]
public class DistortionRenderTargetManager : MonoBehaviour
{
	// Token: 0x170001ED RID: 493
	// (get) Token: 0x0600158A RID: 5514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001ED")]
	public static DistortionRenderTargetManager Instance
	{
		[Token(Token = "0x600158A")]
		[Address(RVA = "0xDFB534", Offset = "0xDFB534", VA = "0xDFB534")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600158B RID: 5515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158B")]
	[Address(RVA = "0xDFB66C", Offset = "0xDFB66C", VA = "0xDFB66C")]
	private void InitialiseCamera()
	{
	}

	// Token: 0x0600158C RID: 5516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158C")]
	[Address(RVA = "0xDFBD78", Offset = "0xDFBD78", VA = "0xDFBD78")]
	public void ClearRenderTarget()
	{
	}

	// Token: 0x0600158D RID: 5517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158D")]
	[Address(RVA = "0xDFBFC4", Offset = "0xDFBFC4", VA = "0xDFBFC4")]
	public void SwapTargets()
	{
	}

	// Token: 0x0600158E RID: 5518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158E")]
	[Address(RVA = "0xDFBE04", Offset = "0xDFBE04", VA = "0xDFBE04")]
	public void BeginRenderTarget(bool clear, float clearValue)
	{
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600158F")]
	[Address(RVA = "0xDFBF44", Offset = "0xDFBF44", VA = "0xDFBF44")]
	public void EndRenderTarget()
	{
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001590")]
	[Address(RVA = "0xDFC080", Offset = "0xDFC080", VA = "0xDFC080")]
	public DistortionRenderTargetManager()
	{
	}

	// Token: 0x040029E4 RID: 10724
	[Token(Token = "0x40029E4")]
	[FieldOffset(Offset = "0x0")]
	public static DistortionRenderTargetManager _instance;

	// Token: 0x040029E5 RID: 10725
	[Token(Token = "0x40029E5")]
	[FieldOffset(Offset = "0xC")]
	private Camera cameraObject;

	// Token: 0x040029E6 RID: 10726
	[Token(Token = "0x40029E6")]
	[FieldOffset(Offset = "0x10")]
	public RenderTexture DistortionTarget;

	// Token: 0x040029E7 RID: 10727
	[Token(Token = "0x40029E7")]
	[FieldOffset(Offset = "0x14")]
	public RenderTexture DistortionTargetSwap;

	// Token: 0x040029E8 RID: 10728
	[Token(Token = "0x40029E8")]
	[FieldOffset(Offset = "0x18")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTarget;

	// Token: 0x040029E9 RID: 10729
	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x1C")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTargetSwap;
}
