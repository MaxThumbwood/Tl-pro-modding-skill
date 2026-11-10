using System;
using Il2CppDummyDll;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public class GenerationProgress
	{
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075B")]
		public string Message
		{
			[Token(Token = "0x6003A5B")]
			[Address(RVA = "0x1E01758", Offset = "0x1E01758", VA = "0x1E01758")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x1E017D0", Offset = "0x1E017D0", VA = "0x1E017D0")]
			set
			{
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075C")]
		public string MessageNoFormatting
		{
			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x1E0185C", Offset = "0x1E0185C", VA = "0x1E0185C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A5E")]
			[Address(RVA = "0x1E01864", Offset = "0x1E01864", VA = "0x1E01864")]
			set
			{
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x0001D640 File Offset: 0x0001B840
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075D")]
		public double Value
		{
			[Token(Token = "0x6003A60")]
			[Address(RVA = "0x1E01928", Offset = "0x1E01928", VA = "0x1E01928")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6003A5F")]
			[Address(RVA = "0x1E0186C", Offset = "0x1E0186C", VA = "0x1E0186C")]
			set
			{
			}
		}

		// Token: 0x1700075E RID: 1886
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075E")]
		public double TotalWeightedProgress
		{
			[Token(Token = "0x6003A61")]
			[Address(RVA = "0x1E01934", Offset = "0x1E01934", VA = "0x1E01934")]
			set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x0001D658 File Offset: 0x0001B858
		[Token(Token = "0x1700075F")]
		public double TotalProgress
		{
			[Token(Token = "0x6003A62")]
			[Address(RVA = "0x1E01944", Offset = "0x1E01944", VA = "0x1E01944")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x1E0197C", Offset = "0x1E0197C", VA = "0x1E0197C")]
		public void Set(double value)
		{
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A64")]
		[Address(RVA = "0x1E01A38", Offset = "0x1E01A38", VA = "0x1E01A38")]
		public void Set(double value, double min, double max)
		{
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A65")]
		[Address(RVA = "0x1E01B00", Offset = "0x1E01B00", VA = "0x1E01B00")]
		public void Start(double weight)
		{
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x1E01B1C", Offset = "0x1E01B1C", VA = "0x1E01B1C")]
		public void End()
		{
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x1E01B3C", Offset = "0x1E01B3C", VA = "0x1E01B3C")]
		public GenerationProgress()
		{
		}

		// Token: 0x04004600 RID: 17920
		[Token(Token = "0x4004600")]
		[FieldOffset(Offset = "0x8")]
		private string _message;

		// Token: 0x04004601 RID: 17921
		[Token(Token = "0x4004601")]
		[FieldOffset(Offset = "0x10")]
		private double _value;

		// Token: 0x04004602 RID: 17922
		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0x18")]
		private double _totalWeightedProgress;

		// Token: 0x04004603 RID: 17923
		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x20")]
		public double TotalWeight;

		// Token: 0x04004604 RID: 17924
		[Token(Token = "0x4004604")]
		[FieldOffset(Offset = "0x28")]
		public double CurrentPassWeight;
	}
}
