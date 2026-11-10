using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using InControl;

namespace Controller
{
	// Token: 0x02000E29 RID: 3625
	[Token(Token = "0x2000E29")]
	public class ControllerDeviceManager : Singleton<ControllerDeviceManager>
	{
		// Token: 0x060069DE RID: 27102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DE")]
		[Address(RVA = "0xB90040", Offset = "0xB90040", VA = "0xB90040")]
		public void UpdateConnectedControllers(float elapsedTime, bool forceUpdate = false)
		{
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xB91470", Offset = "0xB91470", VA = "0xB91470")]
		private void UpdateDevices(float elapsedTime)
		{
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xB91E80", Offset = "0xB91E80", VA = "0xB91E80")]
		public ControllerDeviceManager()
		{
		}

		// Token: 0x0400A76E RID: 42862
		[Token(Token = "0x400A76E")]
		[FieldOffset(Offset = "0xC")]
		private int lastFrame;

		// Token: 0x0400A76F RID: 42863
		[Token(Token = "0x400A76F")]
		[FieldOffset(Offset = "0x10")]
		public List<ControllerDevice> AttachedDevices;

		// Token: 0x0400A770 RID: 42864
		[Token(Token = "0x400A770")]
		[FieldOffset(Offset = "0x14")]
		private List<ControllerDevice> _deviceUpdateList;

		// Token: 0x0400A771 RID: 42865
		[Token(Token = "0x400A771")]
		[FieldOffset(Offset = "0x18")]
		private List<UnityInputDevice> _joyConUpdateList;

		// Token: 0x0400A772 RID: 42866
		[Token(Token = "0x400A772")]
		[FieldOffset(Offset = "0x1C")]
		public List<ControllerDevice> UnconfiguredList;

		// Token: 0x0400A773 RID: 42867
		[Token(Token = "0x400A773")]
		[FieldOffset(Offset = "0x20")]
		private List<ControllerDevice> _unconfiguredUpdateList;

		// Token: 0x0400A774 RID: 42868
		[Token(Token = "0x400A774")]
		[FieldOffset(Offset = "0x24")]
		public List<ControllerDevice> ActiveControllers;
	}
}
