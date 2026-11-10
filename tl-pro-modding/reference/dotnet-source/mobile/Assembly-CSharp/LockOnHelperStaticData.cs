using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.GameInput;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000335")]
public class LockOnHelperStaticData
{
	// Token: 0x170001DC RID: 476
	// (get) Token: 0x0600143F RID: 5183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001DC")]
	public static LockOnHelperStaticData Instance
	{
		[Token(Token = "0x600143F")]
		[Address(RVA = "0xDBDFEC", Offset = "0xDBDFEC", VA = "0xDBDFEC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001440")]
	[Address(RVA = "0xDA782C", Offset = "0xDA782C", VA = "0xDA782C")]
	public LockOnHelperStaticData()
	{
	}

	// Token: 0x04002804 RID: 10244
	[Token(Token = "0x4002804")]
	[FieldOffset(Offset = "0x8")]
	public LockOnHelper.LockOnMode UseMode;

	// Token: 0x04002805 RID: 10245
	[Token(Token = "0x4002805")]
	[FieldOffset(Offset = "0xC")]
	public bool _enabled;

	// Token: 0x04002806 RID: 10246
	[Token(Token = "0x4002806")]
	[FieldOffset(Offset = "0xD")]
	public bool _canLockOn;

	// Token: 0x04002807 RID: 10247
	[Token(Token = "0x4002807")]
	[FieldOffset(Offset = "0x10")]
	public List<int> _targets;

	// Token: 0x04002808 RID: 10248
	[Token(Token = "0x4002808")]
	[FieldOffset(Offset = "0x14")]
	public int _pickedTarget;

	// Token: 0x04002809 RID: 10249
	[Token(Token = "0x4002809")]
	[FieldOffset(Offset = "0x18")]
	public int _lifeTimeCounter;

	// Token: 0x0400280A RID: 10250
	[Token(Token = "0x400280A")]
	[FieldOffset(Offset = "0x1C")]
	public int _lifeTimeArrowDisplay;

	// Token: 0x0400280B RID: 10251
	[Token(Token = "0x400280B")]
	[FieldOffset(Offset = "0x20")]
	public int _threeDSTarget;

	// Token: 0x0400280C RID: 10252
	[Token(Token = "0x400280C")]
	[FieldOffset(Offset = "0x24")]
	public int _targetClosestTarget;

	// Token: 0x0400280D RID: 10253
	[Token(Token = "0x400280D")]
	[FieldOffset(Offset = "0x28")]
	public bool ForceUsability;

	// Token: 0x0400280E RID: 10254
	[Token(Token = "0x400280E")]
	[FieldOffset(Offset = "0x29")]
	public bool LockOnAvailable;

	// Token: 0x0400280F RID: 10255
	[Token(Token = "0x400280F")]
	[FieldOffset(Offset = "0x2C")]
	public int _lastFrame;

	// Token: 0x04002810 RID: 10256
	[Token(Token = "0x4002810")]
	[FieldOffset(Offset = "0x30")]
	public float[,] _drawProgress;
}
