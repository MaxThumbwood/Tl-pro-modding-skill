using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A5C RID: 2652
	[Token(Token = "0x2000A5C")]
	public class JumperLeashedCritter : LeashedCritter
	{
		// Token: 0x060054D2 RID: 21714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D2")]
		[Address(RVA = "0x81DAA0", Offset = "0x81DAA0", VA = "0x81DAA0")]
		public JumperLeashedCritter()
		{
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D3")]
		[Address(RVA = "0x81DBB8", Offset = "0x81DBB8", VA = "0x81DBB8", Slot = "5")]
		public override void Spawn(bool newlyAdded)
		{
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D4")]
		[Address(RVA = "0x81DD30", Offset = "0x81DD30", VA = "0x81DD30", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D5")]
		[Address(RVA = "0x81DD08", Offset = "0x81DD08", VA = "0x81DD08")]
		private void SetJumpCooldown()
		{
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x000273F0 File Offset: 0x000255F0
		[Token(Token = "0x60054D6")]
		[Address(RVA = "0x81E13C", Offset = "0x81E13C", VA = "0x81E13C")]
		private bool TryStartJump()
		{
			return default(bool);
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D7")]
		[Address(RVA = "0x81E550", Offset = "0x81E550", VA = "0x81E550")]
		private void Move(out bool hitSomething)
		{
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D8")]
		[Address(RVA = "0x81EB00", Offset = "0x81EB00", VA = "0x81EB00")]
		private void Move_NoObstruction(Point currentTile, float nextY)
		{
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054D9")]
		[Address(RVA = "0x81DBF0", Offset = "0x81DBF0", VA = "0x81DBF0")]
		private void PickNewTarget()
		{
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x00027408 File Offset: 0x00025608
		[Token(Token = "0x60054DA")]
		[Address(RVA = "0x81EDBC", Offset = "0x81EDBC", VA = "0x81EDBC")]
		private bool TryGetReachableTile(int startX, out Point16 tile)
		{
			return default(bool);
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00027420 File Offset: 0x00025620
		[Token(Token = "0x60054DB")]
		[Address(RVA = "0x81EA0C", Offset = "0x81EA0C", VA = "0x81EA0C")]
		private bool CanStandOnTile(Point tile)
		{
			return default(bool);
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DC")]
		[Address(RVA = "0x81F1A4", Offset = "0x81F1A4", VA = "0x81F1A4", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00027438 File Offset: 0x00025638
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x81F254", Offset = "0x81F254", VA = "0x81F254", Slot = "14")]
		public override Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0400982C RID: 38956
		[Token(Token = "0x400982C")]
		[FieldOffset(Offset = "0x0")]
		public static JumperLeashedCritter Prototype;

		// Token: 0x0400982D RID: 38957
		[Token(Token = "0x400982D")]
		private const int State_Normal = 0;

		// Token: 0x0400982E RID: 38958
		[Token(Token = "0x400982E")]
		private const int State_Recalling = 1;

		// Token: 0x0400982F RID: 38959
		[Token(Token = "0x400982F")]
		[FieldOffset(Offset = "0x84")]
		protected int minWaitTime;

		// Token: 0x04009830 RID: 38960
		[Token(Token = "0x4009830")]
		[FieldOffset(Offset = "0x88")]
		protected int maxWaitTime;

		// Token: 0x04009831 RID: 38961
		[Token(Token = "0x4009831")]
		[FieldOffset(Offset = "0x8C")]
		protected float maxJumpWidth;

		// Token: 0x04009832 RID: 38962
		[Token(Token = "0x4009832")]
		[FieldOffset(Offset = "0x90")]
		protected float minJumpWidth;

		// Token: 0x04009833 RID: 38963
		[Token(Token = "0x4009833")]
		[FieldOffset(Offset = "0x94")]
		protected float maxJumpHeight;

		// Token: 0x04009834 RID: 38964
		[Token(Token = "0x4009834")]
		[FieldOffset(Offset = "0x98")]
		protected float maxJumpDuration;

		// Token: 0x04009835 RID: 38965
		[Token(Token = "0x4009835")]
		[FieldOffset(Offset = "0x9C")]
		protected int jumpCooldown;

		// Token: 0x04009836 RID: 38966
		[Token(Token = "0x4009836")]
		[FieldOffset(Offset = "0xA0")]
		protected bool canStandOnWater;

		// Token: 0x04009837 RID: 38967
		[Token(Token = "0x4009837")]
		[FieldOffset(Offset = "0x4")]
		protected static readonly float buoyancy;
	}
}
