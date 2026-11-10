using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	public class EmpressButterflyLeashedCritter : FlyLeashedCritter
	{
		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x000273C0 File Offset: 0x000255C0
		[Token(Token = "0x170009D1")]
		private float Opacity
		{
			[Token(Token = "0x60054AC")]
			[Address(RVA = "0x81A304", Offset = "0x81A304", VA = "0x81A304")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AD")]
		[Address(RVA = "0x81A398", Offset = "0x81A398", VA = "0x81A398", Slot = "13")]
		protected override void CopyToDummy()
		{
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AE")]
		[Address(RVA = "0x81A568", Offset = "0x81A568", VA = "0x81A568", Slot = "12")]
		protected override void VisualEffects()
		{
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x81B2D4", Offset = "0x81B2D4", VA = "0x81B2D4")]
		public EmpressButterflyLeashedCritter()
		{
		}

		// Token: 0x0400981C RID: 38940
		[Token(Token = "0x400981C")]
		[FieldOffset(Offset = "0x0")]
		public new static EmpressButterflyLeashedCritter Prototype;

		// Token: 0x0400981D RID: 38941
		[Token(Token = "0x400981D")]
		[FieldOffset(Offset = "0xA8")]
		private float fadeAmount;

		// Token: 0x0400981E RID: 38942
		[Token(Token = "0x400981E")]
		private const int FadeAwayCap = 50;
	}
}
