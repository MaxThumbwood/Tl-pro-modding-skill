using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Utilities;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A5E RID: 2654
	[Token(Token = "0x2000A5E")]
	public abstract class LeashedCritter : LeashedEntity
	{
		// Token: 0x060054E2 RID: 21730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x81F9E8", Offset = "0x81F9E8", VA = "0x81F9E8")]
		public void SetDefaults(int itemType)
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x8198DC", Offset = "0x8198DC", VA = "0x8198DC", Slot = "11")]
		protected virtual void SetDefaults(Item sample)
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E4")]
		[Address(RVA = "0x819BDC", Offset = "0x819BDC", VA = "0x819BDC", Slot = "9")]
		public override void NetSend(BinaryWriter writer, bool full)
		{
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x819E7C", Offset = "0x819E7C", VA = "0x819E7C", Slot = "10")]
		public override void NetReceive(BinaryReader reader, bool full)
		{
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x817AD0", Offset = "0x817AD0", VA = "0x817AD0", Slot = "5")]
		public override void Spawn(bool newlyAdded)
		{
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x8188CC", Offset = "0x8188CC", VA = "0x8188CC", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E8")]
		[Address(RVA = "0x81E388", Offset = "0x81E388", VA = "0x81E388")]
		protected void Recall()
		{
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E9")]
		[Address(RVA = "0x81FAA4", Offset = "0x81FAA4", VA = "0x81FAA4")]
		private void Recall_CreateDustAtLocation()
		{
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EA")]
		[Address(RVA = "0x81AED0", Offset = "0x81AED0", VA = "0x81AED0", Slot = "12")]
		protected virtual void VisualEffects()
		{
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EB")]
		[Address(RVA = "0x817D30", Offset = "0x817D30", VA = "0x817D30", Slot = "13")]
		protected virtual void CopyToDummy()
		{
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054EC")]
		[Address(RVA = "0x818B1C", Offset = "0x818B1C", VA = "0x818B1C")]
		protected void CopyFromDummy()
		{
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054ED")]
		[Address(RVA = "0x81C3B0", Offset = "0x81C3B0", VA = "0x81C3B0", Slot = "8")]
		public override void Draw()
		{
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00027468 File Offset: 0x00025668
		[Token(Token = "0x60054EE")]
		[Address(RVA = "0x81FB94", Offset = "0x81FB94", VA = "0x81FB94")]
		private bool ShouldDrawBubble()
		{
			return default(bool);
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00027480 File Offset: 0x00025680
		[Token(Token = "0x60054EF")]
		[Address(RVA = "0x820548", Offset = "0x820548", VA = "0x820548")]
		private bool TileRequiresBubble(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00027498 File Offset: 0x00025698
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0x81F490", Offset = "0x81F490", VA = "0x81F490", Slot = "14")]
		public virtual Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x060054F1 RID: 21745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F1")]
		[Address(RVA = "0x820064", Offset = "0x820064", VA = "0x820064")]
		protected void DrawBubble()
		{
		}

		// Token: 0x060054F2 RID: 21746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F2")]
		[Address(RVA = "0x8179C0", Offset = "0x8179C0", VA = "0x8179C0")]
		protected LeashedCritter()
		{
		}

		// Token: 0x04009839 RID: 38969
		[Token(Token = "0x4009839")]
		[FieldOffset(Offset = "0x0")]
		protected static NPC _dummy;

		// Token: 0x0400983A RID: 38970
		[Token(Token = "0x400983A")]
		[FieldOffset(Offset = "0x38")]
		public int anchorStyle;

		// Token: 0x0400983B RID: 38971
		[Token(Token = "0x400983B")]
		[FieldOffset(Offset = "0x3C")]
		protected int npcType;

		// Token: 0x0400983C RID: 38972
		[Token(Token = "0x400983C")]
		[FieldOffset(Offset = "0x40")]
		protected int spriteDirection;

		// Token: 0x0400983D RID: 38973
		[Token(Token = "0x400983D")]
		[FieldOffset(Offset = "0x44")]
		protected Rectangle frame;

		// Token: 0x0400983E RID: 38974
		[Token(Token = "0x400983E")]
		[FieldOffset(Offset = "0x58")]
		protected double frameCounter;

		// Token: 0x0400983F RID: 38975
		[Token(Token = "0x400983F")]
		[FieldOffset(Offset = "0x60")]
		protected LCG32Random rand;

		// Token: 0x04009840 RID: 38976
		[Token(Token = "0x4009840")]
		[FieldOffset(Offset = "0x64")]
		protected short WaitTime;

		// Token: 0x04009841 RID: 38977
		[Token(Token = "0x4009841")]
		[FieldOffset(Offset = "0x66")]
		protected byte State;

		// Token: 0x04009842 RID: 38978
		[Token(Token = "0x4009842")]
		[FieldOffset(Offset = "0x68")]
		protected Point16 TargetPosition;

		// Token: 0x04009843 RID: 38979
		[Token(Token = "0x4009843")]
		[FieldOffset(Offset = "0x6C")]
		protected Vector2 netOffset;

		// Token: 0x04009844 RID: 38980
		[Token(Token = "0x4009844")]
		[FieldOffset(Offset = "0x74")]
		protected float scale;

		// Token: 0x04009845 RID: 38981
		[Token(Token = "0x4009845")]
		[FieldOffset(Offset = "0x78")]
		protected int strayingRangeInBlocksX;

		// Token: 0x04009846 RID: 38982
		[Token(Token = "0x4009846")]
		[FieldOffset(Offset = "0x7C")]
		protected int strayingRangeInBlocksY;

		// Token: 0x04009847 RID: 38983
		[Token(Token = "0x4009847")]
		[FieldOffset(Offset = "0x80")]
		protected bool isAquatic;

		// Token: 0x04009848 RID: 38984
		[Token(Token = "0x4009848")]
		[FieldOffset(Offset = "0x81")]
		protected bool drawBubble;

		// Token: 0x04009849 RID: 38985
		[Token(Token = "0x4009849")]
		[FieldOffset(Offset = "0x4")]
		protected static readonly float gravity;

		// Token: 0x0400984A RID: 38986
		[Token(Token = "0x400984A")]
		[FieldOffset(Offset = "0x8")]
		protected static readonly float maxFallSpeed;

		// Token: 0x0400984B RID: 38987
		[Token(Token = "0x400984B")]
		protected const int RecallDuration = 20;
	}
}
