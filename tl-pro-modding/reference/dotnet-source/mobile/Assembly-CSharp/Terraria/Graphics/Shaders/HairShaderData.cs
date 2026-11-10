using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	public class HairShaderData : ShaderData
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x00023F10 File Offset: 0x00022110
		[Token(Token = "0x1700092F")]
		public bool ShaderDisabled
		{
			[Token(Token = "0x6004BBE")]
			[Address(RVA = "0x6E420C", Offset = "0x6E420C", VA = "0x6E420C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0x6E4214", Offset = "0x6E4214", VA = "0x6E4214")]
		public HairShaderData(Asset<Effect> shader, string passName)
		{
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0x6E43D4", Offset = "0x6E43D4", VA = "0x6E43D4", Slot = "6")]
		public virtual void Apply(Player player, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x00023F28 File Offset: 0x00022128
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0x6E4D40", Offset = "0x6E4D40", VA = "0x6E4D40", Slot = "7")]
		public virtual Color GetColor(Player player, Color lightColor)
		{
			return default(Color);
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0x6E4E70", Offset = "0x6E4E70", VA = "0x6E4E70")]
		public HairShaderData UseColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x6E4EC0", Offset = "0x6E4EC0", VA = "0x6E4EC0")]
		public HairShaderData UseColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x6E4EB4", Offset = "0x6E4EB4", VA = "0x6E4EB4")]
		public HairShaderData UseColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x6E4F48", Offset = "0x6E4F48", VA = "0x6E4F48")]
		public HairShaderData UseImage(string path)
		{
			return null;
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x6E5090", Offset = "0x6E5090", VA = "0x6E5090")]
		public HairShaderData UseOpacity(float alpha)
		{
			return null;
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x6E5098", Offset = "0x6E5098", VA = "0x6E5098")]
		public HairShaderData UseSecondaryColor(float r, float g, float b)
		{
			return null;
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC8")]
		[Address(RVA = "0x6E50E8", Offset = "0x6E50E8", VA = "0x6E50E8")]
		public HairShaderData UseSecondaryColor(Color color)
		{
			return null;
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC9")]
		[Address(RVA = "0x6E50DC", Offset = "0x6E50DC", VA = "0x6E50DC")]
		public HairShaderData UseSecondaryColor(Vector3 color)
		{
			return null;
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BCA")]
		[Address(RVA = "0x6E5170", Offset = "0x6E5170", VA = "0x6E5170")]
		public HairShaderData UseSaturation(float saturation)
		{
			return null;
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x6E5178", Offset = "0x6E5178", VA = "0x6E5178")]
		public HairShaderData UseTargetPosition(Vector2 position)
		{
			return null;
		}

		// Token: 0x040090BB RID: 37051
		[Token(Token = "0x40090BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Vector3 _uColor;

		// Token: 0x040090BC RID: 37052
		[Token(Token = "0x40090BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Vector3 _uSecondaryColor;

		// Token: 0x040090BD RID: 37053
		[Token(Token = "0x40090BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected float _uSaturation;

		// Token: 0x040090BE RID: 37054
		[Token(Token = "0x40090BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected float _uOpacity;

		// Token: 0x040090BF RID: 37055
		[Token(Token = "0x40090BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected Asset<Texture2D> _uImage;

		// Token: 0x040090C0 RID: 37056
		[Token(Token = "0x40090C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool _shaderDisabled;

		// Token: 0x040090C1 RID: 37057
		[Token(Token = "0x40090C1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector2 _uTargetPosition;
	}
}
