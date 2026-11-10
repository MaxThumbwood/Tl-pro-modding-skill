using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000E24 RID: 3620
	[Token(Token = "0x2000E24")]
	public class ControllerActionVector
	{
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060069C5 RID: 27077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5D")]
		public ControllerActionAxis MappedX
		{
			[Token(Token = "0x60069C5")]
			[Address(RVA = "0xB8E504", Offset = "0xB8E504", VA = "0xB8E504")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060069C6 RID: 27078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5E")]
		public ControllerActionAxis MappedY
		{
			[Token(Token = "0x60069C6")]
			[Address(RVA = "0xB8E678", Offset = "0xB8E678", VA = "0xB8E678")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060069C7 RID: 27079 RVA: 0x0002FD60 File Offset: 0x0002DF60
		[Token(Token = "0x17000B5F")]
		public bool HasMapping
		{
			[Token(Token = "0x60069C7")]
			[Address(RVA = "0xB8E5A4", Offset = "0xB8E5A4", VA = "0xB8E5A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060069C8 RID: 27080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B60")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[Token(Token = "0x60069C8")]
			[Address(RVA = "0xB8E718", Offset = "0xB8E718", VA = "0xB8E718")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060069C9 RID: 27081 RVA: 0x0002FD78 File Offset: 0x0002DF78
		[Token(Token = "0x17000B61")]
		public bool HasMappingExcludeLinked
		{
			[Token(Token = "0x60069C9")]
			[Address(RVA = "0xB8E838", Offset = "0xB8E838", VA = "0xB8E838")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B62")]
		public ControllerActionButton.RequiredButtonState RequiredStateExcludeLinked
		{
			[Token(Token = "0x60069CA")]
			[Address(RVA = "0xB8E8FC", Offset = "0xB8E8FC", VA = "0xB8E8FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x0002FD90 File Offset: 0x0002DF90
		[Token(Token = "0x60069CB")]
		[Address(RVA = "0xB8E9F4", Offset = "0xB8E9F4", VA = "0xB8E9F4")]
		public bool Active(ControllerDevice device)
		{
			return default(bool);
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		[Token(Token = "0x60069CC")]
		[Address(RVA = "0xB8EA64", Offset = "0xB8EA64", VA = "0xB8EA64")]
		public bool RequiredStateValid(ControllerDevice device)
		{
			return default(bool);
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		[Token(Token = "0x60069CD")]
		[Address(RVA = "0xB8EABC", Offset = "0xB8EABC", VA = "0xB8EABC")]
		public Vector2 GetValue(ControllerDevice controller)
		{
			return default(Vector2);
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069CE")]
		[Address(RVA = "0xB8EC98", Offset = "0xB8EC98", VA = "0xB8EC98")]
		public ControllerActionVector()
		{
		}

		// Token: 0x0400A736 RID: 42806
		[Token(Token = "0x400A736")]
		[FieldOffset(Offset = "0x8")]
		public string Id;

		// Token: 0x0400A737 RID: 42807
		[Token(Token = "0x400A737")]
		[FieldOffset(Offset = "0xC")]
		public ControllerActionAxis X;

		// Token: 0x0400A738 RID: 42808
		[Token(Token = "0x400A738")]
		[FieldOffset(Offset = "0x10")]
		public ControllerActionAxis Y;

		// Token: 0x0400A739 RID: 42809
		[Token(Token = "0x400A739")]
		[FieldOffset(Offset = "0x14")]
		public int DisplayPriority;

		// Token: 0x0400A73A RID: 42810
		[Token(Token = "0x400A73A")]
		[FieldOffset(Offset = "0x18")]
		public ControllerActionVector LinkedAction;

		// Token: 0x0400A73B RID: 42811
		[Token(Token = "0x400A73B")]
		[FieldOffset(Offset = "0x1C")]
		public bool Enabled;

		// Token: 0x0400A73C RID: 42812
		[Token(Token = "0x400A73C")]
		[FieldOffset(Offset = "0x1D")]
		public bool DisabledUntilClear;
	}
}
