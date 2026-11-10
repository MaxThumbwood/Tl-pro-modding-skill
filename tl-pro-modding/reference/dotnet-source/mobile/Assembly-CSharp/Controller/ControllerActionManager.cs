using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Controller
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	public class ControllerActionManager
	{
		// Token: 0x060069CF RID: 27087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069CF")]
		[Address(RVA = "0xB8ECA8", Offset = "0xB8ECA8", VA = "0xB8ECA8")]
		public static ControllerActionManager Create()
		{
			return null;
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		[Token(Token = "0x60069D0")]
		[Address(RVA = "0xB8B7A4", Offset = "0xB8B7A4", VA = "0xB8B7A4")]
		public static Axis GetAxisThreshold(AxisButtons button, out float threshold)
		{
			return Axis.LeftXAxis;
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D1")]
		[Address(RVA = "0xB8ED1C", Offset = "0xB8ED1C", VA = "0xB8ED1C")]
		public ControllerActionManager()
		{
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D2")]
		[Address(RVA = "0xB8EEC8", Offset = "0xB8EEC8", VA = "0xB8EEC8")]
		public ControllerActionButton CreateButtonMapping(string id)
		{
			return null;
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D3")]
		[Address(RVA = "0xB8F0A0", Offset = "0xB8F0A0", VA = "0xB8F0A0")]
		public ControllerActionAxis CreateAxisMapping(string id, bool timeBased, float axisScale)
		{
			return null;
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D4")]
		[Address(RVA = "0xB8F1E4", Offset = "0xB8F1E4", VA = "0xB8F1E4")]
		public ControllerActionVector CreateVectorMapping(string id, ControllerActionAxis axisX, ControllerActionAxis axisY)
		{
			return null;
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D5")]
		[Address(RVA = "0xB8F384", Offset = "0xB8F384", VA = "0xB8F384")]
		public ControllerActionAxis GetAxisMapping(string id)
		{
			return null;
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D6")]
		[Address(RVA = "0xB8F478", Offset = "0xB8F478", VA = "0xB8F478")]
		public ControllerActionButton GetButtonMapping(string id)
		{
			return null;
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069D7")]
		[Address(RVA = "0xB8F56C", Offset = "0xB8F56C", VA = "0xB8F56C")]
		public ControllerActionVector GetVectorMapping(string id)
		{
			return null;
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
		[Token(Token = "0x17000B63")]
		public bool HasController
		{
			[Token(Token = "0x60069D8")]
			[Address(RVA = "0xB8F660", Offset = "0xB8F660", VA = "0xB8F660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060069D9 RID: 27097 RVA: 0x0002FE08 File Offset: 0x0002E008
		[Token(Token = "0x17000B64")]
		public bool IsControllerActive
		{
			[Token(Token = "0x60069D9")]
			[Address(RVA = "0xB8F744", Offset = "0xB8F744", VA = "0xB8F744")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DA")]
		[Address(RVA = "0xB8F74C", Offset = "0xB8F74C", VA = "0xB8F74C")]
		public void ForceActiveController(ControllerDevice controller)
		{
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DB")]
		[Address(RVA = "0xB8F758", Offset = "0xB8F758", VA = "0xB8F758")]
		public void OnUpdate(float elapsedTime)
		{
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060069DC RID: 27100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B65")]
		public ControllerDevice ActiveController
		{
			[Token(Token = "0x60069DC")]
			[Address(RVA = "0xB8FCF4", Offset = "0xB8FCF4", VA = "0xB8FCF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060069DD RID: 27101 RVA: 0x0002FE20 File Offset: 0x0002E020
		[Token(Token = "0x17000B66")]
		public static bool AnyControllerConnected
		{
			[Token(Token = "0x60069DD")]
			[Address(RVA = "0xB8FD88", Offset = "0xB8FD88", VA = "0xB8FD88")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400A764 RID: 42852
		[Token(Token = "0x400A764")]
		[FieldOffset(Offset = "0x0")]
		public static ControllerActionManager Instance;

		// Token: 0x0400A765 RID: 42853
		[Token(Token = "0x400A765")]
		[FieldOffset(Offset = "0x8")]
		private List<ControllerActionAxis> _axisMappings;

		// Token: 0x0400A766 RID: 42854
		[Token(Token = "0x400A766")]
		[FieldOffset(Offset = "0xC")]
		private List<ControllerActionButton> _buttonMappings;

		// Token: 0x0400A767 RID: 42855
		[Token(Token = "0x400A767")]
		[FieldOffset(Offset = "0x10")]
		private List<ControllerActionVector> _vectorMappings;

		// Token: 0x0400A768 RID: 42856
		[Token(Token = "0x400A768")]
		[FieldOffset(Offset = "0x14")]
		private ControllerDevice _controller;

		// Token: 0x0400A769 RID: 42857
		[Token(Token = "0x400A769")]
		[FieldOffset(Offset = "0x18")]
		private bool _controllerActive;

		// Token: 0x0400A76A RID: 42858
		[Token(Token = "0x400A76A")]
		[FieldOffset(Offset = "0x1C")]
		private ControllerDevice _forcedActiveController;

		// Token: 0x0400A76B RID: 42859
		[Token(Token = "0x400A76B")]
		[FieldOffset(Offset = "0x20")]
		private bool _pendingDisableActions;

		// Token: 0x0400A76C RID: 42860
		[Token(Token = "0x400A76C")]
		[FieldOffset(Offset = "0x24")]
		private string[] _pendingDisableActionsList;

		// Token: 0x0400A76D RID: 42861
		[Token(Token = "0x400A76D")]
		[FieldOffset(Offset = "0x28")]
		private bool _pendingEnableActions;
	}
}
