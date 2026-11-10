using System;
using Il2CppDummyDll;

namespace Terraria.Social.Steam
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	public class CoreSocialModule : FileAPI
	{
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06003D38 RID: 15672 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003D39 RID: 15673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000030")]
		public static event Action OnTick
		{
			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x1E62508", Offset = "0x1E62508", VA = "0x1E62508")]
			add
			{
			}
			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x1E625E0", Offset = "0x1E625E0", VA = "0x1E625E0")]
			remove
			{
			}
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x1E626B8", Offset = "0x1E626B8", VA = "0x1E626B8", Slot = "4")]
		public void Initialize()
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x1E62954", Offset = "0x1E62954", VA = "0x1E62954")]
		private void PulseSteamTick()
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x1E6298C", Offset = "0x1E6298C", VA = "0x1E6298C")]
		private void PulseSteamCallback()
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x1E629C4", Offset = "0x1E629C4", VA = "0x1E629C4")]
		public static void Pulse()
		{
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x1E62A90", Offset = "0x1E62A90", VA = "0x1E62A90")]
		private void SteamTickLoop(object context)
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x1E62B40", Offset = "0x1E62B40", VA = "0x1E62B40")]
		private void SteamCallbackLoop(object context)
		{
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x1E62B44", Offset = "0x1E62B44", VA = "0x1E62B44", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x1E62B48", Offset = "0x1E62B48", VA = "0x1E62B48")]
		public CoreSocialModule()
		{
		}

		// Token: 0x04004824 RID: 18468
		[Token(Token = "0x4004824")]
		[FieldOffset(Offset = "0x0")]
		private static CoreSocialModule _instance;

		// Token: 0x04004825 RID: 18469
		[Token(Token = "0x4004825")]
		public const int SteamAppId = 2841280;

		// Token: 0x04004826 RID: 18470
		[Token(Token = "0x4004826")]
		[FieldOffset(Offset = "0x8")]
		private bool IsSteamValid;

		// Token: 0x04004828 RID: 18472
		[Token(Token = "0x4004828")]
		[FieldOffset(Offset = "0xC")]
		private object _steamTickLock;

		// Token: 0x04004829 RID: 18473
		[Token(Token = "0x4004829")]
		[FieldOffset(Offset = "0x10")]
		private object _steamCallbackLock;
	}
}
