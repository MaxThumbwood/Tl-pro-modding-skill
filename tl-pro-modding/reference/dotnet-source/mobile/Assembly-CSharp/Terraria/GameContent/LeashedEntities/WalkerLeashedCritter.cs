using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A60 RID: 2656
	[Token(Token = "0x2000A60")]
	public class WalkerLeashedCritter : LeashedCritter
	{
		// Token: 0x06005502 RID: 21762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x822D68", Offset = "0x822D68", VA = "0x822D68")]
		public WalkerLeashedCritter()
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x000274C8 File Offset: 0x000256C8
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x822E48", Offset = "0x822E48", VA = "0x822E48")]
		protected bool AdvanceTargetPosition()
		{
			return default(bool);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x82309C", Offset = "0x82309C", VA = "0x82309C", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x823468", Offset = "0x823468", VA = "0x823468")]
		private void HandleFalling(Point16 tilePosition)
		{
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x8236C8", Offset = "0x8236C8", VA = "0x8236C8")]
		private void HandleWalking()
		{
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x82380C", Offset = "0x82380C", VA = "0x82380C", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x000274E0 File Offset: 0x000256E0
		[Token(Token = "0x6005508")]
		[Address(RVA = "0x8238BC", Offset = "0x8238BC", VA = "0x8238BC", Slot = "14")]
		public override Vector2 GetDrawOffset()
		{
			return default(Vector2);
		}

		// Token: 0x0400985F RID: 39007
		[Token(Token = "0x400985F")]
		[FieldOffset(Offset = "0x0")]
		public static WalkerLeashedCritter Prototype;

		// Token: 0x04009860 RID: 39008
		[Token(Token = "0x4009860")]
		private const int State_Standing = 0;

		// Token: 0x04009861 RID: 39009
		[Token(Token = "0x4009861")]
		private const int State_PickDirection = 1;

		// Token: 0x04009862 RID: 39010
		[Token(Token = "0x4009862")]
		private const int State_Walking = 2;

		// Token: 0x04009863 RID: 39011
		[Token(Token = "0x4009863")]
		private const int State_Falling = 3;

		// Token: 0x04009864 RID: 39012
		[Token(Token = "0x4009864")]
		private const int State_Recalling = 4;

		// Token: 0x04009865 RID: 39013
		[Token(Token = "0x4009865")]
		[FieldOffset(Offset = "0x84")]
		protected float walkingPace;
	}
}
