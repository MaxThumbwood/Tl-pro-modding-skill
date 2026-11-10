using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	public class FlyerLeashedCritter : LeashedCritter
	{
		// Token: 0x0600549A RID: 21658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x8178BC", Offset = "0x8178BC", VA = "0x8178BC")]
		public FlyerLeashedCritter()
		{
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549B")]
		[Address(RVA = "0x817A38", Offset = "0x817A38", VA = "0x817A38", Slot = "5")]
		public override void Spawn(bool newlyAdded)
		{
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x817BC8", Offset = "0x817BC8", VA = "0x817BC8")]
		protected void PickNewTarget()
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549D")]
		[Address(RVA = "0x817C8C", Offset = "0x817C8C", VA = "0x817C8C", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x818150", Offset = "0x818150", VA = "0x818150", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x00027360 File Offset: 0x00025560
		[Token(Token = "0x600549F")]
		[Address(RVA = "0x8189F4", Offset = "0x8189F4", VA = "0x8189F4")]
		private bool IsBlockedByMedium(Point origin, Point destination)
		{
			return default(bool);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00027378 File Offset: 0x00025578
		[Token(Token = "0x60054A0")]
		[Address(RVA = "0x818BEC", Offset = "0x818BEC", VA = "0x818BEC")]
		private bool IsLiquidBoundary(Point coordinates, out int liquidAmount, out int liquidType)
		{
			return default(bool);
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x00027390 File Offset: 0x00025590
		[Token(Token = "0x60054A1")]
		[Address(RVA = "0x819468", Offset = "0x819468", VA = "0x819468", Slot = "14")]
		public override Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x000273A8 File Offset: 0x000255A8
		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x8196B0", Offset = "0x8196B0", VA = "0x8196B0")]
		protected Vector2 GetBobbingOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0400980F RID: 38927
		[Token(Token = "0x400980F")]
		[FieldOffset(Offset = "0x0")]
		public static FlyerLeashedCritter Prototype;

		// Token: 0x04009810 RID: 38928
		[Token(Token = "0x4009810")]
		[FieldOffset(Offset = "0x84")]
		protected int minWaitTime;

		// Token: 0x04009811 RID: 38929
		[Token(Token = "0x4009811")]
		[FieldOffset(Offset = "0x88")]
		protected int maxWaitTime;

		// Token: 0x04009812 RID: 38930
		[Token(Token = "0x4009812")]
		[FieldOffset(Offset = "0x8C")]
		protected float maxFlySpeed;

		// Token: 0x04009813 RID: 38931
		[Token(Token = "0x4009813")]
		[FieldOffset(Offset = "0x90")]
		protected float acceleration;

		// Token: 0x04009814 RID: 38932
		[Token(Token = "0x4009814")]
		[FieldOffset(Offset = "0x94")]
		protected int brakeDuration;

		// Token: 0x04009815 RID: 38933
		[Token(Token = "0x4009815")]
		[FieldOffset(Offset = "0x98")]
		protected float rotationScalar;

		// Token: 0x04009816 RID: 38934
		[Token(Token = "0x4009816")]
		[FieldOffset(Offset = "0x9C")]
		protected float hoverAmplitude;

		// Token: 0x04009817 RID: 38935
		[Token(Token = "0x4009817")]
		[FieldOffset(Offset = "0xA0")]
		protected float hoverPeriod;

		// Token: 0x04009818 RID: 38936
		[Token(Token = "0x4009818")]
		[FieldOffset(Offset = "0xA4")]
		protected bool hasGroundBias;

		// Token: 0x04009819 RID: 38937
		[Token(Token = "0x4009819")]
		private const float HoverYVelocity = 0.0001f;
	}
}
