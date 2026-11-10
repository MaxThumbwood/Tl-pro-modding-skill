using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A55 RID: 2645
	[Token(Token = "0x2000A55")]
	public class ShimmerFlyLeashedCritter : FlyLeashedCritter
	{
		// Token: 0x060054BA RID: 21690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x81BE24", Offset = "0x81BE24", VA = "0x81BE24", Slot = "11")]
		protected override void SetDefaults(Item sample)
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x81BF40", Offset = "0x81BF40", VA = "0x81BF40", Slot = "9")]
		public override void NetSend(BinaryWriter writer, bool full)
		{
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x81BF88", Offset = "0x81BF88", VA = "0x81BF88", Slot = "10")]
		public override void NetReceive(BinaryReader reader, bool full)
		{
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x81C024", Offset = "0x81C024", VA = "0x81C024", Slot = "12")]
		protected override void VisualEffects()
		{
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x81C140", Offset = "0x81C140", VA = "0x81C140", Slot = "8")]
		public override void Draw()
		{
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x81C72C", Offset = "0x81C72C", VA = "0x81C72C")]
		public ShimmerFlyLeashedCritter()
		{
		}

		// Token: 0x04009823 RID: 38947
		[Token(Token = "0x4009823")]
		[FieldOffset(Offset = "0x0")]
		public new static ShimmerFlyLeashedCritter Prototype;

		// Token: 0x04009824 RID: 38948
		[Token(Token = "0x4009824")]
		[FieldOffset(Offset = "0xA5")]
		private byte oldPositionsLength;

		// Token: 0x04009825 RID: 38949
		[Token(Token = "0x4009825")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2[] oldPositions;
	}
}
