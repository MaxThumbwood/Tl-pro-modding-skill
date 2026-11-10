using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Enums;

namespace Terraria.DataStructures
{
	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	public struct NPCAimedTarget
	{
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00020640 File Offset: 0x0001E840
		[Token(Token = "0x17000827")]
		public bool Invalid
		{
			[Token(Token = "0x6004346")]
			[Address(RVA = "0x4FE740", Offset = "0x4FE740", VA = "0x4FE740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x00020658 File Offset: 0x0001E858
		[Token(Token = "0x17000828")]
		public Vector2 Center
		{
			[Token(Token = "0x6004347")]
			[Address(RVA = "0x4FE750", Offset = "0x4FE750", VA = "0x4FE750")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x00020670 File Offset: 0x0001E870
		[Token(Token = "0x17000829")]
		public Vector2 Size
		{
			[Token(Token = "0x6004348")]
			[Address(RVA = "0x4FE838", Offset = "0x4FE838", VA = "0x4FE838")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004349")]
		[Address(RVA = "0x4FE86C", Offset = "0x4FE86C", VA = "0x4FE86C")]
		public NPCAimedTarget(NPC npc)
		{
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600434A")]
		[Address(RVA = "0x4FE940", Offset = "0x4FE940", VA = "0x4FE940")]
		public NPCAimedTarget(Player player, bool ignoreTank = true)
		{
		}

		// Token: 0x04008AA0 RID: 35488
		[Token(Token = "0x4008AA0")]
		[FieldOffset(Offset = "0x0")]
		public NPCTargetType Type;

		// Token: 0x04008AA1 RID: 35489
		[Token(Token = "0x4008AA1")]
		[FieldOffset(Offset = "0x4")]
		public Rectangle Hitbox;

		// Token: 0x04008AA2 RID: 35490
		[Token(Token = "0x4008AA2")]
		[FieldOffset(Offset = "0x14")]
		public int Width;

		// Token: 0x04008AA3 RID: 35491
		[Token(Token = "0x4008AA3")]
		[FieldOffset(Offset = "0x18")]
		public int Height;

		// Token: 0x04008AA4 RID: 35492
		[Token(Token = "0x4008AA4")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 Position;

		// Token: 0x04008AA5 RID: 35493
		[Token(Token = "0x4008AA5")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 Velocity;
	}
}
