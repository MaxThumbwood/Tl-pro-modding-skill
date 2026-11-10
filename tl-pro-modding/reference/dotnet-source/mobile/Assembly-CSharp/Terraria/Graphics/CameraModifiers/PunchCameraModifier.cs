using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	public class PunchCameraModifier : FileAPI
	{
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06004D0E RID: 19726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D0F RID: 19727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094A")]
		public string UniqueIdentity
		{
			[Token(Token = "0x6004D0E")]
			[Address(RVA = "0x71C85C", Offset = "0x71C85C", VA = "0x71C85C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D0F")]
			[Address(RVA = "0x71C864", Offset = "0x71C864", VA = "0x71C864")]
			private set
			{
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06004D10 RID: 19728 RVA: 0x000242E8 File Offset: 0x000224E8
		// (set) Token: 0x06004D11 RID: 19729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094B")]
		public bool Finished
		{
			[Token(Token = "0x6004D10")]
			[Address(RVA = "0x71C86C", Offset = "0x71C86C", VA = "0x71C86C", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D11")]
			[Address(RVA = "0x71C874", Offset = "0x71C874", VA = "0x71C874")]
			private set
			{
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06004D12 RID: 19730 RVA: 0x00024300 File Offset: 0x00022500
		// (set) Token: 0x06004D13 RID: 19731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700094C")]
		public bool IsAScreenShake
		{
			[Token(Token = "0x6004D12")]
			[Address(RVA = "0x71C87C", Offset = "0x71C87C", VA = "0x71C87C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D13")]
			[Address(RVA = "0x71C884", Offset = "0x71C884", VA = "0x71C884")]
			set
			{
			}
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x71C88C", Offset = "0x71C88C", VA = "0x71C88C")]
		public PunchCameraModifier(Vector2 startPosition, Vector2 direction, float strength, float vibrationCyclesPerSecond, int frames, float distanceFalloff = -1f, [Optional] string uniqueIdentity)
		{
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x71C8F0", Offset = "0x71C8F0", VA = "0x71C8F0", Slot = "5")]
		public void Update(ref CameraInfo cameraInfo)
		{
		}

		// Token: 0x04009200 RID: 37376
		[Token(Token = "0x4009200")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int _framesToLast;

		// Token: 0x04009201 RID: 37377
		[Token(Token = "0x4009201")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Vector2 _startPosition;

		// Token: 0x04009202 RID: 37378
		[Token(Token = "0x4009202")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector2 _direction;

		// Token: 0x04009203 RID: 37379
		[Token(Token = "0x4009203")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _distanceFalloff;

		// Token: 0x04009204 RID: 37380
		[Token(Token = "0x4009204")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _strength;

		// Token: 0x04009205 RID: 37381
		[Token(Token = "0x4009205")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _vibrationCyclesPerSecond;

		// Token: 0x04009206 RID: 37382
		[Token(Token = "0x4009206")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _framesLasted;

		// Token: 0x04009207 RID: 37383
		[Token(Token = "0x4009207")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private string <UniqueIdentity>k__BackingField;

		// Token: 0x04009208 RID: 37384
		[Token(Token = "0x4009208")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <Finished>k__BackingField;

		// Token: 0x04009209 RID: 37385
		[Token(Token = "0x4009209")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool <IsAScreenShake>k__BackingField;
	}
}
