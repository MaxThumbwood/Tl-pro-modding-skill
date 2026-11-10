using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public class DroneCameraTracker
	{
		// Token: 0x060042C7 RID: 17095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x4F98B8", Offset = "0x4F98B8", VA = "0x4F98B8")]
		public void Track(Projectile proj)
		{
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x4F98E0", Offset = "0x4F98E0", VA = "0x4F98E0")]
		public void WorldClear()
		{
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x000204D8 File Offset: 0x0001E6D8
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x4F98F0", Offset = "0x4F98F0", VA = "0x4F98F0")]
		public bool TryTracking(out Vector2 cameraPosition)
		{
			return default(bool);
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x4F9A0C", Offset = "0x4F9A0C", VA = "0x4F9A0C")]
		public DroneCameraTracker()
		{
		}

		// Token: 0x04008A4B RID: 35403
		[Token(Token = "0x4008A4B")]
		[FieldOffset(Offset = "0x8")]
		private Projectile _trackedProjectile;

		// Token: 0x04008A4C RID: 35404
		[Token(Token = "0x4008A4C")]
		[FieldOffset(Offset = "0xC")]
		private int _lastTrackedType;
	}
}
