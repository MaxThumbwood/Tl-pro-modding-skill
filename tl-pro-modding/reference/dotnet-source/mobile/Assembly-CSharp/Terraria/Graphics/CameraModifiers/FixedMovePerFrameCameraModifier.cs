using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	public class FixedMovePerFrameCameraModifier : FileAPI
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06004D06 RID: 19718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D07 RID: 19719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000947")]
		public string UniqueIdentity
		{
			[Token(Token = "0x6004D06")]
			[Address(RVA = "0x71C55C", Offset = "0x71C55C", VA = "0x71C55C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D07")]
			[Address(RVA = "0x71C564", Offset = "0x71C564", VA = "0x71C564")]
			private set
			{
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x000242B8 File Offset: 0x000224B8
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000948")]
		public bool Finished
		{
			[Token(Token = "0x6004D08")]
			[Address(RVA = "0x71C56C", Offset = "0x71C56C", VA = "0x71C56C", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D09")]
			[Address(RVA = "0x71C574", Offset = "0x71C574", VA = "0x71C574")]
			private set
			{
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x000242D0 File Offset: 0x000224D0
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000949")]
		public bool IsAScreenShake
		{
			[Token(Token = "0x6004D0A")]
			[Address(RVA = "0x71C57C", Offset = "0x71C57C", VA = "0x71C57C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D0B")]
			[Address(RVA = "0x71C584", Offset = "0x71C584", VA = "0x71C584")]
			set
			{
			}
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x71C58C", Offset = "0x71C58C", VA = "0x71C58C")]
		public FixedMovePerFrameCameraModifier(Vector2 startPosition, Vector2 offset, float movePerFrameX, float movePerFrameY, [Optional] string uniqueIdentity)
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x71C5E0", Offset = "0x71C5E0", VA = "0x71C5E0", Slot = "5")]
		public void Update(ref CameraInfo cameraInfo)
		{
		}

		// Token: 0x040091F9 RID: 37369
		[Token(Token = "0x40091F9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Vector2 _startPosition;

		// Token: 0x040091FA RID: 37370
		[Token(Token = "0x40091FA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector2 _offset;

		// Token: 0x040091FB RID: 37371
		[Token(Token = "0x40091FB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _movePerFrameX;

		// Token: 0x040091FC RID: 37372
		[Token(Token = "0x40091FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _movePerFrameY;

		// Token: 0x040091FD RID: 37373
		[Token(Token = "0x40091FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string <UniqueIdentity>k__BackingField;

		// Token: 0x040091FE RID: 37374
		[Token(Token = "0x40091FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool <Finished>k__BackingField;

		// Token: 0x040091FF RID: 37375
		[Token(Token = "0x40091FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool <IsAScreenShake>k__BackingField;
	}
}
