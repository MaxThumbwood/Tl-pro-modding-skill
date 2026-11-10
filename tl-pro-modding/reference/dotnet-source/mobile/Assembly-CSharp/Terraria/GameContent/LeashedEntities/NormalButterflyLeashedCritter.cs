using System;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x2000A51")]
	public class NormalButterflyLeashedCritter : FlyLeashedCritter
	{
		// Token: 0x060054A6 RID: 21670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x819A40", Offset = "0x819A40", VA = "0x819A40", Slot = "11")]
		protected override void SetDefaults(Item sample)
		{
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A7")]
		[Address(RVA = "0x819A68", Offset = "0x819A68", VA = "0x819A68", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x819B94", Offset = "0x819B94", VA = "0x819B94", Slot = "9")]
		public override void NetSend(BinaryWriter writer, bool full)
		{
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x819E38", Offset = "0x819E38", VA = "0x819E38", Slot = "10")]
		public override void NetReceive(BinaryReader reader, bool full)
		{
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AA")]
		[Address(RVA = "0x81A1E0", Offset = "0x81A1E0", VA = "0x81A1E0")]
		public NormalButterflyLeashedCritter()
		{
		}

		// Token: 0x0400981A RID: 38938
		[Token(Token = "0x400981A")]
		[FieldOffset(Offset = "0x0")]
		public new static NormalButterflyLeashedCritter Prototype;

		// Token: 0x0400981B RID: 38939
		[Token(Token = "0x400981B")]
		[FieldOffset(Offset = "0xA5")]
		protected byte variant;
	}
}
