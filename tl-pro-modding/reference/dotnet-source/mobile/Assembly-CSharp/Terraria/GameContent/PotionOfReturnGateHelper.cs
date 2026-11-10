using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020009F0 RID: 2544
	[Token(Token = "0x20009F0")]
	public struct PotionOfReturnGateHelper
	{
		// Token: 0x060052C3 RID: 21187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x7E531C", Offset = "0x7E531C", VA = "0x7E531C")]
		public PotionOfReturnGateHelper(PotionOfReturnGateHelper.GateType gateType, Vector2 worldPosition, float opacity)
		{
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x7E5438", Offset = "0x7E5438", VA = "0x7E5438")]
		public void Update()
		{
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x7E54D8", Offset = "0x7E54D8", VA = "0x7E54D8")]
		public void SpawnReturnPortalDust()
		{
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x7E6700", Offset = "0x7E6700", VA = "0x7E6700")]
		public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
		{
		}

		// Token: 0x04009700 RID: 38656
		[Token(Token = "0x4009700")]
		[FieldOffset(Offset = "0x0")]
		private readonly Vector2 _position;

		// Token: 0x04009701 RID: 38657
		[Token(Token = "0x4009701")]
		[FieldOffset(Offset = "0x8")]
		private readonly float _opacity;

		// Token: 0x04009702 RID: 38658
		[Token(Token = "0x4009702")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _frameNumber;

		// Token: 0x04009703 RID: 38659
		[Token(Token = "0x4009703")]
		[FieldOffset(Offset = "0x10")]
		private readonly PotionOfReturnGateHelper.GateType _gateType;

		// Token: 0x020009F1 RID: 2545
		[Token(Token = "0x20009F1")]
		public enum GateType
		{
			// Token: 0x04009705 RID: 38661
			[Token(Token = "0x4009705")]
			EntryPoint,
			// Token: 0x04009706 RID: 38662
			[Token(Token = "0x4009706")]
			ExitPoint
		}
	}
}
