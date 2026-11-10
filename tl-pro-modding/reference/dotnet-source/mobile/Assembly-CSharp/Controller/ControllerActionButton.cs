using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Controller
{
	// Token: 0x02000E20 RID: 3616
	[Token(Token = "0x2000E20")]
	public class ControllerActionButton
	{
		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
		[Token(Token = "0x17000B5A")]
		public bool HasMapping
		{
			[Token(Token = "0x60069AF")]
			[Address(RVA = "0xB8AFE0", Offset = "0xB8AFE0", VA = "0xB8AFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060069B0 RID: 27056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5B")]
		public ControllerActionButton.RequiredButtonState RequiredState
		{
			[Token(Token = "0x60069B0")]
			[Address(RVA = "0xB8B03C", Offset = "0xB8B03C", VA = "0xB8B03C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060069B1 RID: 27057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5C")]
		public ControllerActionButton.Entry FirstEntry
		{
			[Token(Token = "0x60069B1")]
			[Address(RVA = "0xB8B0C0", Offset = "0xB8B0C0", VA = "0xB8B0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B2")]
		[Address(RVA = "0xB8B128", Offset = "0xB8B128", VA = "0xB8B128")]
		public ControllerActionButton.Entry GetEntry(int index)
		{
			return null;
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		[Token(Token = "0x60069B3")]
		[Address(RVA = "0xB8B1C8", Offset = "0xB8B1C8", VA = "0xB8B1C8")]
		public bool Conflicts(ControllerActionButton other)
		{
			return default(bool);
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B4")]
		[Address(RVA = "0xB8B464", Offset = "0xB8B464", VA = "0xB8B464")]
		public void MapAxis(Axis axis, float threshold, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B5")]
		[Address(RVA = "0xB8B5E4", Offset = "0xB8B5E4", VA = "0xB8B5E4")]
		public void MapButton(Buttons button, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B6")]
		[Address(RVA = "0xB8B740", Offset = "0xB8B740", VA = "0xB8B740")]
		public void MapAxisButton(AxisButtons button, [Optional] ControllerActionButton.RequiredButtonState requiredButtonState, bool ignoreOthersIfExists = true)
		{
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B7")]
		[Address(RVA = "0xB8B7E4", Offset = "0xB8B7E4", VA = "0xB8B7E4")]
		public void MapKey(KeyCode key, bool ignoreOthersIfExists = false)
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x0002FCD0 File Offset: 0x0002DED0
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0xB8B928", Offset = "0xB8B928", VA = "0xB8B928")]
		public bool RequiredStateValid(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0xB8BAC8", Offset = "0xB8BAC8", VA = "0xB8BAC8")]
		public bool GetButtonState(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x0002FD00 File Offset: 0x0002DF00
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0xB8C768", Offset = "0xB8C768", VA = "0xB8C768")]
		public bool GetButtonDown(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x0002FD18 File Offset: 0x0002DF18
		[Token(Token = "0x60069BB")]
		[Address(RVA = "0xB8D1F0", Offset = "0xB8D1F0", VA = "0xB8D1F0")]
		public bool GetButtonUp(ControllerDevice controller)
		{
			return default(bool);
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BC")]
		[Address(RVA = "0xB8E30C", Offset = "0xB8E30C", VA = "0xB8E30C")]
		public void Clear()
		{
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BD")]
		[Address(RVA = "0xB8E38C", Offset = "0xB8E38C", VA = "0xB8E38C")]
		public ControllerActionButton()
		{
		}

		// Token: 0x0400A720 RID: 42784
		[Token(Token = "0x400A720")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Id;

		// Token: 0x0400A721 RID: 42785
		[Token(Token = "0x400A721")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool Enabled;

		// Token: 0x0400A722 RID: 42786
		[Token(Token = "0x400A722")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool DisableUnitlClear;

		// Token: 0x0400A723 RID: 42787
		[Token(Token = "0x400A723")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool ValidUnitlClear;

		// Token: 0x0400A724 RID: 42788
		[Token(Token = "0x400A724")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int DisplayPriority;

		// Token: 0x0400A725 RID: 42789
		[Token(Token = "0x400A725")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ControllerActionButton LinkedAction;

		// Token: 0x0400A726 RID: 42790
		[Token(Token = "0x400A726")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ControllerActionButton.Entry> _entries;

		// Token: 0x02000E21 RID: 3617
		[Token(Token = "0x2000E21")]
		public class RequiredButtonState
		{
			// Token: 0x060069BE RID: 27070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069BE")]
			[Address(RVA = "0xB8E42C", Offset = "0xB8E42C", VA = "0xB8E42C")]
			public RequiredButtonState()
			{
			}

			// Token: 0x060069BF RID: 27071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069BF")]
			[Address(RVA = "0xB8E440", Offset = "0xB8E440", VA = "0xB8E440")]
			public RequiredButtonState(Buttons button, bool requiredState)
			{
			}

			// Token: 0x060069C0 RID: 27072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C0")]
			[Address(RVA = "0xB8E474", Offset = "0xB8E474", VA = "0xB8E474")]
			public RequiredButtonState(Buttons button, bool requiredState, Buttons button2, bool requiredState2)
			{
			}

			// Token: 0x060069C1 RID: 27073 RVA: 0x0002FD30 File Offset: 0x0002DF30
			[Token(Token = "0x60069C1")]
			[Address(RVA = "0xB8A758", Offset = "0xB8A758", VA = "0xB8A758")]
			public bool Active(ControllerDevice device, float buttonPressTime, float axisValue)
			{
				return default(bool);
			}

			// Token: 0x060069C2 RID: 27074 RVA: 0x0002FD48 File Offset: 0x0002DF48
			[Token(Token = "0x60069C2")]
			[Address(RVA = "0xB898D8", Offset = "0xB898D8", VA = "0xB898D8")]
			public bool Valid(ControllerDevice device, float buttonPressTime)
			{
				return default(bool);
			}

			// Token: 0x060069C3 RID: 27075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C3")]
			[Address(RVA = "0xB8ADE8", Offset = "0xB8ADE8", VA = "0xB8ADE8")]
			public void ConsumeModifiers(ControllerDevice device)
			{
			}

			// Token: 0x0400A727 RID: 42791
			[Token(Token = "0x400A727")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Buttons Button;

			// Token: 0x0400A728 RID: 42792
			[Token(Token = "0x400A728")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool state;

			// Token: 0x0400A729 RID: 42793
			[Token(Token = "0x400A729")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Buttons Button2;

			// Token: 0x0400A72A RID: 42794
			[Token(Token = "0x400A72A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool state2;
		}

		// Token: 0x02000E22 RID: 3618
		[Token(Token = "0x2000E22")]
		public class Entry
		{
			// Token: 0x060069C4 RID: 27076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069C4")]
			[Address(RVA = "0xB8B5DC", Offset = "0xB8B5DC", VA = "0xB8B5DC")]
			public Entry()
			{
			}

			// Token: 0x0400A72B RID: 42795
			[Token(Token = "0x400A72B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ControllerActionButton.Entry.Type MappingType;

			// Token: 0x0400A72C RID: 42796
			[Token(Token = "0x400A72C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Axis Axis0;

			// Token: 0x0400A72D RID: 42797
			[Token(Token = "0x400A72D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float Threshold;

			// Token: 0x0400A72E RID: 42798
			[Token(Token = "0x400A72E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Buttons Button;

			// Token: 0x0400A72F RID: 42799
			[Token(Token = "0x400A72F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public KeyCode InputKey;

			// Token: 0x0400A730 RID: 42800
			[Token(Token = "0x400A730")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool IgnoreOthersIfExists;

			// Token: 0x0400A731 RID: 42801
			[Token(Token = "0x400A731")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ControllerActionButton.RequiredButtonState RequiredState;

			// Token: 0x02000E23 RID: 3619
			[Token(Token = "0x2000E23")]
			public enum Type
			{
				// Token: 0x0400A733 RID: 42803
				[Token(Token = "0x400A733")]
				Axis,
				// Token: 0x0400A734 RID: 42804
				[Token(Token = "0x400A734")]
				Button,
				// Token: 0x0400A735 RID: 42805
				[Token(Token = "0x400A735")]
				InputKey
			}
		}
	}
}
