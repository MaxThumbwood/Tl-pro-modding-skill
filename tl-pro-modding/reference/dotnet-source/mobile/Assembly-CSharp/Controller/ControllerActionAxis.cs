using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000E1D RID: 3613
	[Token(Token = "0x2000E1D")]
	public class ControllerActionAxis
	{
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x0002FC40 File Offset: 0x0002DE40
		[Token(Token = "0x17000B57")]
		public bool HasMapping
		{
			[Token(Token = "0x60069A2")]
			[Address(RVA = "0xB89588", Offset = "0xB89588", VA = "0xB89588")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x0002FC58 File Offset: 0x0002DE58
		[Token(Token = "0x60069A3")]
		[Address(RVA = "0xB895E4", Offset = "0xB895E4", VA = "0xB895E4")]
		public bool RequiredStateValid(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x0002FC70 File Offset: 0x0002DE70
		[Token(Token = "0x60069A4")]
		[Address(RVA = "0xB89AA0", Offset = "0xB89AA0", VA = "0xB89AA0")]
		public bool Active(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B58")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[Token(Token = "0x60069A5")]
			[Address(RVA = "0xB897C8", Offset = "0xB897C8", VA = "0xB897C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060069A6 RID: 27046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B59")]
		public ControllerActionAxis.Entry FirstEntry
		{
			[Token(Token = "0x60069A6")]
			[Address(RVA = "0xB8984C", Offset = "0xB8984C", VA = "0xB8984C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A7")]
		[Address(RVA = "0xB8A860", Offset = "0xB8A860", VA = "0xB8A860")]
		public void MapAxis(Axis axis, float threshold = 0f, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState)
		{
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A8")]
		[Address(RVA = "0xB8A9CC", Offset = "0xB8A9CC", VA = "0xB8A9CC")]
		public void MapMultipleAxis(Axis axis1, Axis axis2)
		{
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A9")]
		[Address(RVA = "0xB8AB10", Offset = "0xB8AB10", VA = "0xB8AB10")]
		public void MapButtons(Buttons button0, Buttons button1)
		{
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AA")]
		[Address(RVA = "0xB8AC54", Offset = "0xB8AC54", VA = "0xB8AC54")]
		public void MapKeys(KeyCode key0, KeyCode key1)
		{
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x0002FC88 File Offset: 0x0002DE88
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0xB89D20", Offset = "0xB89D20", VA = "0xB89D20")]
		public float GetValue(ControllerDevice controller)
		{
			return 0f;
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0xB8AEB8", Offset = "0xB8AEB8", VA = "0xB8AEB8")]
		public void Clear()
		{
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0xB8AF38", Offset = "0xB8AF38", VA = "0xB8AF38")]
		public ControllerActionAxis()
		{
		}

		// Token: 0x0400A70A RID: 42762
		[Token(Token = "0x400A70A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float ElapsedTime;

		// Token: 0x0400A70B RID: 42763
		[Token(Token = "0x400A70B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Id;

		// Token: 0x0400A70C RID: 42764
		[Token(Token = "0x400A70C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool Enabled;

		// Token: 0x0400A70D RID: 42765
		[Token(Token = "0x400A70D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool TimeBased;

		// Token: 0x0400A70E RID: 42766
		[Token(Token = "0x400A70E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Scale;

		// Token: 0x0400A70F RID: 42767
		[Token(Token = "0x400A70F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool DisableUnitlClear;

		// Token: 0x0400A710 RID: 42768
		[Token(Token = "0x400A710")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool ValidUnitlClear;

		// Token: 0x0400A711 RID: 42769
		[Token(Token = "0x400A711")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ControllerActionAxis.Entry> _entries;

		// Token: 0x02000E1E RID: 3614
		[Token(Token = "0x2000E1E")]
		public class Entry
		{
			// Token: 0x060069AE RID: 27054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069AE")]
			[Address(RVA = "0xB8A9C4", Offset = "0xB8A9C4", VA = "0xB8A9C4")]
			public Entry()
			{
			}

			// Token: 0x0400A712 RID: 42770
			[Token(Token = "0x400A712")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ControllerActionAxis.Entry.Type MappingType;

			// Token: 0x0400A713 RID: 42771
			[Token(Token = "0x400A713")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Axis Axis0;

			// Token: 0x0400A714 RID: 42772
			[Token(Token = "0x400A714")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Axis Axis1;

			// Token: 0x0400A715 RID: 42773
			[Token(Token = "0x400A715")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Threshold;

			// Token: 0x0400A716 RID: 42774
			[Token(Token = "0x400A716")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Buttons Button0;

			// Token: 0x0400A717 RID: 42775
			[Token(Token = "0x400A717")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Buttons Button1;

			// Token: 0x0400A718 RID: 42776
			[Token(Token = "0x400A718")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode Key0;

			// Token: 0x0400A719 RID: 42777
			[Token(Token = "0x400A719")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public KeyCode Key1;

			// Token: 0x0400A71A RID: 42778
			[Token(Token = "0x400A71A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ControllerActionButton.RequiredButtonState RequiredState;

			// Token: 0x02000E1F RID: 3615
			[Token(Token = "0x2000E1F")]
			public enum Type
			{
				// Token: 0x0400A71C RID: 42780
				[Token(Token = "0x400A71C")]
				SingleAxis,
				// Token: 0x0400A71D RID: 42781
				[Token(Token = "0x400A71D")]
				MultipleAxis,
				// Token: 0x0400A71E RID: 42782
				[Token(Token = "0x400A71E")]
				Buttons,
				// Token: 0x0400A71F RID: 42783
				[Token(Token = "0x400A71F")]
				Keys
			}
		}
	}
}
