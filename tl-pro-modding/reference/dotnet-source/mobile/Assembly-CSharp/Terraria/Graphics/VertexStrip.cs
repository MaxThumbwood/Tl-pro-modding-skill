using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

namespace Terraria.Graphics
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	public class VertexStrip
	{
		// Token: 0x06004B8C RID: 19340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x658B34", Offset = "0x658B34", VA = "0x658B34")]
		public void Reset(int expectedVertexCount = 0)
		{
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x6521DC", Offset = "0x6521DC", VA = "0x6521DC")]
		public void PrepareStrip(ref Vector2_DynamicArray_120 positions, ref Float_DynamicArray_120 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Microsoft.Xna.Framework.Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
		{
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x6571A4", Offset = "0x6571A4", VA = "0x6571A4")]
		public void PrepareStrip(Microsoft.Xna.Framework.Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Microsoft.Xna.Framework.Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
		{
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x654D3C", Offset = "0x654D3C", VA = "0x654D3C")]
		public void PrepareStripWithProceduralPadding(ref Vector2_DynamicArray_120 positions, ref Float_DynamicArray_120 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Microsoft.Xna.Framework.Vector2 offsetForAllPositions, bool includeBacksides = false)
		{
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x659010", Offset = "0x659010", VA = "0x659010")]
		public void PrepareStripWithProceduralPadding(Microsoft.Xna.Framework.Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, [Optional] Microsoft.Xna.Framework.Vector2 offsetForAllPositions, bool includeBacksides = false)
		{
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x659938", Offset = "0x659938", VA = "0x659938")]
		public void AddVertexPair(ref Microsoft.Xna.Framework.Vector2 a, ref Microsoft.Xna.Framework.Vector2 b, float uv_x, ref Microsoft.Xna.Framework.Graphics.Color vertexColor)
		{
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B92")]
		[Address(RVA = "0x659C38", Offset = "0x659C38", VA = "0x659C38")]
		public void AddVertexPair(ref Microsoft.Xna.Framework.Vector2 a, ref Microsoft.Xna.Framework.Vector2 b, float uv_x, ref Microsoft.Xna.Framework.Graphics.Color vertexColor, ref Microsoft.Xna.Framework.Graphics.Color vertexColor2)
		{
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B93")]
		[Address(RVA = "0x659ED4", Offset = "0x659ED4", VA = "0x659ED4")]
		public void AddVertexPair(Microsoft.Xna.Framework.Vector2 a, Microsoft.Xna.Framework.Vector2 b, Microsoft.Xna.Framework.Vector3 uvA, Microsoft.Xna.Framework.Vector3 uvB, Microsoft.Xna.Framework.Graphics.Color vertexColor)
		{
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x658E34", Offset = "0x658E34", VA = "0x658E34")]
		private void PrepareIndices(int vertexPaidsAdded)
		{
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x65A12C", Offset = "0x65A12C", VA = "0x65A12C")]
		public void PrepareIndices(bool includeBacksides)
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x658BB8", Offset = "0x658BB8", VA = "0x658BB8")]
		private void AddVertex(VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Microsoft.Xna.Framework.Vector2 pos, float rot, int indexOnVertexArray, float progressOnStrip)
		{
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x65247C", Offset = "0x65247C", VA = "0x65247C")]
		public void DrawTrail(bool includeBacksides)
		{
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x6532F0", Offset = "0x6532F0", VA = "0x6532F0")]
		public VertexStrip()
		{
		}

		// Token: 0x04009093 RID: 37011
		[Token(Token = "0x4009093")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private VertexStrip.CustomVertexInfo[] _vertices;

		// Token: 0x04009094 RID: 37012
		[Token(Token = "0x4009094")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int _vertexAmountCurrentlyMaintained;

		// Token: 0x04009095 RID: 37013
		[Token(Token = "0x4009095")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private short[] _indices;

		// Token: 0x04009096 RID: 37014
		[Token(Token = "0x4009096")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _indicesAmountCurrentlyMaintained;

		// Token: 0x04009097 RID: 37015
		[Token(Token = "0x4009097")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Microsoft.Xna.Framework.Vector2> _temporaryPositionsCache;

		// Token: 0x04009098 RID: 37016
		[Token(Token = "0x4009098")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<float> _temporaryRotationsCache;

		// Token: 0x04009099 RID: 37017
		[Token(Token = "0x4009099")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Microsoft.Xna.Framework.Graphics.Color vertColor;

		// Token: 0x020008B9 RID: 2233
		// (Invoke) Token: 0x06004B9A RID: 19354
		[Token(Token = "0x20008B9")]
		public delegate void StripColorFunction(float progressOnStrip, out Microsoft.Xna.Framework.Graphics.Color col);

		// Token: 0x020008BA RID: 2234
		// (Invoke) Token: 0x06004B9E RID: 19358
		[Token(Token = "0x20008BA")]
		public delegate float StripHalfWidthFunction(float progressOnStrip);

		// Token: 0x020008BB RID: 2235
		[Token(Token = "0x20008BB")]
		public struct CustomVertexInfo
		{
			// Token: 0x06004BA1 RID: 19361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA1")]
			[Address(RVA = "0x6E2340", Offset = "0x6E2340", VA = "0x6E2340")]
			public CustomVertexInfo(Microsoft.Xna.Framework.Vector2 position, Microsoft.Xna.Framework.Graphics.Color color, Microsoft.Xna.Framework.Vector3 texCoord)
			{
			}

			// Token: 0x0400909A RID: 37018
			[Token(Token = "0x400909A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Microsoft.Xna.Framework.Vector2 Position;

			// Token: 0x0400909B RID: 37019
			[Token(Token = "0x400909B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Color32 Color;

			// Token: 0x0400909C RID: 37020
			[Token(Token = "0x400909C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Microsoft.Xna.Framework.Vector3 TexCoord;
		}
	}
}
