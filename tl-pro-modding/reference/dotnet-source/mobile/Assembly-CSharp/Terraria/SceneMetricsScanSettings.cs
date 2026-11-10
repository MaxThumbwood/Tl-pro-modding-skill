using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	public struct SceneMetricsScanSettings
	{
		// Token: 0x040042D8 RID: 17112
		[Token(Token = "0x40042D8")]
		[FieldOffset(Offset = "0x0")]
		public Rectangle? VisualScanArea;

		// Token: 0x040042D9 RID: 17113
		[Token(Token = "0x40042D9")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 BiomeScanCenterPositionInWorld;

		// Token: 0x040042DA RID: 17114
		[Token(Token = "0x40042DA")]
		[FieldOffset(Offset = "0x1C")]
		public bool ScanNPCPositions;

		// Token: 0x040042DB RID: 17115
		[Token(Token = "0x40042DB")]
		[FieldOffset(Offset = "0x20")]
		public Player PerspectivePlayer;
	}
}
