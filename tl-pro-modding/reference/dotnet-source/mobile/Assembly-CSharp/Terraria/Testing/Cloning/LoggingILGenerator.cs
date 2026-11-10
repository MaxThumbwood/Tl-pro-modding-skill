using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using Il2CppDummyDll;

namespace Terraria.Testing.Cloning
{
	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x20005F2")]
	internal sealed class LoggingILGenerator
	{
		// Token: 0x06003C71 RID: 15473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C71")]
		[Address(RVA = "0x1E5A1B8", Offset = "0x1E5A1B8", VA = "0x1E5A1B8")]
		public LoggingILGenerator(ILGenerator il, string header)
		{
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C72")]
		[Address(RVA = "0x1E5A268", Offset = "0x1E5A268", VA = "0x1E5A268")]
		public LocalBuilder DeclareLocal(Type type)
		{
			return null;
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x1E5A3A4", Offset = "0x1E5A3A4", VA = "0x1E5A3A4")]
		public void Emit(OpCode opcode)
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x1E5A46C", Offset = "0x1E5A46C", VA = "0x1E5A46C")]
		public void Emit(OpCode opcode, MethodInfo method)
		{
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x1E5A7FC", Offset = "0x1E5A7FC", VA = "0x1E5A7FC")]
		public void Emit(OpCode opcode, FieldInfo field)
		{
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x1E5ABA0", Offset = "0x1E5ABA0", VA = "0x1E5ABA0")]
		public void Emit(OpCode opcode, LocalBuilder local)
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x1E5AE4C", Offset = "0x1E5AE4C", VA = "0x1E5AE4C")]
		public void Emit(OpCode opcode, Type type)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0001E720 File Offset: 0x0001C920
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x1E5AF70", Offset = "0x1E5AF70", VA = "0x1E5AF70")]
		public Label DefineLabel()
		{
			return default(Label);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x1E5AF9C", Offset = "0x1E5AF9C", VA = "0x1E5AF9C")]
		public void MarkLabel(Label label)
		{
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x1E5B08C", Offset = "0x1E5B08C", VA = "0x1E5B08C")]
		public void Emit(OpCode opcode, Label label)
		{
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C7B")]
		[Address(RVA = "0x1E5B1B0", Offset = "0x1E5B1B0", VA = "0x1E5B1B0")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x040047BF RID: 18367
		[Token(Token = "0x40047BF")]
		[FieldOffset(Offset = "0x8")]
		private readonly ILGenerator il;

		// Token: 0x040047C0 RID: 18368
		[Token(Token = "0x40047C0")]
		[FieldOffset(Offset = "0xC")]
		public readonly StringBuilder log;
	}
}
