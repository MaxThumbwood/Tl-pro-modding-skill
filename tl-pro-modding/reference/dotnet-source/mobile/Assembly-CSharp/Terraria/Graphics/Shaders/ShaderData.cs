using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x20008C4")]
	public class ShaderData
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000934")]
		public Effect Shader
		{
			[Token(Token = "0x6004C06")]
			[Address(RVA = "0x6E2CD0", Offset = "0x6E2CD0", VA = "0x6E2CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x6E2CAC", Offset = "0x6E2CAC", VA = "0x6E2CAC")]
		public ShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x6E9050", Offset = "0x6E9050", VA = "0x6E9050", Slot = "4")]
		public virtual void Apply(Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x6E6604", Offset = "0x6E6604", VA = "0x6E6604", Slot = "5")]
		public virtual void Apply()
		{
		}

		// Token: 0x040090E0 RID: 37088
		[Token(Token = "0x40090E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly Asset<Effect> _shader;

		// Token: 0x040090E1 RID: 37089
		[Token(Token = "0x40090E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected string _passName;

		// Token: 0x040090E2 RID: 37090
		[Token(Token = "0x40090E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EffectPass _effectPass;
	}
}
