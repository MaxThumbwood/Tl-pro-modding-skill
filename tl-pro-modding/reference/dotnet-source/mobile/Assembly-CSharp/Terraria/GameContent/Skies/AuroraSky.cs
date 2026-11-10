using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000C7E RID: 3198
	[Token(Token = "0x2000C7E")]
	public class AuroraSky : CustomSky
	{
		// Token: 0x06005EB8 RID: 24248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x9C945C", Offset = "0x9C945C", VA = "0x9C945C", Slot = "4")]
		public override void OnLoad()
		{
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x9C9460", Offset = "0x9C9460", VA = "0x9C9460", Slot = "8")]
		public override void Update(GameTime gameTime)
		{
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0x9C9580", Offset = "0x9C9580", VA = "0x9C9580", Slot = "9")]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0x9CB2A8", Offset = "0x9CB2A8", VA = "0x9CB2A8")]
		public static void ModifyTileColor(ref Color tileColor, float intensity)
		{
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBC")]
		[Address(RVA = "0x9CB4D4", Offset = "0x9CB4D4", VA = "0x9CB4D4", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0x9CB4E0", Offset = "0x9CB4E0", VA = "0x9CB4E0", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0x9CB4EC", Offset = "0x9CB4EC", VA = "0x9CB4EC", Slot = "11")]
		public override void Reset()
		{
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0x9CB4FC", Offset = "0x9CB4FC", VA = "0x9CB4FC", Slot = "10")]
		public override bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0x9CB504", Offset = "0x9CB504", VA = "0x9CB504")]
		public AuroraSky()
		{
		}

		// Token: 0x04009E22 RID: 40482
		[Token(Token = "0x4009E22")]
		[FieldOffset(Offset = "0x14")]
		private UnifiedRandom _random;

		// Token: 0x04009E23 RID: 40483
		[Token(Token = "0x4009E23")]
		[FieldOffset(Offset = "0x18")]
		private bool _isActive;

		// Token: 0x04009E24 RID: 40484
		[Token(Token = "0x4009E24")]
		[FieldOffset(Offset = "0x19")]
		private bool _isLeaving;

		// Token: 0x04009E25 RID: 40485
		[Token(Token = "0x4009E25")]
		[FieldOffset(Offset = "0x1C")]
		private float _opacity;

		// Token: 0x04009E26 RID: 40486
		[Token(Token = "0x4009E26")]
		[FieldOffset(Offset = "0x20")]
		private VertexStrip vertexStrip;

		// Token: 0x04009E27 RID: 40487
		[Token(Token = "0x4009E27")]
		private const int stripNCountMax = 140;

		// Token: 0x04009E28 RID: 40488
		[Token(Token = "0x4009E28")]
		private const int stripNCountMin = 90;

		// Token: 0x04009E29 RID: 40489
		[Token(Token = "0x4009E29")]
		[FieldOffset(Offset = "0x24")]
		private Color _lastSkyColor;
	}
}
