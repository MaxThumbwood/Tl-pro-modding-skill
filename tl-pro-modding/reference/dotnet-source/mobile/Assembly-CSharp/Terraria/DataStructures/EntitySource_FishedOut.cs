using System;
using Il2CppDummyDll;

namespace Terraria.DataStructures
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	public class EntitySource_FishedOut : FileAPI
	{
		// Token: 0x0600444D RID: 17485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600444D")]
		[Address(RVA = "0x558FF4", Offset = "0x558FF4", VA = "0x558FF4")]
		public EntitySource_FishedOut(IEntitySourceTarget entity)
		{
		}

		// Token: 0x04008BDA RID: 35802
		[Token(Token = "0x4008BDA")]
		[FieldOffset(Offset = "0x8")]
		public readonly IEntitySourceTarget Entity;
	}
}
